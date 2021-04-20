using System;

namespace weektwohomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Execute AI personality Kindergarten Cop
            
            Console.WriteLine("I'm Detective John Kimble. I'm going to ask you a bunch of questions and I want to have them answered immediately.\r\n\r\n~~~\r\n");

            //Exercise 1: Fahrenheit to Celsius
            
            Console.WriteLine("What is the temperature outside in Fahrenheit?\r\n");

            double temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\r\nWho uses Fahrenheit? Lets convert it to Celsius.\r\n\r\n{temp} - 32 * .5556 = {(temp - 32) * .5556} C\r\n\r\n~~~\r\n");

            //Exercise 2: Sales Tax
            
            Console.WriteLine("So I hear you're selling bootleg CDs, how much?\r\n");

            double cost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\r\nAnd what's the sales tax on that? __%?\r\n");

            double tax = Convert.ToDouble(Console.ReadLine());

            double total = Convert.ToDouble($"\r\n{cost * (tax * .01) + cost}");

            Console.WriteLine($"\r\nSo that brings us to a total of {total:c}. Kinda weird that you're taxing bootlegs, but to each their own.\r\n\r\n~~~");

            //Exercise 3: Tip Calculator

            Console.WriteLine("\r\nOk, I'm ready to get out of here. Let's pay the bill. What's the total?\r\n");
            
            double billTotal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\r\nWhat % do you want to tip?\r\n");
            
            double tip = Convert.ToDouble(Console.ReadLine());
            
            double tipIncl = Convert.ToDouble($"\r\n{ billTotal * (tip * .01) + billTotal}");
            
            Console.WriteLine($"\r\nThe total comes to {tipIncl:c}.\r\n\r\n~~~");

            //Exercise 4: Bill Dividends

            Console.WriteLine("\r\nAnd how many people are splitting the bill?\r\n");
            
            double friends = Convert.ToDouble(Console.ReadLine());
            
            double amountEach = Convert.ToDouble($"{tipIncl / friends}");

            Console.WriteLine($"\r\nSo it looks like everyone has to pay {amountEach:c}\r\n");

            Console.WriteLine("Press ENTER to exit");
            
            Console.ReadLine();
        }
    }
}
