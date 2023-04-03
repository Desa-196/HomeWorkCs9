/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

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

int Accerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Accerman(m - 1, 1);
    else return Accerman(m - 1, Accerman(m, n - 1));
}


int m = Math.Abs(ConsoleReadInt("Введите m"));
int n = Math.Abs(ConsoleReadInt("Введите n"));

Console.WriteLine(Accerman(m, n));