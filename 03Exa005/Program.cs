// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("*** Начало программы ***");
label1:
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.Write("Введите трёхзначное положительное число: ");
int number = int.Parse(Console.ReadLine());

if (number>100&&number<1000)
{
//Console.WriteLine (number % 10);
int div = number/10;
int numberLast = number - (div*10);
Console.Write($"Последняя цифра введёного числа: {numberLast}");
}
else
{
 Console.Write("Введено не верное значение, повторите ввод");
 goto label1;
}

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("*** Конец программы ***");
Console.WriteLine(" ");
Console.WriteLine(" ");