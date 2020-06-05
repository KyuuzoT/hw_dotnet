using System;

namespace Task2
{
    class Calculator
    {
        public static double Addition(double firstVar, double secondVar)
        {
            return firstVar + secondVar;
        }
        public static double Subtraction(double firstVar, double secondVar)
        {
            return firstVar - secondVar;
        }
        public static double Multiplication(double firstVar, double secondVar)
        {
            return firstVar * secondVar;
        }
        public static double Division(double firstVar, double secondVar)
        {
            return firstVar / secondVar;
        }
        public static double ModuleDivision(double firstVar, double secondVar)
        {
            return firstVar % secondVar;
        }
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
