using System;

namespace Task1
{
    class Program
    {
        const int iConst = 43;
        static void Main(string[] args)
        {
            //The worst way to name variable, but whatever
            double d1 = 5.1;
            float f1 = 17.33f;
            int i1 = 222;
            int i2 = 280;
            Console.WriteLine($"double1 = {d1};\nfloat1 = {f1};\nint1 = {i1};\nint2 = {i2};\n" +
                $"const int = {iConst};\n\n");


            long l1;
            long l2;
            int i3;
            byte b1;
            byte b2;

            Console.WriteLine("Explicit cast");
            //----------------------------explicit cast------------------------------
            l1 = (long)d1;              //explicit
            l2 = (int)f1 + (int)d1;     //explicit
            i3 = (int)(f1 * d1);        //explicit
            b1 = (byte)i1;              //explicit
            b2 = (byte)i2;              //explicit

            Console.WriteLine($"long1 = double1; long1 = {l1}\n" +
                $"long2 = float1 + double1; long2 = {l2}\n" +
                $"int3 = float1 * double1; int3 = {i3}\n" +
                $"byte1 = int1; byte1 = {b1}\n" +
                $"byte2 = int2; byte2 = {b2}\n\n");
            //----------------------------explicit cast------------------------------

            Console.WriteLine("Implicit cast");
            //----------------------------implicit cast------------------------------
            l1 = i1;                    //implicit 
            d1 = f1;                    //implicit
            b1 = iConst;                //implicit
            var a = iConst * f1;        //just for fun
            Console.WriteLine($"long1 = int1; long1 = {l1}\n" +
                $"double1 = float1; double1 = {d1} SIC!!!\n" +
                $"byte1 = const int; byte1 = {b1}\n" +
                $"var a = const int * float1; a = {a}\n\n");
            //----------------------------implicit cast------------------------------

            Console.WriteLine("Boxing & Unboxing");
            //----------------------------boxing&unboxing------------------------------
            object o1 = i3;             //boxing
            int j = (int)o1;            //unboxing

            Console.WriteLine($"object1 = int3; object1 = {o1}\n" +
                $"int = unbox object; int = {j}\n");
            //----------------------------boxing&unboxing------------------------------



            Console.ReadKey();
        }
    }
}
