﻿// Прогараммы выводит название дня недели по номеру


Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("*** Начало программы ***");
Console.WriteLine(" ");

Console.Write("Введите номер дня недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(" ");
Console.Write("День недели: ");

if (number == 1)
{
 Console.WriteLine("Понедельник");
}
else
{
 if (number == 2)
 {
  Console.WriteLine("Вторник");
 }
 else
 {
  if (number == 3)
  {
   Console.WriteLine("Среда");
  }
  else
  {
   if (number == 4)
   {
    Console.WriteLine("Четверг");
   }
   else
   {
    if (number == 5)
    {
     Console.WriteLine("Пятница");
    }
    else
    {
     if (number == 6)
     {
      Console.WriteLine("Суббота");
     }
     else
     {
      if (number == 7)
      {
       Console.WriteLine("Воскресенье");
      }
      else
      {
        Console.WriteLine(" ✌ Нет дня недели с таким номером ✌");
      }
     }
    }
   }
  }
 } 
}

Console.WriteLine(" ");
Console.WriteLine("*** Конец программы ***");
Console.WriteLine(" ");
Console.WriteLine(" ");