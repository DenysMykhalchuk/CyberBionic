using System;

namespace HomeWork2_Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 11, z = 3;
            float av;
            av = (x + y + z) / 3;
            Console.WriteLine("Среднее арифметичесское чисел {0}, {1}, {2} = {3}", x, y, z, av);
            Console.ReadKey();
        }
    }
}
