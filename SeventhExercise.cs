using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2L8
{
    public class SeventhExercise
    {
        public void Diamond()
        {
            Console.WriteLine("Enter the length of the shorter diagonal: ");

            string userInputString = Console.ReadLine();

            if (int.TryParse(userInputString, out int userInput))
            {
                for (int i = 1; i <= userInput; i++)
                {
                    for (int j = 1; j <= userInput - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }

                for (int i = 1; i <= userInput - 1; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = userInput-1; k >= i; k--)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input data. Please enter some numbers...");
                Console.ReadKey();
            }

            Console.WriteLine("Seventh exercise completed. Press any key to continue...");
            Console.ReadKey();

        }
    }
}
