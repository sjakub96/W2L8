using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2L8
{
    public class NinthExercise
    {
        public void Binary()
        {
            Console.WriteLine("Enter your number: ");

            string userInputString = Console.ReadLine();
            string result = string.Empty;

            if(int.TryParse(userInputString, out int userInput))
            {
                while (userInput > 0)
                {
                    int transientResult = userInput % 2;
                    userInput /= 2;
                    result = transientResult.ToString() + result;
                }

                Console.WriteLine(result);
                Console.WriteLine("Ninth exercise completed. Press any key to continue...");
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
