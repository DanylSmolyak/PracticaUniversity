using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] times = input.Split(' ');
        
        double t1 = Convert.ToDouble(times[0]);
        double t2 = Convert.ToDouble(times[1]);
        double t3 = Convert.ToDouble(times[2]);
        
        double combinedRate = (1 / t1) + (1 / t2) + (1 / t3);
        double totalTime = 1 / combinedRate;
        
        Console.WriteLine("Необхідний час " + totalTime.ToString("F2"));
    }
}