using System;

class Program
{
    static void Main(string[] args)
    {
        // Зчитуємо вхідні дані
        Console.WriteLine("Введіть координати початку і кінця вектора (x1 y1 x2 y2):");
        string[] input = Console.ReadLine().Split(' ');

        int x1 = int.Parse(input[0]);
        int y1 = int.Parse(input[1]);
        int x2 = int.Parse(input[2]);
        int y2 = int.Parse(input[3]);

        // Рахуємо довжину вектора
        double length = CalculateVectorLength(x1, y1, x2, y2);

        // Виводимо результат з точністю до шести знаків після коми
        Console.WriteLine(length.ToString("F6"));
    }

    static double CalculateVectorLength(int x1, int y1, int x2, int y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}