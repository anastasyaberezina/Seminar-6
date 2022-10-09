// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());


string y = String.Empty;

while(x>0)
{
    int result = x%2;
    x=x/2;
    y=y+Convert.ToString(result);
}
Console.Write(y);

string k = String.Empty;

for(int i=y.Length-1; i>=0; i--)
{
    k=k+y[i];
}
Console.Write(k);