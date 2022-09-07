Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("*** Начало программы ***");
Console.WriteLine(" ");

int count = 0;
double distance = 10000;
int firstFriendSpeed = 3;
int secondFriendSpeed = 5;
int dogSpeed = 7;
int friendDog = 2;
double time = 0;

while(distance>1)
{
 if(friendDog == 1)
 {
     time = distance/(secondFriendSpeed + dogSpeed);
     friendDog = 2;
 }
 else
 {
     time = distance/(firstFriendSpeed + dogSpeed);
     friendDog = 1;
 }

   distance=distance-(firstFriendSpeed+secondFriendSpeed)*time;
   count = count + 1;
}

Console.Write("До встречи двух друзей собака пробежала от одного друга к другому ");
Console.Write(count);
Console.WriteLine(" раз.");
Console.WriteLine(" ");
Console.WriteLine("*** Конец прграммы ***");
Console.WriteLine(" ");
Console.WriteLine(" ");