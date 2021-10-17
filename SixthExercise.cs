using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2L8
{
    public class SixthExercise
    {
        public void SumOfFractions()
        {

            double sum = 0;

            for (double i = 1; i < 21; i++)
            {
                double result = 1 / i;
                Console.WriteLine(result);
                sum += result;
            }

            Console.WriteLine(sum);

            Console.WriteLine("Sixth exercise completed. Press any key to continue...");
            Console.ReadKey();
        }
    }
}
