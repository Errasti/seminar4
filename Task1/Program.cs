Console.WriteLine("Введите число a:");
int a = int.Parse(Console.ReadLine());
int numbersSum = 0;

for(int i = 1; i <= a; i++)
{
    numbersSum = numbersSum + i;
}
Console.WriteLine(numbersSum);

