using System;

namespace HW2Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Number - ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b < 15) Console.WriteLine("[0-14]");
            else if (b < 36) Console.WriteLine("[15-35]");
            else if (b < 51) Console.WriteLine("[36-50]");
            else if (b < 101) Console.WriteLine("[50-100]");
            else if (b != 0 - 100) Console.WriteLine("Error Input Number");
            Console.ReadKey();
        }
    }
}
