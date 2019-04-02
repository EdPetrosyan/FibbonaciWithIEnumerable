using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FibbonaciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {            
            IEnumerable<BigInteger> bigs = Fibbonaci(10);
            foreach (var item in bigs)
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<BigInteger> Fibbonaci( BigInteger number)
        {
            //BigInteger a = 1;
            //BigInteger b = 0;
            //for (int i = 1; i <= number; i++)
            //{
            //    BigInteger c = BigInteger.Add(a,b);

            //    a = b;
            //    b = c;

            //    yield return c;
            //}

            if (number == 0) yield return 0;
            if (number <= 2) yield return 1;
            else
            {
                yield return Fibbonaci(number - 1).Last() + Fibbonaci(number - 2).Last();
            }
           
        }
    }
}
