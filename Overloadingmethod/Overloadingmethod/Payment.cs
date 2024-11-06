using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Overloadingmethod
{
    //3. Create a class Payment having a static method payBill
    // If you pay the bill by cash you are not eligible for any discount, method payBill(double amt)
    //If you pay by a mode you get 15% discount on the bill, method  payBill(double amt, String mode)

    public class Payment
    {
        private int pid;
        private string mode="cash";
        private double dist;

        //public Payment(int pid, string mode)
        //{
        //    this.pid = pid;
        //    this.mode = mode;
        //}

        public void Paybill(double amt)
        {
            if (mode == "cash")
            {
                Console.WriteLine("Discount is not avilable for cash mode !");
                Console.WriteLine("Payment=" + amt + "Rs");
            }
            else
            {
                dist = amt * 0.15;
                Console.WriteLine("Discount amt=" + dist+"Rs");
                double total = amt - dist;
                Console.WriteLine("you pay only=" + total+"Rs");
            }
        }

        public void Paybill(int amt, string mode)
        {
            this.mode = mode;
            if (mode == "cash")
            {
                Console.WriteLine("Discount is not avilable for cash mode !");
                Console.WriteLine("Payment=" + amt + "Rs");
            }
            else
            {
                dist = amt * 0.15;
                Console.WriteLine("Discount amt=" + dist + "Rs");
                double total = amt - dist;
                Console.WriteLine("you pay only=" + total + "Rs");
            }
        }

        }
}
