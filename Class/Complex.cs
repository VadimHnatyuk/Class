using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Complex
    {
        public double a;
        public double b;

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public Complex()
        {
            a=5 ; 
            b=0 ; 
        }
        public Complex(double aInt) 
        {
            a = aInt;
            b = 0;
            
        }
        public Complex(double aInt,double bInt)
        {
            a = aInt;
            b = bInt;
        }

        double first;
        double second;
        public void add(double c, double d)
        {
            first= a + b;
            second = c + d;
            Console.WriteLine($"(a,b)+(c,d)={first}, {second}");
        }
        public void sub(double c, double d)
        {
            first = a - b;
            second = c - d;
            Console.WriteLine($"(a,b)-(c,d)={first}, {second}");
        }
        public void mn(double c,double d)
        {
            first = (a*c) - (b*d);
            second = (a * d) - (b * c);
            Console.WriteLine($"(a,b)*(c,d)={first}, {second}");
        }
        public void div(double c,double d)
        {
            first = ((a * c) + (b * d))/(c*c+d*d);
            second = ((b * c) - (a * d)) / (c*c + d*d);
            Console.WriteLine($"(a,b)/(c,d)={first}, {second}");
        }
        public void equ(double c,double d)
        {
            if (a == c)
            {
                Console.WriteLine("a=c");
            }
            else
            {
                Console.WriteLine("a!=c");
            }

            if (b == d)
            {
                Console.WriteLine("b=d");
            }
            else
            {
                Console.WriteLine("b!=d");
            }
            Console.WriteLine($"a={a}  b={b} c={c} d={d}");
        }
    }
   
}
