using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Ex7
    {
        public string name;
        public int numberOfAcc=1;
        public decimal rate=10;
        public decimal summ=2;

        public string Name { get {return  name; } set { name = value; } }
        public int NumberOfAcc { get { return numberOfAcc; }set { numberOfAcc = value; } }
        public decimal Summ { get { return summ; } set { summ = value; } }


        public Ex7(string name,int num,decimal sum)
        {
            Name = name;
            NumberOfAcc = num;
            Summ = sum;
            Console.WriteLine($"Власник рахунку-{Name} номер рахунку-{NumberOfAcc}  баланс-{Summ}");
        }
        public void Change(string newOwn)
        {
            Name = newOwn;
            Console.WriteLine($"Новий власник рахунку-{Name} номер рахунку-{NumberOfAcc}  баланс-{Summ}");
        }
        public void Remove(decimal count)
        {
            Summ -= count;
            Console.WriteLine($"Власник рахунку-{Name} номер рахунку-{NumberOfAcc}  баланс-{Summ}");
        }
        public void Invest(decimal inv) {
            Summ += inv;
            Console.WriteLine($"Власник рахунку-{Name} номер рахунку-{NumberOfAcc}  баланс-{Summ}");
        }
        public void AddRate()
        {
            Summ += Summ * (rate / 100);
            Console.WriteLine($"Власник рахунку-{Name} номер рахунку-{NumberOfAcc}  баланс-{Summ}");
        }
        public void Convert()
        {
            decimal newSumm = Summ / 33;

            Console.WriteLine($"Власник рахунку-{Name} номер рахунку-{NumberOfAcc}  баланс в євро-{newSumm}");
        }
    }
}
