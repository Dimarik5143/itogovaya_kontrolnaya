// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Введите строки через запятую: ");
string input = Console.ReadLine() ?? string.Empty;

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Введенный массив строк пуст.");
    return;
}
string[] inputArray = input.Split(',');

// Фильтрация массива строк
string[] resultArray = FilterArray(inputArray);

// Вывод результата
Console.WriteLine("Результат:");
PrintArray(resultArray);

string[] FilterArray(string[] inputArray)
{
    int count = 0;

    // Подсчет строк, удовлетворяющих условию
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }

    // Создание нового массива строк
    string[] resultArray = new string[count];
    int index = 0;

    // Заполнение нового массива строк
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArray[index] = inputArray[i];
            index++;
        }
    }
    return resultArray;
}
void PrintArray(string[] array)
{
    // Вывод массива строк
    foreach (string element in array)
    {
        Console.WriteLine(element);
    }
}