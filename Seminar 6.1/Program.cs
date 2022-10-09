// Переворот одномерного массива.

int[] array = MyArray(8, 0, 20);
Console.WriteLine(String.Join(" ", array));

int[] reversArray = ReversArray2(array);
Console.WriteLine(String.Join(" ", reversArray));

ReversArray1(array);
Console.WriteLine(String.Join(" ", reversArray));

//Первый метод невозвратный

void ReversArray1(int[] array)
{
    for(int i = 0; i<array.Length/2; i++)
    {
        int k = array[i];
        array[i]=array[array.Length-i-1];
        array[array.Length-i-1]=k;
    }
}

//Метод для записи в новый массив:

int[] ReversArray2(int[] array)
{
    int[] result= new int[array.Length];
    for(int i=0; i<array.Length; i++)
    {
        result[i]=array[array.Length-i-1];
    }
    return result;
}

int[] MyArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for(int i=0; i<size; i++)
    {
        res[i]= new Random().Next(minValue, maxValue+1);
    }
    return res;
}
