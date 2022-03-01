using System;

namespace 委托题1
{
    class Program
    {
        public delegate double MyDelegate(double a);

        public class D
        {
            private int d;
            D(int d_1)
            {
                this.d = d_1;
            }
            public static double Sqrt(int a)
            {
                int b=5;
                int num_1 = (int)Math.Sqrt(b);
                return num_1;
            }
            public double Multi()
            {
                double a=3;
                double num_2=4;
                double num_3 = Math.Pow(d,a);
                return num_2;
            }
        };

        static void Main(string[] args)
        {
            D d1;
            MyDelegate m1;
            MyDelegate m2;
/*            Console.WriteLine("Hello World!");*/
        }
    }
}
