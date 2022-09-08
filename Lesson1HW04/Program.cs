//  Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine(" \n");
Console.WriteLine("*** Начало программы ***\n");

Console.Write("Введите целое положительное число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(" ");

Console.WriteLine("Последовательность чётных положительных чисел:");
int number2 = 0;
while (number2 <= number)
{
 Console.Write(number2 + " ");
 number2 = number2 + 2;
}

Console.WriteLine(" \n");
Console.WriteLine("*** Конец программы ***\n");