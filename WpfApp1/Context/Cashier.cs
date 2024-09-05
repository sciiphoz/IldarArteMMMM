using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Context
{
    public class Cashier
    {
        public Cashier(string name, string date, int revenue, double fees) 
        {
            Name = name;
            Date = date;
            Revenue = revenue;
            Fees = fees;
        }

        public string Name { get; set; }
        public string Date { get; set; }
        public int Revenue { get; set; }
        public double Fees { get; set; }
    }
}
