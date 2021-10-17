using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2L8
{
    public class FourthExercise
    {
        public void PyramidOfNumbers()
        {
            Console.WriteLine("Please input your number: ");

            string userInputString = Console.ReadLine();
            int counter = 1;

            if (int.TryParse(userInputString, out int userInput))
            {
                for (int i = 1; i <= userInput; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(counter);
                       
                        if(counter >= userInput)
                        {
                            break;
                        }
                        else
                        {
                            counter++;
                        }
                    }

                    Console.WriteLine(); 

                    if (counter >= userInput)
                    {
                        break;
                    }

                }

                Console.WriteLine("Fourth exercise completed. Press any key to continue...");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Invalid input data. Please enter some numbers...");
                Console.ReadKey();
            }
        }

    }
}
