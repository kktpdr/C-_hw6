int[] GenerateArray(int len=10)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10, 10);
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

int Count(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]> 0)
        {
        sum++;
        } 
    }
    return sum;
}

int[] array = GenerateArray();
PrintArray(array);
System.Console.WriteLine(Count(array));