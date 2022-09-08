Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("*** Начало программы ***");
Console.WriteLine(" ");

Console.Write("Введите номер дня недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

string[]weekDays=new string[] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

Console.WriteLine(" ");

if (number>1&&number<7) 
{
 Console.Write("День недели: ");
 Console.WriteLine($"{weekDays [number-1]}");
}
else 
{
 Console.WriteLine(" ✌ Нет дня недели с таким номером ✌");
}

Console.WriteLine(" ");
Console.WriteLine("*** Конец программы ***");
Console.WriteLine(" ");
Console.WriteLine(" ");