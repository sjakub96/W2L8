using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2L8
{
    public class FirstExercise
    {
        int counter = 0;
        public void Counter()
        {

            for (int i = 0; i < 101; i++)
            {
                IsPrime(i);
            }

            Console.WriteLine($"There are {counter} primes in the range 0 - 100");
            Console.WriteLine("First exercise completed. Press any key to continue...");
            Console.ReadKey();
        }

        public bool IsPrime(int a)
        {
             
            if(a == 1 || a == 0)
            {
                return false;
            }

            for (int i = 2; i < a; i++)
            {
                if(a % i == 0)
                {
                    return false;
                }
                
            }

            counter++;
            return true;

        }
    }
}
