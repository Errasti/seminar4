Console.WriteLine("Введите число: ");
int userNumber = int.Parse(Console.ReadLine());
int summ = 0;
while( userNumber != 0 )
{
    summ = summ + userNumber % 10;
    userNumber = userNumber / 10;
}
Console.WriteLine(summ);
