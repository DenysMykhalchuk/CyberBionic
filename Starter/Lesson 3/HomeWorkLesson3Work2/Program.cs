using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson3Work2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            int z = 3;
            x += y - x++ * z;
            z = --x - y * 5;
            Console.WriteLine($"x = {x}\ny = {y}\nz = {z}");
            y /= x + 5 % z;
            z = x++ + y * 5;
            x = y - x++ * z;
            Console.WriteLine($"x = {x}\n y = {y}\nz = {z}");
            Console.Read();
        }
    }
}
