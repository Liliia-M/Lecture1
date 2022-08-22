Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

int sqr1 = numberA * numberA;
int sqr2 = numberB * numberB;

if (numberB == sqr1||numberA == sqr2)
{
    Console.WriteLine($"{numberA}, {numberB}->да");
}
else
{
   Console.WriteLine($"{numberA}, {numberB}->нет"); 
}