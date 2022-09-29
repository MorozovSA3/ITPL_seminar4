// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetNumber()
{
    Console.Write("Введите число: ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int GetDigitsSum(int number)
{
    int sum = 0;
    while (number/10 >= 1)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    sum = sum + number;
    return sum;
}

int number = GetNumber();
Console.WriteLine("Сумма цифр числа " + number + " равна: " + GetDigitsSum(number));