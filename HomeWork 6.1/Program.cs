/*Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.0, 7, 8, -2, -2 -> 21, -7, 567, 89, 223-> 4*/

Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine());  

Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine());  

Console.WriteLine("Введите третье число: ");
int z = int.Parse(Console.ReadLine());  

int[] mass = {x, y, z};
int[] newmass = newMass(mass);
Console.WriteLine(String.Join(", ", newmass));


int[] newMass (int[] mass)
{
    int[] res = new int[mass.Length];
    int count =0;
    for(int i=0; i<mass.Length; i++)
    {

        if(mass[i]>0)
        {
            res[i] = mass[i];
            count++;
        }
    }
    return count;
}


