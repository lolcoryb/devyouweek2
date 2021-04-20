using System;

namespace Class_Lab_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculator excercise

            Console.WriteLine("Welcome to C# Calculator.\r\n \r\nPlease enter the first number of your calculation\r\n");

            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Now choose the second number.\r\n");

            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a + b}\r\n");
            Console.WriteLine($"{a} - {b} = {a - b}\r\n");
            Console.WriteLine($"{a} / {b} = {a / b}\r\n");
            Console.WriteLine($"{a} * {b} = {a * b}\r\n");

            Console.ReadLine();
        }
    }
}
