Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int i = 0;
while( num != 0 )
{
    num = num / 10;
    i++;
}
Console.Write(i);
