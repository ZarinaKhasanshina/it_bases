# it_bases

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

``[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]``

`[“1234”, “1567”, “-2”, “computer science”] → [“-2”]`

`[“Russia”, “Denmark”, “Kazan”] → []`

## Решение.
Согласоно условию поочередно проверяется длина всех элементов массива. Элементы удовдетворяющие словию перемещаются в начало, ведется учет коль-ва найенных элементов. По окончанию обработки массива, перные k элементов копируются в результирующий массив.  
![](./drawio/IT_bases.png)])
### Пример работы программы.
``Введите кол-во строк в массиве. Для использования примера нажмите <Enter>.``

``Введите длинну для фильтра строк (по усолчанию <= 3).``

``Получен массив: ["1", "12", "free", "four", "one", "two", "zero", "five", "six", "seven", "eight", "nine", "ten", ""]``

``Фильтруем массив ...``

``Найден подходящий элемент: 1. "1"``

``Найден подходящий элемент: 2. "12"``

``Найден подходящий элемент: 5. "one"``

``меняем >> "free" <-> "one":``
``["1", "12", "one", "four", "free", "two", "zero", "five", "six", "seven", "eight", "nine", "ten", ""]``

``Найден подходящий элемент: 6. "two"``

``меняем >> "four" <-> "two":``
``["1", "12", "one", "two", "free", "four", "zero", "five", "six", "seven", "eight", "nine", "ten", ""]``

``Найден подходящий элемент: 9. "six"``

``меняем >> "free" <-> "six":``
``["1", "12", "one", "two", "six", "four", "zero", "five", "free", "seven", "eight", "nine", "ten", ""]``

``Найден подходящий элемент: 13. "ten"``

``меняем >> "four" <-> "ten":``
``["1", "12", "one", "two", "six", "ten", "zero", "five", "free", "seven", "eight", "nine", "four", ""]``

``Найден подходящий элемент: 14. ""``

``меняем >> "zero" <-> "":``
``["1", "12", "one", "two", "six", "ten", "", "five", "free", "seven", "eight", "nine", "four", "zero"]``

``Массив элементов не более 3 символов: ["1", "12", "one", "two", "six", "ten", ""]``
