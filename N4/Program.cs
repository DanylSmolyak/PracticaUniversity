using System;

class Program
{
    static void Main(string[] args)
    {
        // Зчитуємо вхідні дані
        int n = int.Parse(Console.ReadLine());

        // Лічильник рівних дільників
        int count = 0;

        // Шукаємо рівних дільників
        for (int m = 1; m < n; m++)
        {
            if (n % m == n / m)
            {
                count++;
            }
        }

        // Виводимо результат
        Console.WriteLine(count);
    }
}