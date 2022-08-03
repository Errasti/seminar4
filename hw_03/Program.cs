int[] fillArray(int n)
{
    int[] array = new int[n];
    Random rnd = new Random();
    for( int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100,100);
    }
    
    return array;
}

Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int [] arr = fillArray(size);

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}