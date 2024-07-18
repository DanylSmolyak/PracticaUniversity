using System;

class Program
{
    static void Main(string[] args)
    {
        // Зчитуємо кількість чисел р
        int r = int.Parse(Console.ReadLine());

        // Зчитуємо натуральні числа
        string[] numbers = Console.ReadLine().Split();
        int[] nums = new int[r];
        for (int i = 0; i < r; i++)
        {
            nums[i] = int.Parse(numbers[i]);
        }

        // Знаходимо НСК чисел
        int lcm = GetLCM(nums);

        // Виводимо результат
        Console.WriteLine(lcm);
    }

    // Функція для знаходження НСД двох чисел
    static int GetGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Функція для знаходження НСК двох чисел
    static int GetLCM(int a, int b)
    {
        return (a / GetGCD(a, b)) * b;
    }

    // Функція для знаходження НСК масиву чисел
    static int GetLCM(int[] nums)
    {
        int result = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            result = GetLCM(result, nums[i]);
        }
        return result;
    }
}