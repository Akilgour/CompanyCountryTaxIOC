﻿using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UKTax : ICalculateTax
    {
        public UKTax(int Pay)
        {
            this.Pay = Pay;
            TaxRate = 40;
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