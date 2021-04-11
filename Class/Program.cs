using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Complex metod1 = new Complex();
            //metod1.equ(5,0);

            //Ex12 ex = new Ex12(5);
            //ex.Square();
            //ex.Length();
            //ex.Exemination(-1,2);
            //Point salary = new Point(1000,6,7);
            //salary.PrintNominalSalary();
            //salary.PrintRealSalary();
            Ex7 account = new Ex7("vadim", 12, 10);
            account.Change("Oleg");
            account.Remove(5);
            account.Invest(23);
            account.AddRate();
            account.Change("Maria");
            account.Convert();
            account.Invest(23);

        }
        
    }
}
