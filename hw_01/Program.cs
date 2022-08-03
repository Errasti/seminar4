Console.WriteLine("Введите первое число: ");
int numOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numSec = int.Parse(Console.ReadLine());
int result = 1;

for (int i = 1; i<=numSec; i++)
{
    result = result * numOne;
}
Console.WriteLine("Первое число в степени второго = " + result);

