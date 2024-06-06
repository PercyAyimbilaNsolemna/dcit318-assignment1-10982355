//The constructor will be implemented in this class

using System;

namespace Csharp
{
    //Creates a traingle class
    class Triangle
    {
        //Declares a field nameOfShape
        protected string nameOfShape;

        //Declares and initializes a field sidesOfShape
        protected int sidesOfShape = 3;

        //Declares a no argument constructor for the Triangle class
        public Triangle()
        {
            //Initialize the nameOfShape field
            nameOfShape = "Triangle";
        }
    }
}