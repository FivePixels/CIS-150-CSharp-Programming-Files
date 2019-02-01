using static System.Console;

namespace TakeHomePay
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //constants
            string newLine = System.Environment.NewLine;
            double comRate = 0.07;
            double fedTax = 0.18;
            double ssTax = 0.09;
            double rContr = 0.15;


            WriteLine("You will be asked to enter the name of an employee and their weekly sales. Calculations will be performed to determine their deductions and take home pay.{0}", newLine);
            Write("Please enter an employee name: ");
            string employeeName = ReadLine();
            Write("Please enter this employee's weekly sales: $"); // if you're reading this, don't use commas!
            string employeeSales = ReadLine();
            WriteLine();

            double grossPayMath()
            {
                return int.Parse(employeeSales) * comRate;
            }
            double fedMath()
            {
                return grossPayMath() * fedTax;
            }
            double ssMath()
            {
                return grossPayMath() * ssTax;
            }
            double rContrMath()
            {
                return grossPayMath() * rContr;
            }
            double deducsMath()
            {
                return fedMath() + ssMath() + rContrMath();
            }
            double thp()
            {
                return grossPayMath() - deducsMath();
            }
            void summary()
            {
                WriteLine("Weekly Payroll App");
                WriteLine();
                WriteLine("Employee Name: {0}", employeeName);
                WriteLine();
                WriteLine("This week's Sales: ${0}", employeeSales);
                WriteLine("Commission Rate: {0}{1}", comRate, newLine);
                WriteLine("Gross Pay: ${0:F}", grossPayMath());
                WriteLine("Federal Taxes Withheld (18%): ${0:F}", fedMath());
                WriteLine("Soc. Sec. Taxes Withheld (9%): ${0:F}", ssMath());
                WriteLine("Retirement Contribution (15%): ${0:F}{1}", rContrMath(), newLine);
                WriteLine("Total Deductions: ${0:F}{1}", deducsMath(), newLine);
                WriteLine("Take Home Pay: ${0:F}", thp());
            }
            summary();
        }
    }
}