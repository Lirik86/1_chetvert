int input(string msg)
{
    System.Console.WriteLine($"{msg} >");
    int value;
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

string[] myArray(int value)
{
    string[] array = new string[value];
    for (int i = 0; i < value; i++)
    {
        Console.Write($"Введите {i} эллемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] requestArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            System.Console.Write($"{array[i]}  ");
        }
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
}

int value = input("Введите размер  массива: ");
