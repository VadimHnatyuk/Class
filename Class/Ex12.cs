using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Ex12
    {
        public int radius;
        public int x = 1;
        public int y = 1;
        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Write correctly value");
                }
                else
                {
                    radius = value;
                }
            }
        }
        public Ex12(int radius)
        {
            Radius = radius;
            Console.WriteLine("Уявімо що центр кола знаходить в центрі системи координат");
        }
        public void Square()
        {
            double square = Math.PI * (Radius *Radius);
            Console.WriteLine($"The square is = {square}");
        }
        public void Length()
        {
            double length = 2 * Math.PI * Radius;
            Console.WriteLine($"The length is = {length}");
        }
        public void Exemination(int x,int y)
        {

            x = Convert.ToInt32(Math.Pow(x,2));
            y = Convert.ToInt32(Math.Pow(y, 2));
            double diagonal = Math.Sqrt(x+y);
            if (diagonal < Radius)
            {
                Console.WriteLine($"Точка знаходиться в межах кола");
            }
            else
            {
                Console.WriteLine($"Точка знаходиться поза межами кола");
            }
           
            
        }
    }
}

