namespace FirstConsoleApp;

using System;

class Program
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }

        var sum = numbers.Aggregate<int, double>(0, (current, number) => current + number);
        return sum / numbers.Length;
    }

    public static int FindMaximumValue(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }

        var maxValue = numbers[0];
        foreach (var number2 in numbers)
        {
            if (number2 > maxValue)
            {
                maxValue = number2;
            }
        }
        return maxValue;
    }
    
    static void Main(string[] args)
    {
        int[] exampleNumbers = { 1, 3, 5, 7, 9 };
        var average = CalculateAverage(exampleNumbers);
        Console.WriteLine($"Average: {average}");
        
        var max = FindMaximumValue(exampleNumbers);
        Console.WriteLine($"Maximum value: {max}");
    }
}
