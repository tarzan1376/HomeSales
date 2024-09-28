using System;
using System.Runtime.ExceptionServices;

class HomeSales
{
    public static void Main(string[] args)
    {
        decimal danielleTotal = 0m;
        decimal edwardTotal = 0m;
        decimal francisTotal = 0m;

        while (true)
        {

            Console.WriteLine("Enter the Intial of your salesperson Danielle, Edward, or Francis and type Z when done: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "z")
            {
                break;
            }

            decimal saleAmount;

            switch (input.ToLower())
            {

                case "d":
                    Console.Write("Enter sale amount for Danielle: ");
                    break;
                case "e":
                    Console.Write("Enter sale amount for Edward: ");
                    break;
                case "f":
                    Console.Write("Enter sale amount for Francis: ");
                    break;
                default:
                    Console.WriteLine("intermediate output: Error, invalid salesperson selected, please try again");
                    continue;
            }

            if (decimal.TryParse(Console.ReadLine(), out saleAmount))
            {
                switch (input.ToLower())
                {
                    case "d":
                        danielleTotal += saleAmount;
                        break;
                    case "e":
                        edwardTotal += saleAmount;
                        break;
                    case "f":
                        francisTotal += saleAmount;
                        break;
                }

            }

        }

        decimal grandTotal = danielleTotal + edwardTotal + francisTotal;

        string highestSale = "";
        decimal highestTotal = 0m;



        if (danielleTotal > highestTotal)
        {
            highestTotal = danielleTotal;
            highestSale = "D";
        }
        if (edwardTotal > highestTotal)
        {
            highestTotal = edwardTotal;
            highestSale = "E";
        }
        if (francisTotal > highestTotal)
        {
            highestTotal = francisTotal;
            highestSale = "F";
        }

        Console.WriteLine("\nSales Totals:");
        if (danielleTotal > 0)
        {
            Console.WriteLine($"Danielle's Total: {danielleTotal:C}");
        }
        if (edwardTotal > 0)
        {
            Console.WriteLine($"Edward's Total: {edwardTotal:C}");
        }
        if (francisTotal > 0)
        { 
        Console.WriteLine($"Francis's Total: {francisTotal:C}");
        }
        Console.WriteLine($"Grand Total: {grandTotal:C}");
        Console.WriteLine($"Highest Sale: {highestSale}");

    }
}