// Task1

/*
Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(System.Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}
*/


// Task2


Console.WriteLine("Введите кардинату X: ");
int x = Convert.ToInt32(System.Console.ReadLine());
Console.WriteLine("Введите кардинату Y: ");
int y = Convert.ToInt32(System.Console.ReadLine());
if (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        System.Console.WriteLine("1 четверть");
    }
    if (x < 0 && y > 0)
    {
        System.Console.WriteLine("2 четверть");
    }
    if (x < 0 && y < 0)
    {
        System.Console.WriteLine("3 четверть");
    }
    if (x > 0 && y < 0)
    {
        System.Console.WriteLine("4 четверть");
    }
}
else System.Console.WriteLine("Вы ввели нулевые кардинаты");
