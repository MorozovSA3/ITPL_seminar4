// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int GetNumber(string word)
{
    Console.Write("Введите число " + word + ": ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int GetPow(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

int a = GetNumber("A");
int b = GetNumber("B");

Console.Write("A в степени B: " + GetPow(a, b));