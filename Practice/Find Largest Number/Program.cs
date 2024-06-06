using System;

namespace Csharp {
    class FindLargestNumber {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Find Largest Number Program! \n");

            //Creates an array of intergers to pass to the function to be called
            int[] arrayNumbers = {10, 50, 5, 20};

            //Calls the findLargestNumber function and stores the return value in largestNumber
            int largestNumber = findLargestNumber(arrayNumbers);
            Console.WriteLine("The largest number in the array is: " + largestNumber);
        }

        //Creates the find largest number function thjat returns the largest number in an array
        static int findLargestNumber(int[] array)
        {
            //Checks if the array is empty or null
            if (array == null || array.Length == 0)
            {
                throw new ArithmeticException("Array cannot be either null or empty");
            }

            //Sets the element at index as the largest number
            int largestNumber = array[0];

            //Loops through the array and update the largest number if any other number is greater than the initializec number
            for (int i = 1; i < array.Length; i++)
            {
                //Checks if the element at that index is greater than the current greatest number
                if (array[i] > largestNumber) {
                    largestNumber = array[i];
                }
            }
            
            //Returns the largest number in the array
            return largestNumber;
        }
    }
}
