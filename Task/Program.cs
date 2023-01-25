/* 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/
// Необходимые данные
Console.WriteLine("Дан массив: ");
string[] firstArray = new string [4] {"hello", "2", "world", ":-)"};
string[] secondArray = new string[firstArray.Length -1];
int count = 0;


PrinArray(firstArray);
SamplingFunction(firstArray, secondArray, count);

// Функция Выборки элементов первого массива
void SamplingFunction(string[] firstArray, string[] secondArray, int count)
{
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}

// Функция вывода первого массива на консоль
void PrinArray(string[] firstArray)
{
    Console.Write("[ ");
    for (int i = 0; i < firstArray.Length; i++)
    {
        Console.Write(firstArray[i] + ", ");
    }
    Console.Write(" ]");
    Console.WriteLine();
}

// Вывод на консоль
Console.WriteLine();
Console.WriteLine($"Отобранные элементы массива:[{string.Join("; ", secondArray)}]");
