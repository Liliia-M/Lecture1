int[] array = { 1, 12, 31, 4, 18, 16, 17, 18 };
//              0   1   2  3   4   5   6   7
int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;//прерви - чтобы показывал только первое значение find из всех имеющихся
    }
        //index = index + 1
        index++;
}

