// HW1a Sales Total

// Your Name: Chelsea Friedman
// Did you seek help ? If yes, specify the helper or web link here:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double Tax_Rate = 0.085;

            Console.Write("What Item are you purchasing? ");

            // Input item for sale (football ticket)
            string itemName1 = "Football Ticket";
            itemName1 = Console.ReadLine();


            // input quanity of sale 
            Console.Write("How many Football Tickets would you like to buy? ");
            int Quanityofsale=Convert.ToInt32(Console.ReadLine());

            // Price of item
            Console.Write("What is the price of each Football ticket? ");
            double Priceofproduct=Convert.ToDouble(Console.ReadLine());

            // calculations 
           
            double subtotal= Quanityofsale*Priceofproduct;
            Console.WriteLine($"Your subtotal for your bill is:{subtotal:c}");
            double salestax= Tax_Rate*subtotal;
            Console.WriteLine($"Your Sales Tax for your bill is:{salestax:C}");

            double total= salestax+subtotal;
            Console.WriteLine($"Your total for your bill is:{total:C}");






          

       

            Console.ReadKey();

        }
    }
}
