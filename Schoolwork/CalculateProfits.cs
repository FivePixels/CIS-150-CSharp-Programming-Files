using static System.Console;

namespace CalculateProfits
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // constants
            int barsPerCase = 12;
            double wholesalePrice = 0.42;
            int pricePerCase = 5;
            double percentage = 0.10;
            string newLine = System.Environment.NewLine;

            WriteLine("This application shows how much is made on the granola sales project.");
            WriteLine("First you will be asked to enter the sale price per bar.");
            WriteLine("Then you will be asekd to enter the number of cases of granola bars sold.{0}", newLine);
            WriteLine("The amount of profit made on the granola sales will be displayed.{0}{1}", newLine, newLine);
            Write("Please enter the price per bar - i.e.  0.75: ");
            string pricePerBar = ReadLine();
            Write("{0}Please enter the number of cases sold: ", newLine);
            string casesSold = ReadLine();

            int barsSoldMath() 
            {
                return int.Parse(casesSold) * barsPerCase;
            }
            double grossSalesMath()
            {
                return double.Parse(pricePerBar) * barsSoldMath();
            }
            int costOfCandyMath()
            {
                return pricePerCase * int.Parse(casesSold);
            }
            double netSalesMath()
            {
                return grossSalesMath() - costOfCandyMath();
            }
            double feeMath()
            {
                return netSalesMath() * percentage;
            }
            double profitMath()
            {
                return grossSalesMath() - costOfCandyMath() - feeMath();
            }

            void summary()
            {
                WriteLine("Summary of Candy Sales{0}", newLine);
                WriteLine("Number of Cases Sold: {0}", casesSold);
                WriteLine("Number of Bars Per Case: {0}", barsPerCase);
                WriteLine("Number of Bars Sold: {0}{1}", barsSoldMath(), newLine);
                WriteLine("Wholesale Cost Per Bar: {0}", wholesalePrice);
                WriteLine("Selling Price Per Bar: {0}{1}", pricePerBar, newLine);
                WriteLine("Gross Sales: {0:F}", grossSalesMath());
                WriteLine("Cost of Candy: {0:F}", costOfCandyMath());
                WriteLine("Net Sales: {0:F}", netSalesMath());
                WriteLine("SGA Fee: {0:F}{1}{2}", feeMath(), newLine, newLine);
                WriteLine("******Profit: ${0:F}*", profitMath());
            }
            summary();
        }
    }
}