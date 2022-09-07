Console.Clear();
Console.WriteLine(" ***  Начало программы  ***");
Console.WriteLine(" ");
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("*");

int xa=20, ya=1,
    xb=60, yb=1,
    xc=1, yc=25,
    xe=80, ye=25;

     
Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

Console.SetCursorPosition(xe, ye);
Console.WriteLine("*");

int x=xa, y=ya; 

int count = 0;

while(count < 10000)
{
  int what = new Random().Next(0, 4); //[0;4)  0, 1, 2, 3
  if(what == 0)
 {
     x=(x+xa)/2;
     y=(y+ya)/2;
 }    
  if(what == 1)
 {
     x=(x+xb)/2;
     y=(y+yb)/2;
 }    
 if(what == 2)
 {
     x=(x+xc)/2;
     y=(y+yc)/2;
 }    
 if(what == 3)
 {
     x=(x+xe)/2;
     y=(y+ye)/2;
 }  

 Console.SetCursorPosition(x, y);
 Console.WriteLine(".");  
 count = count + 1; // или count+=1; или count++
}

Console.SetCursorPosition(1, 27);
Console.WriteLine(" ***   Конец программы   ***");