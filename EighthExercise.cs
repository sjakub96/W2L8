using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2L8
{
    public class EighthExercise
    {
        public void ReversedString()
        {
            Console.WriteLine("Enter your string: ");

            string userInputString = Console.ReadLine();
            int userStringLength = userInputString.Length - 1;

            string reversedString = string.Empty;

            while (userStringLength >= 0) 
            {
                reversedString = reversedString + userInputString[userStringLength];
                userStringLength--;
            }

            Console.WriteLine(reversedString);
            Console.WriteLine("Eighth exercise completed. Press any key to continue...");
            Console.ReadKey();

        }
    }
}
