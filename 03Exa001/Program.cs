// Программы вычесление квадрата и куба введённого числа.

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("*** Начало программы ***");
Console.WriteLine(" ");

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number*number;
Console.WriteLine($"Квадрат числа {number} равен: {sqr}");

int sqr1 = Convert.ToInt32(Math.Pow(number,3));
Console.WriteLine($"Куб числа {number} равен: {sqr1}");

Console.WriteLine(" ");
Console.WriteLine("*** Конец программы ***");
Console.WriteLine(" ");
Console.WriteLine(" ");