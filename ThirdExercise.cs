using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2L8
{
    public class ThirdExercise
    {
        public void Fibonacci()
        {

            Console.WriteLine("Enter the length of Fibonacci sequence.");

            string userInputString = Console.ReadLine();

            if (int.TryParse (userInputString, out int userInput))
            {
                int a = 0;
                int b = 1;

                for (int i = 0; i < userInput; i++)
                {
                    Console.WriteLine(b);

                    b += a;
                    a = b - a;
                }

                Console.WriteLine("Second exercise completed. Press any key to continue...");

                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Invalid input datas. Please enter some number...");
                Console.ReadKey();

            }


        }


    }
}
