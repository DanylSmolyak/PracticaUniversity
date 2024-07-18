using System;

class Program
{
    static void Main(string[] args)
    {
        // Зчитуємо вхідне значення р
        int r = int.Parse(Console.ReadLine());

        // Якщо r = 0, не можна сформувати жодного числа
        if (r == 0)
        {
            Console.WriteLine(0);
            return;
        }

        // Масиви для динамічного програмування
        long[] dp0 = new long[r + 1];
        long[] dp1 = new long[r + 1];
        long[] dp2 = new long[r + 1];

        // Початкові значення для розряду 1
        dp0[1] = 1; // число "5"
        dp1[1] = 1; // число "9"
        dp2[1] = 2; // числа "5" та "9"

        // Обчислення для розрядів від 2 до r
        for (int i = 2; i <= r; i++)
        {
            dp0[i] = dp2[i - 1];             // можемо додати "5" до будь-якого числа з dp2[i-1]
            dp1[i] = dp2[i - 1];             // можемо додати "9" до будь-якого числа з dp2[i-1]
            dp2[i] = dp0[i - 1] + dp1[i - 1]; // можемо додати "5" або "9" до будь-якого числа з dp0[i-1] або dp1[i-1]
        }

        // Загальна кількість чисел з р розрядів
        long result = dp0[r] + dp1[r] + dp2[r];

        // Виведення результату
        Console.WriteLine(result);
    }
}