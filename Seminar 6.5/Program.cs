// Программа, создающая копию заданного массива с помощью поэлементного копирования.

int[] array = GetArray(9);
Console.WriteLine($"{String.Join(", ", array)}");

int[] newarray = ArrayRes(array);
Console.WriteLine(String.Join(", ", newarray));

int[] ArrayRes (int[] array)
{
    int[] res = new int[array.Length];
    for(int i=0; i<array.Length; i++)
    {
        res[i] = array[i];
    }
    return res;
}

int[] GetArray (int size)
{
    int[] result = new int[size];
    for(int i = 0; i<size; i++)
    {
        result[i] = new Random().Next(1, 90);
    }
    return result;
}

