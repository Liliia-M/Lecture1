int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int a1 = num / 100;
int a2 = (num/10) % 10;
int a3 = num % 10;
int a4 = a1*10;
int result = a3 + a4;

Console.WriteLine($"{result}");
