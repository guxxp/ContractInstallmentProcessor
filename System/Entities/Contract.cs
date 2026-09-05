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

        public List<Installment> Installment = new List<Installment>();

        public Contract(int number, DateTime date, double value)
        {
            Number = number;
            Date = date;
            Value = value;
        }
        public int number
        {
            get { return Number; }
            set { value = number; }

        }
        public DateTime date
        {
            get { return Date; }
            set { value = date; }

        }
        public double valuer
        {
            get { return Value; }
            set {  value = valuer; }

        }
    }
}
