using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Transaction t1 = new Transaction("001","8/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);

            t1.showTransactions();
            t2.showTransactions();
            Console.ReadKey();

        }

        public class Transaction : ITransactions
        {
            public string tCode;
            public string date;
            public double amount;

            //this is the constructor
            public Transaction()
            {
                tCode = " ";
                date = " ";
                amount = 0.0;
            }

            public Transaction(string code, string date, double amount)
            {
                this.tCode = code;
                this.date = date;
                this.amount = amount;
            }

            //This was a member of the ITransactions interface.
            public double getAmount()
            {
                return amount;
            }

            //This was a member of the ITransactions interface.
            public void showTransactions()
            {
                Console.WriteLine($"Transaction: {tCode}");
                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"Amount: {amount}");
            }

        }

        public interface ITransactions
        {

            //These are the interface members
            //When inheriting ITransactions, these must be created in the class.
            void showTransactions();
            double getAmount();


        }

        

    }
}
