using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //4. Write a C# program to create an interface Flyable with a method called FlyObj().
    //Create three classes Spacecraft, Airplane, and Helicopter that implement the Flyable interface.
    //Implement the FlyObj() method for each of the three classes.
    public class Spacecraft : Flyable
    {
        private int sid;
        private string sname;

        public Spacecraft(int sid,string name)
        {
            this.sid = sid;
            this.sname = name;
        }

        public string flyobj()
        {
            return $"Inside SpaceCrapt";
        }

        public override string ToString()
        {
            return $"Spacecraft id={sid} / Name= {sname}";
        }

    }
}
