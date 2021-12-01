using System;
using System.Collections.Generic;
using System.Text;

namespace responsabilityApp
{
    internal class Purchase
    {
        public int _number { get; set; }
        public double _amount { get; set; }
        public string _purpose { get; set; }
        public Purchase(int number, double amount, string purpose)
        {
            this._number = number;
            this._amount = amount;
            this._purpose = purpose;
        }

    }
}
