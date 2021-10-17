using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2L8
{
    public class TenthExercise
    {
        public void LeastCommonMultiple()
        {
            Console.Write("Enter first number: ");
            string firstNumberString = Console.ReadLine();

            Console.Write("Enter second number: ");
            string secondNumberString = Console.ReadLine();

            if((int.TryParse(firstNumberString, out int firstNumber)) && (int.TryParse(secondNumberString, out int secondNumber)))
            {

                int userInputFirstNumber = firstNumber;
                int userInputSecondNumber = secondNumber;

                while (firstNumber != secondNumber)
                {
                    if (firstNumber > secondNumber)
                    {
                        firstNumber = firstNumber - secondNumber;
                    }
                    else
                    {
                        secondNumber = secondNumber - firstNumber;
                    }
                }

                int leastCommonMultiple = (userInputFirstNumber * userInputSecondNumber) / firstNumber;

                Console.WriteLine($"Least Common Multiple is : {leastCommonMultiple}");
                Console.WriteLine("Tenth exercise completed. Press any key to continue...");
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
