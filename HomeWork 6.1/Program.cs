/*Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.0, 7, 8, -2, -2 -> 21, -7, 567, 89, 223-> 4*/

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите четвертое число: ");
int d = int.Parse(Console.ReadLine()!);

int[] array = {a, b, c, d};
Console.WriteLine($"{String.Join(", ", array)}");

int[] newarray = ArrayRes(array);

int count1 = Result(newarray);
Console.WriteLine();
Console.WriteLine($"Среди введенных чисел больше нуля {count1}");

int[] ArrayRes (int[] array)
{
    int[] res = new int[array.Length];
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>0)
        {
        res[i] = array[i];
        }
    } 
    return res;
}

int Result (int[] newarray)
{
    int[] res1 = new int[newarray.Length];
    int count = 0;
    for(int w=0; w<newarray.Length; w++)
    {
        if(newarray[w]>0)
        {
        res1[w] = newarray[w];
        count++;
        }
    }
    return count;
}