using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloadingmethod
{
    //1. WAP to overload add method

    public class Calculator
    {
        //Method for Addition
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Add(int x, int y,int z)
        {
            return x + y + z;
        }

        public double Add(double x, int y)
        {
            return x + y;
        }

        public double Add(int x, double y)
        {
            return x + y;
        }

        //Method for substraction
        public int Subtract(int x, int y)
        {
            return x - y; 
        }
        public int Subtract(int x, int y,int z)
        {
            return x - y - z;
        }

        public double Subtract(double x, int y)
        {
            return x - y;
        }

        public double Subtract(int x, double y)
        {
            return x - y;
        }

        //Method for Multilpication
        public int Sultiply(int x, int y)
        {
            return x * y;
        }
        public int Multiply(int x, int y,int z)
        {
            return x * y * z;
        }
        public double Multiply(double x, int y)
        {
            return x * y;
        }
        public double Multiply(int x, double y)
        {
            return x * y;
        }

        //Method for divition
        public int Divide(int x, int y)
        {
            return x / y;
        }
        public double Divide(int x, double y)
        {
            return x / y;
        }

    }

}
