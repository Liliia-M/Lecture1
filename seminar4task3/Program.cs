// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] RunR()
{
int[] rarray = new int[8];

    for (int i = 0; i < rarray.Length; i++)
    {
        rarray[i] = new Random().Next(0, 2);
    }
    return rarray;

}


Console.WriteLine(String.Join(" ", RunR()));