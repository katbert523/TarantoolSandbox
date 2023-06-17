
https://habr.com/ru/companies/vk/articles/321998/#sozdanie-skripta-inicializacii

https://www.tarantool.io/ru/doc/latest/reference/reference_lua/box_space/drop/

вызвать процедуру из терминала:
box.func.<proc_name>:call({<parameters>})
****************************************************************************************
Запуск проекта: docker-compose up -d

При запуске тарантула дергается скрипт init.lua из которого вызывается скрипт загрузки
начальных данных data_module.lua. Схема расположения папок лежит здесь: ...\TarantoolSandbox\tarantool-sandbox-docs

Перезапустить проект с новыми настройками:
1. Останавливаем контейнер
2. Сносим снэпшоты и логи (без этого шага тарантул не стартанет)
3. docker-compose restart



