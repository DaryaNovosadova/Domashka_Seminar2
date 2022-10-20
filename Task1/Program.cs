Console.WriteLine("Введите число дня: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if(number < 5)
{
    Console.WriteLine($"Этот день {number} является будним");
}
else
{
    Console.WriteLine($"Этот день {number} является выходним");
}