// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ['1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        string? x = Console.ReadLine();
        array[i] = x;
    }
}

void ReleaseArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i].Length < 4)
            Console.Write($"{array[i]},  ");
    }
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine();
ReleaseArray(array);
