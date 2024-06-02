using System;

namespace Csharp 
{
    class GradeCalculator {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Grade Calculator!");
            Console.Write("Please enter your score: ");

            // Read the input grade from the user
            double grade = Convert.ToDouble(Console.ReadLine());

            // Validate the input grade
        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid grade! Grade must be between 0 and 100.");
        }
        else
        {
            // Determine the corresponding letter grade
            char letterGrade;
            if (grade >= 90)
            {
                letterGrade = 'A';
            }
            else if (grade >= 80)
            {
                letterGrade = 'B';
            }
            else if (grade >= 70)
            {
                letterGrade = 'C';
            }
            else if (grade >= 60)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }

            // Display the corresponding letter grade
            Console.WriteLine($"Your grade is: {letterGrade}");
        }

        Console.WriteLine("Thank you for using Grade Calculator!");
        }
    }
}
