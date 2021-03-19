using System;


//  2d Arrays | C# | Tutorial 22

namespace CSharpExercises_22
{
    class Program
    {
        static void Main(string[] args)
        {
            // every element inside array is itself an array

            int[,] numberGrid = {
                // we populate the array here

                { 1, 2},   // <== this is the zeroeth element in the 2d array
                { 3, 4},   // the 1 is the zeroeth element within the sub array
                { 5, 6},
            };

            // another way to create array is 
            // telling C# 2 rows and 3 columns we want - 2 elements and within each
            // element there are 3 items
            int[,] myArray = new int[2, 3];

            Console.WriteLine(numberGrid[1, 1]);

            //Console.WriteLine(myArray[1, 1]); 
            Console.ReadLine();

        }
    }
}
