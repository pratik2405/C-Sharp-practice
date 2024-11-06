using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Helicopter : Flyable
    {
        private int id;
        private string name;

        public Helicopter(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string flyobj()
        {
            return "inside Helicopter";
        }

        public override string ToString()
        {
            return $"Helicopter id={id} / Name={name}";
        }
    }
}
