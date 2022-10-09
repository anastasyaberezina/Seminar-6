// Принимает на вход 3 числа и проверяет, может ли существовать треугольник со сторонами определенной длины.


Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int z = int.Parse(Console.ReadLine());

if( x<(y+z) && y<(x+z) && z<(y+x) )
{
Console.WriteLine("Треугольник может существовать");
}
else
{
Console.WriteLine("Треугольник может существовать");
}







