Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

//int result1 = number/

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"{number}->да");
}
else
{
   Console.WriteLine($"{number}->нет"); 
}