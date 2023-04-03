/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int ConsoleReadInt(string text)
{
    Console.Write($"{text}: ");

    int read_int;

    while (true)
    {


        if (int.TryParse(Console.ReadLine(), out read_int))
        {
            return read_int;
        }
        else
        {
            Console.Write("Введено некорректное число, повторите попытку ввода:");
        }

    }
}

int Sum(int m, int n)
{
    if (m == n) return n;
    return m + Sum(m + 1, n);
}

int m = ConsoleReadInt("Введите значение М");
int n = ConsoleReadInt("Введите значение N");

Console.WriteLine(  $"сумму натуральных элементов в промежутке от M до N равна {Sum(m, n)}"    );