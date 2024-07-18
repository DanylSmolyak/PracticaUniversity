using System;

class Program
{
    static void Main(string[] args)
    {
        // Зчитуємо вхідні дані
        int n = int.Parse(Console.ReadLine());

        // Модуль
        int MOD = 12345;

        // Масиви для динамічного програмування
        int[] dp0 = new int[n + 1];
        int[] dp1 = new int[n + 1];
        int[] dp2 = new int[n + 1];

        // Початкові значення
        dp0[1] = 1;
        dp1[1] = 1;
        dp2[1] = 0;

        // Заповнюємо масиви dp
        for (int i = 2; i <= n; i++)
        {
            dp0[i] = (dp0[i - 1] + dp1[i - 1] + dp2[i - 1]) % MOD;
            dp1[i] = dp0[i - 1] % MOD;
            dp2[i] = dp1[i - 1] % MOD;
        }

        // Виводимо результат
        int result = (dp0[n] + dp1[n] + dp2[n]) % MOD;
        Console.WriteLine(result);
    }
}