using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloadingmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator c1= new Calculator();
            //Console.WriteLine(c1.Add(5, 9));
            //Console.WriteLine(c1.Add(0.5, 9));
            //Console.WriteLine(c1.Add(5, 9, 6));
            //Console.WriteLine(c1.Add(5, 1.9));

            //Console.WriteLine(c1.Subtract(88, 77));
            //Console.WriteLine(c1.Subtract(10, 1.7));
            //Console.WriteLine(c1.Subtract(88, 77,5));

            //Console.WriteLine(c1.Multiply(5, 5));
            //Console.WriteLine(c1.Multiply(5, 1.5));
            //Console.WriteLine(c1.Multiply(5, 5 , 5));

            //Console.WriteLine(c1.divide(10,5));
            //Console.WriteLine(c1.divide(25, 5));

            Console.WriteLine("---------------------------------------------------------------------------------------");

            //Employee e1 = new Employee(101, "Pratik");
            //Employee e2 = new Employee(102, "Yash", 50000);
            //Employee e3 = new Employee(id: 103, name: "Sanjyot"); //Named argument
            //Console.WriteLine(e1.display());
            //Console.WriteLine(e2.display());
            //Console.WriteLine(e3.display());

            Console.WriteLine("---------------------------------------------------------------------------------------");

            Payment p1 = new Payment();
            p1.Paybill(500);

            Console.WriteLine("---------------------------------------------------------------------------------------");

            Payment p2 = new Payment();
            p2.Paybill(1000,"gpay");
        }
    }
}
