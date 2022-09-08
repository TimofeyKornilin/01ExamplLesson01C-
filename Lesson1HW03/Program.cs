// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine(" \n");
Console.WriteLine("*** Начало программы ***\n");

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(" ");

int number2 = ((number*10)/2)%10;

if (number2==0)
Console.WriteLine("Да, введённое число являеться чётным");
else
Console.WriteLine("Нет, введённое число не являеться чётным");

Console.WriteLine(" ");
Console.WriteLine("*** Конец программы ***\n");
Console.WriteLine(" ");