using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Entities
{
    internal class Contract
    {
        private int Number;
        private DateTime Date;
        private double Value;

        List<Installment> Installment = new List<Installment>();

        public Contract(int number, DateTime date, double value)
        {
            Number = number;
            Date = date;
            Value = value;
        }
        public int number
        {
            get { return Number; }
            set { number = value; }

        }
        public DateTime date
        {
            get { return Date; }
            set { date = value; }

        }
        public double valuer
        {
            get { return Value; }
            set { valuer = value; }

        }
    }
}
