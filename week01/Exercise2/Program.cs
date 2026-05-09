using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string input = Console.ReadLine();

        int grade = int.Parse(input);

        if (grade > 100 || grade < 0)
        {
            Console.WriteLine("Your grade must be between 0 and 100");
            return;
        }
        
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int rest = grade % 10;
        string signal = "";

        if (rest >= 7 && letter != "A" && letter != "F")
        {
            signal = "+";
        }
        else if (rest < 3 && letter != "F" && grade < 100)
        {
            signal = "-";
        }

        Console.WriteLine($"Your letter is {letter}{signal}");
    }
}