//43. Напишите программу,которая найдет точку пересечения двух
// прямых,заданных уравнениями y=k1*x+b1,y=k2*x+b2; значения
// b1,k1,b2,k2 задаются пользователем.
// b1=2,k1=5,b2=4,k2=9->(-0,5;-0,5)
double Prompt(string message)
{
       Console.Write(message);
       double result=Convert.ToDouble(Console.ReadLine());
       return result;
}

void GrossPoint(double k1,double k2,double b1,double b2)
{
    if(( k1 == k2) && ( b1 == b2 ))
    Console.Write($"Прямые совпадают");
    else
    {
        if(k1 == k2)
        Console.Write($"Прямые параллельны");
        else
        {
            double x = (b2-b1)/(k1-k2);
            double y = k2*(b2-b1)/(k1-k2)+b2;
            Console.WriteLine($"Координаты точки пересечения:({x:f1};{y:f1})");
        }

    }
}
   double k1=Prompt("Введите значение k1:"); 
   double k2=Prompt("Введите значение k2:"); 
   double b1=Prompt("Введите значение b1:"); 
   double b2=Prompt("Введите значение b2:");
   GrossPoint(k1,k2,b1,b2); 

  