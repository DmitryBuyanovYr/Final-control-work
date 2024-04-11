/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из 
строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с 
клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/


System.Console.Write("Введи размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] array = new string[sizeArray];
string[] array2 = new string[array.Length / 2];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadLine()!;
    if (i < array2.Length)
    {
        array2[i] = array[i];
    }
}
System.Console.WriteLine();
for (int i = 0; i < array2.Length; i++)
{
    System.Console.Write($"{array2[i]}");
}






