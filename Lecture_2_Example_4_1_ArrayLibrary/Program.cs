void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //int position = 0; ставим -1, чтобы сказать что такой элемент не найден, если такого эдемента нет в массиве

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
           
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
//new int[10] - создай новый массив, в котором будет 10 элементов

FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 304);
Console.WriteLine(pos);
