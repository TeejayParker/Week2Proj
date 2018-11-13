

using System;

namespace WelcomeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define Variables
            string softwareDeveloperName = "Teejay";
            string streetAddress = "123 Main St Anytown, USA";
            string grossMonthlyPay = "$3,525.00";
            string payTaxes = "$575.00";

            //Write to Console
            Console.WriteLine("Name: " + softwareDeveloperName);
            Console.WriteLine("Street Address: " + streetAddress);
            Console.WriteLine("grossMonthlyPay: " + grossMonthlyPay);
            Console.WriteLine("Taxes: " + payTaxes);

            //Show Console
            Console.ReadLine();
        }
    }
}
