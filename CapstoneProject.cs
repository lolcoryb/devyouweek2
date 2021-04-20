using System;

namespace CapstoneProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~Welcome to the Capstone Project~\r\n");

            Console.WriteLine("Please enter your name : \r\n");
            string name = Console.ReadLine();

            Console.WriteLine($"\r\nWelcome {name}! Which of these two countries would you rather travel to? Jamaica or Jamaica?\r\n");
            string destination = Console.ReadLine();

            Console.WriteLine($"\r\nHow many days do plan on spending in {destination}?\r\n");
            double trip = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\r\nHow much spending money do you plan on bringing?\r\n");
            double spending = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\r\nSo {name}, you're planning on spending {trip} days in Jamaica with {spending:c} of spending money. You can spend {spending / trip:c} per day.\r\n");

            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
    }
}
