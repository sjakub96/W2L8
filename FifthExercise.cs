using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2L8
{
    public class FifthExercise
    {
        public void Exponentiation()
        {
            for (int i = 1; i < 21; i++)
            {
                int result = i * i * i;
                Console.WriteLine(result);
            }

            Console.WriteLine("Fifth exercise completed. Press any key to continue...");
            Console.ReadKey();
        }
    }
}
