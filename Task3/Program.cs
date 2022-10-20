Console.Write("Ввидите цифру плоскости: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if(number == 1)
{
    Console.WriteLine("Координаты Х = 0 до +бесконечность");
    Console.WriteLine("Координаты Y = 0 до +бесконечность");
}
else if (number == 2)
{
    Console.WriteLine("Координаты Х = 0 до -бесконечность");
    Console.WriteLine("Координаты Y = 0 до +бесконечность");
}
else if (number == 3)
{
    Console.WriteLine("Координаты Х = 0 до -бесконечность");
    Console.WriteLine("Координаты Y = 0 до -бесконечность");
}
else if (number == 4)
{
    Console.WriteLine("Координаты Х = 0 до +бесконечность");
    Console.WriteLine("Координаты Y = 0 до -бесконечность");
}