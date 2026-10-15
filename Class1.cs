using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Student Grade Calculator");
        Console.WriteLine("------------------------");

        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter first test score: ");
        double score1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second test score: ");
        double score2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter third test score: ");
        double score3 = Convert.ToDouble(Console.ReadLine());

        double average = (score1 + score2 + score3) / 3;

        Console.WriteLine("\nStudent: " + name);
        Console.WriteLine("Average score: " + average.ToString("F2"));

        if (average >= 70)
        {
            Console.WriteLine("Grade: A");
        }
        else if (average >= 60)
        {
            Console.WriteLine("Grade: B");
        }
        else if (average >= 50)
        {
            Console.WriteLine("Grade: C");
        }
        else
        {
            Console.WriteLine("Grade: D");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
