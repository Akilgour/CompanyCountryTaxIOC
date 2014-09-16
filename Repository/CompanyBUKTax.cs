using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class CompanyBUKTax : ICalculateTax
    {
       private int p;

       public CompanyBUKTax(int Pay)
       {
           this.Pay = Pay;
           TaxRate = 10;
       }
       public int TaxRate
       { get; private set; }

       public int Pay
       { get; private set; }

       public int CalculateTax()
       {
           return Pay - TaxRate;
       }
    }
}
