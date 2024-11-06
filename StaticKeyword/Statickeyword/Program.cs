using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statickeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("pratik", 21);
            Student s2 = new Student("pratik", 21);

            Console.WriteLine(s1.display());
            Console.WriteLine(s2.display());
        }
    }
}
