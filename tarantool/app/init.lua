#!/usr/bin/env tarantool
local initial_balance = 3000
local balance_field_position = 3
local block_status_position = 3

local function init()
    box.schema.space.create('blocked_abonents')
    box.space.blocked_abonents:create_index('primary', {unique = true, parts = {1, 'string'}})
    box.space.blocked_abonents:create_index('secondary', {unique = true, parts = {2, 'number'}})

    box.schema.space.create('call_data_records')
    box.space.call_data_records:create_index('primary', {unique = true, parts = {1, 'unsigned'}})

    box.schema.space.create('balance_storage')
    box.space.balance_storage:create_index('primary', {unique = true, parts = {1, 'string'}})
    box.space.balance_storage:create_index('secondary', {unique = true, parts = {2, 'number'}})
end

box.cfg
{
    pid_file = nil,
    background = false,
    log_level = 5
}

box.once("init", init)

local data_module = require('data_module')
box.once('load_data', data_module.load_data)

--***********************************************ПРОЦЕДУРЫ**************************************************************
--Апдейтим значения всех балансов 
function add_2_all_balances(amount)
    amount = amount or initial_balance
    for k, v in box.space.balance_storage:pairs() do
        box.space.balance_storage:update(v[1], {{'+', balance_field_position, amount}})
    end
end
box.schema.func.create('add_2_all_balances')

--Снять блокировку со всех абонентов
function unlock_abonents()
    for k, v in box.space.blocked_abonents:pairs() do
        box.space.blocked_abonents:update(v[1], {{'=', block_status_position, false}})
    end
end
box.schema.func.create('unlock_abonents')

--Создать новую call_data_record
function create_call_data_record(sender, receiver, date)
    box.space.call_data_records:auto_increment{sender, receiver, date}
end

box.schema.func.create('create_call_data_record')