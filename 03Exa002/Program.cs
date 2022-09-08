// Напишите программу которая принимает 2 числа
//и проверяет, являеться ли первая квадратом второго числа.
// 25, 5; 2, 10; 9, -3; -3, 5;

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("*** Начало программы ***");
Console.WriteLine(" ");

Console.Write("Введите число первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе первое число: ");
int number2 = int.Parse(Console.ReadLine());

int sqr2 = number2*number2;

if (sqr2 == number1)
{
 Console.WriteLine($"Да, число {number1} является квадратом числа {number2}");
}
else
{
 Console.WriteLine($"Нет, число {number1} не является квадратом числа {number2}");
}


Console.WriteLine(" ");
Console.WriteLine("*** Конец программы ***");
Console.WriteLine(" ");
Console.WriteLine(" ");