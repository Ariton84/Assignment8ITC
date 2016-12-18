using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC110Assignment8
{
    public class Bill
    {
        double tax = .09;
        public Bill()
        {
            Amount = 0;
            TipPercent = 0;
        }
        public Bill(double amount, double tipPercent)
        {
            Amount = amount;
            TipPercent = tipPercent;
        }
        public double Amount { get; set; }
        public double TipPercent { get; set; }

        public double Tax()
        {
            double Tax = tax * Amount;
            return Tax; 
        }
        public double CalcTip()
        {
            double calctip = Amount * TipPercent;
            return calctip;
        }
        public double CalcTotal()
        {
            double calcTotal = (Amount * TipPercent) + (Amount * .09) + Amount;
            return calcTotal;
        }
        
       
    }
}
