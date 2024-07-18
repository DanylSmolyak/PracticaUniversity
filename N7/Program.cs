using System;

class Program
{
    static void Main(string[] args)
    {
        // Зчитуємо вхідні дані
        Console.WriteLine("Введіть координати і радіус першого кола (x1 y1 r1):");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double r1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть координати і радіус другого кола (x2 y2 r2):");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double r2 = double.Parse(Console.ReadLine());

        // Рахуємо кількість точок перетину
        int intersectionCount = CountIntersections(x1, y1, r1, x2, y2, r2);

        // Виводимо результат
        Console.WriteLine(intersectionCount);
    }

    static int CountIntersections(double x1, double y1, double r1, double x2, double y2, double r2)
    {
        // Відстань між центрами кіл
        double dx = x2 - x1;
        double dy = y2 - y1;
        double distance = Math.Sqrt(dx * dx + dy * dy);

        // Випадок, коли кола збігаються
        if (distance == 0 && r1 == r2)
        {
            return -1;
        }
        // Випадок, коли кола не перетинаються
        else if (distance > r1 + r2 || distance < Math.Abs(r1 - r2))
        {
            return 0;
        }
        // Випадок, коли кола торкаються в одній точці
        else if (distance == r1 + r2 || distance == Math.Abs(r1 - r2))
        {
            return 1;
        }
        // Випадок, коли кола перетинаються в двох точках
        else
        {
            return 2;
        }
    }
}