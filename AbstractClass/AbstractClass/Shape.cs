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

    public abstract class Shape
    {
        public abstract double Calarea();
        public abstract double Calperimeter();
    }
}
