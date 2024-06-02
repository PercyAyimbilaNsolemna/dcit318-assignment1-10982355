using System;

class TriangleTypeIdentifier
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Triangle Type Identifier!");
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");

        // Read the lengths of the sides from the user
        Console.Write("Side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Side 3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Check the type of triangle based on the lengths of the sides
        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is an Equilateral triangle.");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("The triangle is an Isosceles triangle.");
        }
        else
        {
            Console.WriteLine("The triangle is a Scalene triangle.");
        }

        Console.WriteLine("Thank you for using Triangle Type Identifier!");
    }
}
