using System;

namespace Csharp {
    //Creates a car class
    class Car 
    {
        //Creates a field called Blue
        protected string color = "Blue";

        //Creates the main method
        static void Main(string[] args)
        {
            //Creates an object from  the Car class, constructor
            Car newCar = new Car();

            //Outputs the color of the car
            Console.WriteLine("The color of the car is " + newCar.color);
        }
    }
}