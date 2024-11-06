using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Airplane : Flyable
    {
        private int id;
        private string name;

        public Airplane(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string flyobj()
        {
            return "inside Airplane";
        }

        public override string ToString()
        {
            return $"Airplane id={id} / Name={name}";
        }

    }
}
