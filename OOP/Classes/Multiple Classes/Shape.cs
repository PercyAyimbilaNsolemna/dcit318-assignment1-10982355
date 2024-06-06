//This file elaborates on the concept of creating multiple classes in different files and calling them in one file

using System;

namespace Csharp 
{
    //The Shapes class inherits all the fields and methods in the Triangle class
    class Shapes : Triangle
    {
        //Will build on this

        //Main method
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the shapes program! \n");

            Shapes shape = new Shapes();

            Console.WriteLine("The name of the shape is " + shape.nameOfShape);
        }
    }
}
