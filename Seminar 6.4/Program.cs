// Не используя рекурсию, вывести все числа Фибоначчи от 0 и 1 до N.

Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine($"{String.Join("; ", Feb(x))}");

int[] Feb (int size)
{
    int[] result = new int[size];
    result[0] = 0;
    result[1] = 1;
    for(int i = 2; i<size; i++)
    {
        result[i] = result[i-1] + result[i-2];
    }
    return result;
}

