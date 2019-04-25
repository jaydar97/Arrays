using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Here is a manually populated array
                int[] elements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

                // Iterate through the array with a Foreach Loop
                foreach (int i in elements)
                {

                    Console.WriteLine("Element Value = " + i);

                }

                Console.WriteLine("__________________________________");
                Console.WriteLine("");


                Console.WriteLine("Press any key to exit the program.");

                // Pause the program and await the user to press a key to end the program
                Console.ReadKey(true);
            }// end of try
            catch
            {

                Console.WriteLine("Press any key to exit the program and try again ...");

                Console.ReadKey(true);
            }// end of catch



        }
    }
}
