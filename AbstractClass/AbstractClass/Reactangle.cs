using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Reactangle : Shape
    {
        private int length;
        private int height;
        private double area;

        public Reactangle(int length, int height)
        {
            this.length = length;
            this.height = height;
        }
        public override double Calarea()
        {
            area= length*height;
            return area;
        }

        public override double Calperimeter()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Area of reactangle is ={area}";
        }
    }
}
