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
       
       public CompanyBUKTax() { }
       
       public int TaxRate
       { get; set; }

       public int Pay
       { get; set; }

       public int CalculateTax()
       {
           return Pay - TaxRate;
       }
    }
}
