/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

//Функция запрашивает ввод числа и возвращает его.
int GetIntFromConsole()
{
    int console_int = 0;

    Console.Write("Введите кол-во строк: ");

    while(true)
    {
        if( int.TryParse(Console.ReadLine(), out console_int ) )
        {
            break;
        }
        else
        {
            Console.Write("Введено некорректное число, повторите попытку ввода:");
        }
    }
    return console_int;

}
//Функция возвращает строку с натуральными числами от n до 1
string PrintNaturalNumbers(int n)
{
    if(n == 1) return "1";
    return $"{n} {PrintNaturalNumbers(n-1)}";
}

Console.WriteLine(  PrintNaturalNumbers(    GetIntFromConsole() )   );