Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
int result = numberA/numberB %;

if (result == 0)
{
    Console.WriteLine($"кратно");
}
else
{
    Console.WriteLine($"кратно, остаток = {result}");
}



Console.Write("Enter first number = ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number = ");
int number2 = int.Parse(Console.ReadLine());

int ostatok = number1 % number2;

if (ostatok == 0)
{
    Console.WriteLine ("Первое число кратно второму");
}
else
{
    Console.WriteLine ($"Остаток = {ostatok}" );
}

