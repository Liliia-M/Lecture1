// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int GetNum(int num)
// {
//    int a = 0;
//    while(num>0)
//    {
//     a++;
//     num = num/10;   
//    }
//    return a;    
// }

// Console.WriteLine("Ведите число: ");
// int number = int.Parse(Console.ReadLine());

// Console.WriteLine($"{GetNum(number)}");

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
int GetNum(int num)
{
    int equal = 1;
    for(int i = 1; i <= num; i++)
    {
        equal = equal * i;
    }
    return equal;
}



Console.WriteLine("Ведите число N: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"{GetNum(number)}");