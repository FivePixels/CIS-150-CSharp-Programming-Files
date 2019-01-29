using System;

namespace ChangeCounter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int change = 92;
            int quarter = 25;
            int dime = 10;
            int nickel = 5;
            int penny = 1;
            System.Console.WriteLine("         Changer App");
            System.Console.Write("Change Amount: $0.{0}", change);
            int reqQuarters = change / quarter;
            int reqDime = (change % quarter) / dime;
            int reqNickel = ((change % quarter) % dime) / nickel;
            int reqPenny = (((change % quarter) % dime) % nickel) / penny;
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("Quarters:  {0}", reqQuarters);
            System.Console.WriteLine("Dimes:     {0}", reqDime);
            System.Console.WriteLine("Nickels:   {0}", reqNickel);
            System.Console.WriteLine("Pennies:   {0}", reqPenny);
        }
    }
}
