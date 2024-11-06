using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Triangle : Shape
    {
        private int a, b, c;
        private int height,bases;
        private double area, perimeter;

        public Triangle(int height,int bases)
        {
            this.height = height; 
            this.bases = bases;
        }

        public Triangle(int a, int b, int c)
        {
           this.a = a; 
           this.b = b; 
           this.c = c;
        }

        public override double Calarea()
        {
            area =  (height * bases)/2;
            return area;
        }

        public override double Calperimeter()
        {
            perimeter = a + b + c; ;
            return perimeter;
        }

        public override string ToString()
        {
            return $"Area of triangle is ={area} & perimeter is = {perimeter}";

        }
    }
}
