using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Pratik", "parttime", 5);
            e1.CalSalary();
            Console.WriteLine(e1);

            Spacecraft s1 = new Spacecraft(101, "SpeaceX");
            Console.WriteLine(s1.flyobj());
            Console.WriteLine(s1);

            Airplane a1 = new Airplane(201, "Miraj");
            Console.WriteLine(a1.flyobj());
            Console.WriteLine(a1);

            Helicopter h1 = new Helicopter(301, "Healcate");
            Console.WriteLine(h1.flyobj());
            Console.WriteLine(h1);
        }
    }
}
