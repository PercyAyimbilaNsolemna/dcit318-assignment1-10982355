//This programs extends on the concepts in the Multiple classes
//Implements encapsulation, inheritance, sonstructors, fields and access modifiers

using System;

namespace Csharp
{
    //The shapes class inherits the Triangle class
    class Shape : Triangle
    {
        //Declares the main method for the Shape class
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Shapes Program! \n");
            //Shape class instantiation
            //This calls the constructor for the Traingle class and the Shape class if there is
            Shape shape = new Shape();

            Console.WriteLine("The shape is a " + shape.nameOfShape + " with " + shape.sidesOfShape + " sides.");
        }

    }
}
