// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine(" \n");
Console.WriteLine("*** Начало программы ***\n");

Console.Write("Введите первое целое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine(" ");

if (number1>number2)
{
 Console.WriteLine($"Первое число {number1} больше второго числа {number2}");
}
else Console.WriteLine($"Второе число {number2} больше первого числа {number1}");

Console.WriteLine(" ");
Console.WriteLine("*** Конец программы ***\n");

