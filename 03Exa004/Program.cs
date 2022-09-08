// программы которая принимает на вход одно число (N),
// а на выходе показывает все целые числа в промежутке -N до N
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("*** Начало программы ***");
Console.WriteLine(" ");


Console.Write("Введите целое число от 1 до 20: ");
int number = int.Parse(Console.ReadLine());

int lastNumber = number * -1;

Console.WriteLine("Последовательность чисел:");

while (lastNumber <= number)
{
 Console.Write(lastNumber+" ");
 lastNumber = lastNumber + 1;
} 


Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("*** Конец программы ***");
Console.WriteLine(" ");
Console.WriteLine(" ");