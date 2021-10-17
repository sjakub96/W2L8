using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2L8
{
    public class SecondExercise
    {
        public void EvenNumbers()
        {
            int number = 0;

            do
            {
                number += 2;
                Console.Write($"{number} ");
            }
            while (number < 1000);
            Console.WriteLine();
            Console.WriteLine("Second exercise completed. Press any key to continue...");

            Console.ReadKey();
        }
    }
}
