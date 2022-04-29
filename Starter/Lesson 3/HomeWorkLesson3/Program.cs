using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte summand1 = 1, summand2 = 2;
            int sum = 0;
            sum = summand1 + summand2;
            Console.WriteLine(sum);

            byte a = 5, b = 3;
            int difference = 0;
            difference = a - b;
            Console.WriteLine(difference);

            byte c = 2, d = 3;
            int product = 0;
            product = c * d;
            Console.WriteLine(product);

            byte e = 6, f = 2;
            int quotient = 0, remainder = 0;
            quotient = e / f;
            Console.WriteLine(quotient);

            remainder = e % f;
            Console.WriteLine(remainder);

            Console.ReadKey();


        }
    }
}
