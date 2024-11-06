using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloadingmethod
{
    //2. WAP to overload constructor in Employee class
    public class Employee
    {
        private int id;
        private string name;
        private double sal;
        public Employee(int id, string name, double sal)
        {
            this.id = id;
            this.name = name;
            this.sal = sal;
        }

        public Employee(int id,string name)
        {
            this.id = id;
            this.name = name;
        }

        public string Display()
        {
            return $"Id={id}/Name={name}/Sal={sal}";
        }
    }
}
