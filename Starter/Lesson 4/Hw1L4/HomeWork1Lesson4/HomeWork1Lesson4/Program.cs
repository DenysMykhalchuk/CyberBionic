using System;

namespace HomeWork1Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 9, operand2 = 3;
            Console.Write("Введите operand 1\n");
            string operands = Console.ReadLine();
            Console.Write("Введите operand 2\n");
            operands = Console.ReadLine();
            operand1 = Convert.ToInt32(operands);
            operand2 = Convert.ToInt32(operands);
            Console.Write("Введите знак арифметичесского действия -");
            string arf = Console.ReadLine();
            switch (arf)
            {
                case "+":
                {
                    int rez = operand1 + operand2;
                    Console.WriteLine(rez);
                    break;
                }
                case "-":
                {
                    int rez = operand1 - operand2;
                    Console.WriteLine(rez);
                    break;
                }
                case "*":
                {
                    int rez = operand1 * operand2;
                    Console.WriteLine(rez);
                    break;
                }
                case "/":
                {
                    if (operand2 != 0)

                    {
                        int rez = operand1 / operand2;
                        Console.WriteLine(rez);
                        break;

                    }
                    else
                    {
                        Console.WriteLine("На 0 делить запрещено!\n");
                    }

                    break;


                }
                case "%":
                {
                    if (operand2 != 0)
                    {
                        int rez = operand1 % operand2;
                        Console.WriteLine(rez);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("На 0 делить запрещено!\n");
                    }

                    break;
                }
                default:
                {
                    Console.WriteLine("Ошибка ввода, выберите другой арифметичесский знак/n");
                    break;
                }

            }

            Console.ReadKey();


        }
    }
}
