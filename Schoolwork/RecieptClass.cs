using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptApp
{
    class ReceiptApp
    {
        static void Main(string[] args)
        {
            //TEST 1 
            Receipt receipt1 = new Receipt();
            receipt1.custName = "Indiana Jones";
            receipt1.custEmail = "jones@marshallcollege.edu";
            receipt1.addItem(3);
            receipt1.printReceipt();

            //TEST 2
            Receipt receipt2 = new Receipt("Arthur Curry", "aquaman@dccomics.org");
            receipt2.addItem(6);
            receipt2.printReceipt();

        }
    }
    class Receipt
    {
        public string custName;
        public string custEmail;
        public string ITEM_DESC = "Foo Bars";
        public double ITEM_PRICE = 19.95;
        public int quantity;
        public Receipt()
        {
            //empty constructor
        }
        public Receipt(string name, string email)
        {
            custName = name;
            custEmail = email;
        }
        public Receipt(string name, string email, int qty)
        {
            custName = name;
            custEmail = email;
            quantity = qty;
        }
        public void addItem(int number)
        {
            quantity = quantity + number;

            // I don't know if you wanted the quantity added (implied by name) or just set.
        }
        public double calculateTotal()
        {
            return quantity * ITEM_PRICE;
        }
        public void printReceipt()
        {
            Console.WriteLine(custName);
            Console.WriteLine(custEmail);
            Console.WriteLine(ITEM_DESC + ": Qty:{0}", quantity);
            Console.WriteLine("Total: " + calculateTotal());
        }
    }
}
