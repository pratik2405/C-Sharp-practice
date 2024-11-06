using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //2. Write a C# program to create an abstract class Shape with abstract methods calculateArea() and calculatePerimeter(). 
    //Create subclasses Circle and Triangle that inherit the Shape class and implement the respective methods
    //to calculate the area and perimeter of each shape.
    public class Circle : Shape
    {
        private int r;
        private double area,perimeter;
        
        private const double pi = 3.14;

        public Circle(int r)
        {
            this.r = r;
        }

        public override double Calarea()
        {
            area = pi * r * r;
            return area;
        }

        public override double Calperimeter()
        {
            perimeter = 2 * pi * r;
            return perimeter;
            
        }

        public override string ToString()
        {
            return $"Area of circle is ={area} & perimeter is = {perimeter}" ;

        }

       
    }
}
