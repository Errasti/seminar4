Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

int result = 1;
for (int i=1; i<=a; i++)
{
    result = result * i;
}
Console.WriteLine(result);
