using System;

class Program
{
    static void Main(string[] args)
    {
        // Зчитуємо вхідне слово
        string word = Console.ReadLine();
        
        // Рахуємо кількість можливих анаграм
        int anagramsCount = CountAnagrams(word);
        
        // Виводимо результат
        Console.WriteLine(anagramsCount);
    }

    static int CountAnagrams(string word)
    {
        int length = word.Length;
        
        // Якщо довжина слова більше 14, повертаємо 0, так як умова задачі говорить про обмеження в 14 букв
        if (length > 14)
        {
            return 0;
        }

        // Рахуємо факторіал довжини слова
        long factorial = Factorial(length);

        // Рахуємо факторіали для кожної букви, щоб врахувати повтори
        foreach (char c in word)
        {
            int charCount = CountChar(word, c);
            if (charCount > 1)
            {
                factorial /= Factorial(charCount);
            }
        }

        return (int)factorial;
    }

    static long Factorial(int n)
    {
        if (n == 0) return 1;
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static int CountChar(string word, char c)
    {
        int count = 0;
        foreach (char ch in word)
        {
            if (ch == c)
            {
                count++;
            }
        }
        return count;
    }
}