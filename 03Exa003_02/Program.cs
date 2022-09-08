Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("*** Начало программы ***");
Console.WriteLine(" ");

Console.Write("Введите номер дня недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(" ");
Console.Write("День недели: ");

if (number == 1)  Console.WriteLine("Понедельник");
if (number == 2)  Console.WriteLine("Вторник");
if (number == 3)  Console.WriteLine("Среда");
if (number == 4)  Console.WriteLine("Четверг");
if (number == 5)  Console.WriteLine("Пятница");
if (number == 6)  Console.WriteLine("Суббота");
if (number == 7)  Console.WriteLine("Воскресенье");
if (number < 1) Console.WriteLine(" ✌ Нет дня недели с таким номером ✌");
if (number > 7) Console.WriteLine(" ✌ Нет нет дня недели с таким номером ✌");

Console.WriteLine(" ");
Console.WriteLine("*** Конец программы ***");
Console.WriteLine(" ");
Console.WriteLine(" ");