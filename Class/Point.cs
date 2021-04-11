using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Point
    {
        public string name="Vadim Gnatyuk Olegovich";
        public decimal rate;
        private int year=2018;
        private decimal premium = 10;
        private decimal tax = 22;
        public int count;
        public int countWorkDays;

        public decimal Rate
        {
            get { 
                return rate; 
                }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Salary must be >0");
                }
                else
                {
                    rate = value;
                }
            }

        }
        
        public int CountWorkDays
        {
            get { return countWorkDays; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Кількість днів не може набувати від'ємного значення");
                }
                else if(value>=0)
                {
                    countWorkDays = value;
                }
            }
        }
        public int Count
        {
            get { return count; }
            set
            {
                if (value <= CountWorkDays)
                {

                    count = value;
                }
                else if (value > countWorkDays)
                {
                    count = value;
                    Console.WriteLine("Exception");
                    throw new Exception("кількість відпрацьованих днів не може бути більшою за кількість робочих днів");
                }
              
            }
        }

        public Point(decimal rate,int count,int countWorkDays)
        {
            Rate = rate;
            CountWorkDays = countWorkDays;
            Count = count;
            Console.WriteLine($"{Count}    {CountWorkDays}  {Rate}");

        }
        decimal result;
        
        
        public void PrintNominalSalary()
        {
            result = Rate + (Rate * (premium / 100));
            Console.WriteLine(result);
        }
        public void PrintRealSalary()
        {
            result= Rate + (Rate * (premium / 100));
            result = result - (result * (tax / 100));
            Console.WriteLine(result);
        }




    }
}
