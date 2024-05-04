// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


Console.WriteLine("Введите массив строк через пробел:");
string input = Console.ReadLine();
string[] array = input.Split(' ');
string[] newArray = new string[array.Length];
int newArrayIndex = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
                {
                    newArray[newArrayIndex] = array[i];
                    newArrayIndex++;
                }
        }
Console.WriteLine("Новый массив строк:");
    for (int i = 0; i < newArray.Length; i++)
        {
            Console.Write($"{newArray[i]} ");
        }