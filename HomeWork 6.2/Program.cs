/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Введите первую координату начальной точки первой прямой ");
double a1 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Введите вторую координату конечной точки первой прямой ");
double a2 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Введите первую координату начальной точки второй прямой ");
double b1 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Введите вторую  координату конечной точки второй прямой ");
double b2 = Convert.ToDouble(Console.ReadLine()!);


double x = 0; //координата по оси x
double y = 0; //координата по оси y

if((a1 != b1) && (a2 != b2))
{
  x=(b2-a2)/(a1-b1);
  y=(a1*(b2-a2))/(a1-b1)+b1; 
}
else
{
  Console.WriteLine("У заданных прямых нет точек пересечения");
}
Console.WriteLine($"Координаты точки пересечения({x=x:f1} ; {y=y:f1})");