using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    internal class CheckingAccount
    {
        private decimal _balance = 1000;
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                    _balance = value;
                else
                    Console.WriteLine("Error: Negative balance!");
            }
        }
    }
}
