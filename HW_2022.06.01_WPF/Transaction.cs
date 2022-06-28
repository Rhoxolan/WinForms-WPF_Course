using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2022._06._01_WPF
{
    public class Transaction
    {
        public string Name { get; set; }
        public double Sum { get; set; }

        public Transaction(string name, double sum)
        {
            Name = name;
            Sum = sum;
        }

        public bool IsNegative
        {
            get
            {
                return Sum < 0;
            }
        }
    }
}