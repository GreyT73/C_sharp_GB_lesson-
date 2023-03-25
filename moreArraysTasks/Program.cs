void FillArray(int[] collection)
{
    int lenegth = collection.Length;
    int index = 0;
    while (index < lenegth)
    {
        collection[index] = new Random().Next(1, 19);
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
    int position = -1;

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

FillArray(array);
array[3] = 4;
array[8] = 4;
PrintArray(array);
Console.WriteLine();


int pos = IndexOf(array, 77);
Console.WriteLine(pos);

