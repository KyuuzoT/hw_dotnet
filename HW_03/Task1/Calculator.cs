using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Calculator
    {
        public double Addition(double firstVar, double secondVar)
        {
            return firstVar+secondVar;
        }
        public double Subtraction(double firstVar, double secondVar)
        {
            return firstVar-secondVar;
        }
        public double Multiplication(double firstVar, double secondVar)
        {
            return firstVar*secondVar;
        }
        public double Division(double firstVar, double secondVar)
        {
            return firstVar/secondVar;
        }
        public double ModuleDivision(double firstVar, double secondVar)
        {
            return firstVar%secondVar;
        }
        public double AreaOfCircle(double radius)
        {
            return Math.PI*radius*radius;
        }
    }
}
