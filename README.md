Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.![ДЗ КОНТР](https://github.com/Dimarik5143/itogovaya_kontrolnaya/assets/146867278/59edd137-d4d6-4f1c-a4f9-1faee1ade6e3)


1. Ввод данных:

 - Пользователь вводит строки, разделенные запятой.
 - Введенные строки разбиваются на массив строк inputArray.

2. Проверка на нулевое значение:

 - Проверяется, является ли введенный массив строк пустым или null. Если да, программа выводит сообщение и завершает выполнение.

3. Фильтрация массива:

 - Создается новый массив строк resultArray, в котором будут храниться строки, длина которых меньше или равна 3 символам.
 - Производится подсчет подходящих строк для определения размера нового массива.

4. Заполнение нового массива:

 - Происходит заполнение resultArray строками из inputArray, удовлетворяющими условию.

5. Вывод результата:

 - Выводятся строки из resultArray.

Программа использует отдельные методы для четких этапов выполнения задачи: FilterArray для фильтрации массива и PrintArray для вывода результатов. 
Они также содержат проверки и комментарии для лучшей читаемости кода.

