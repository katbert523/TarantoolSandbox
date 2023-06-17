local data_module = {}

function data_module.load_data()
    local blocked_abonents_space = box.space.blocked_abonents

    blocked_abonents_space:insert{'1', 89998887766, false}
    blocked_abonents_space:insert{'2', 89998887755, true}
    blocked_abonents_space:insert{'3', 89998887744, false}
    blocked_abonents_space:insert{'4', 89998887733, false}

    local balance_storage_space = box.space.balance_storage

    balance_storage_space:insert{'1', 89998887766, 1000}
    balance_storage_space:insert{'2', 89998887755, 2000}
    balance_storage_space:insert{'3', 89998887744, 1000}
    balance_storage_space:insert{'4', 89998887733, 2000}
end

return data_module
