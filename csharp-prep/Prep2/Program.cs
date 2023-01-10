using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string gradeStringValue = Console.ReadLine();
        int gradePercent = int.Parse(gradeStringValue);
        string letter;

        if (gradePercent >= 90) 
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"Letter grade: {letter}");


        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations!, You passed");
        }
        else 
        {
            Console.WriteLine("You have failed, Better luck next time");
        }
    }
}