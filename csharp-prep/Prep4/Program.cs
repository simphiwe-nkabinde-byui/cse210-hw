using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int sum = 0;
        int num =  -1;
        int max = 0;
        
        while (num != 0)
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numbers.Add(num);          
            }

        }

        foreach (int item in numbers)
        {
            sum += item;
            if (item > max) 
            {
                max = item;
            } 
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / numbers.Count}");
        Console.WriteLine($"The largest number is: {max}");

    }
}