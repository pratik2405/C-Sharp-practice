using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            Console.WriteLine(c1.Calarea());
            Console.WriteLine(c1.Calperimeter());
            Console.WriteLine(c1);

            Triangle t1 = new Triangle(20, 10);
            Console.WriteLine("Area of triangle :");
            Console.WriteLine(t1.Calarea());
            
            Triangle t2=new Triangle(20, 10,20);
            Console.WriteLine("Perimeter of triangle :");
            Console.WriteLine(t2.Calperimeter());

            Reactangle r1 = new Reactangle(10, 5);
            r1.Calarea();
            Console.WriteLine(r1);

            Console.WriteLine("------------------------------------------------------------------");



            SavingAccount s1 = new SavingAccount(101, "Pratik", 5000);
            Console.WriteLine(s1);
            Console.WriteLine(s1.Withdrow(6000));
            Console.WriteLine(s1.Deposit(4000));

            Console.WriteLine("--------------------------------------------------------------------");

            CurrentAccount cur = new CurrentAccount(201, "Yash", 6000);
            Console.WriteLine(cur);
            Console.WriteLine(cur.Withdrow(6000));
            Console.WriteLine(cur.Deposit(4000));

        }
    }
}
