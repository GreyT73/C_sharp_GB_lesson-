int[] array = { 1, 2, 12, 4, 5, 67, 8, 9, 10, 12 };

int n = array.Length;

int find = 12;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}