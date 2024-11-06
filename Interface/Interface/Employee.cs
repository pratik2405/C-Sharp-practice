using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //3. A company has employees and wants to keep a track of their names, id and hours of work.
    //The employees are specifically categorised into part-time and full-time.
    //Salary needs to be calculated for both however, where part-time employees get 200 rs.
    //Per hour and Full-time employees get 500 rs. per hour. Write a program which does the same.

    internal class Employee : Iemployee
    {
        private int eid,nhour;
        private string name,category;
        private double sal;

        public Employee(int eid, string name, string category,int nhour)
        {
            this.eid = eid;
            this.name = name;
            this.category = category;
            this.nhour = nhour;
        }

        public void CalSalary()
        {
            if (category == "fulltime")
            {
                sal = nhour * 500;
            }
            else
            {
                sal = nhour * 200;
            }
        }

        public override string ToString()
        {
            return $"Eid={eid} / Name={name} Category={category} / No. of working hours={nhour} / Salary={sal}";
        }
    }
}
