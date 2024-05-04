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