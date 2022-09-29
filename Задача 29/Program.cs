// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 31);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        Console.Write(array[i]);
        if (i != array.Length - 1) Console.Write(", ");
        if (i == array.Length - 1) Console.Write("]");
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);