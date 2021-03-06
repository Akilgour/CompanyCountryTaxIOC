﻿using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class FranceTax : ICalculateTax
    {

       public FranceTax(int Pay)
       {
           this.Pay = Pay;
           TaxRate = 50;
       }

       public FranceTax() : this(0) { }


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
