// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("*** Начало программы ***");
Console.WriteLine(" ");

Console.Write("Введите трёхзначное положительное число: ");
int number = int.Parse(Console.ReadLine());

//Console.WriteLine (number % 10);

int div = number/10;
int numberLast = number - (div*10);
Console.Write($"Последняя цифра введёного числа: {numberLast}");


Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("*** Конец программы ***");
Console.WriteLine(" ");
Console.WriteLine(" ");