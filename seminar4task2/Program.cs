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
