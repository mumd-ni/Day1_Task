namespace Day1_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome In Islam's Carpet Cleaning Service");
            Console.WriteLine("Enter Number Of Small Carpets:");
            //i will use Convert.ToInt32 to convert the input string to  int
            int NumberOfSmallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number Of Large Carpets:");
            int NumberOfLargeCarpets = Convert.ToInt32(Console.ReadLine());
            // i will  calculate the cost of cleaning carpets
            int Cost = (NumberOfSmallCarpets * 25) + (NumberOfLargeCarpets * 35);
            // i will calculate the tax and total estimate
            double Tax = Cost * 0.06;
            double TotalEstimate = Cost + Tax;
            Console.WriteLine("===============================");
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine("Number of Small Carpets:" + NumberOfSmallCarpets);
            Console.WriteLine($"Number of large Carpet:{NumberOfLargeCarpets}");
            Console.WriteLine("Price per SmallCarpet : $25");
            Console.WriteLine("Price per LeCarpet : $35");
            Console.WriteLine($"Cost : ${Cost}");
            Console.WriteLine("Tax: $" + Tax);
            Console.WriteLine("===============================");
            Console.WriteLine("Total estimate: $" + TotalEstimate);
            Console.WriteLine("This estimate is valid for 30 days");
            Console.WriteLine("===============================");
            Console.WriteLine("Thank you for choosing Islam's Carpet Cleaning Service");
        }
    }
    }

