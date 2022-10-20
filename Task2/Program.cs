Console.Write("Введите первое число: ");
int numbera = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int numberb = int.Parse(Console.ReadLine() ?? "0");
int sqr1 = numbera * numbera;
int sqr2 = numberb * numberb;

if(sqr1 == numberb)
{
    Console.WriteLine($"Число {numberb} является квадратом числа {numbera}");
}
else
{
    Console.WriteLine($"Число {numberb} не является квадратом числа {numbera}");
}
if(sqr2 == numbera)
{
    Console.WriteLine($"Число {numbera} является квадратом числа {numberb}");
}
else
{
    Console.WriteLine($"Число {numbera} не является квадратом числа {numberb}");
}