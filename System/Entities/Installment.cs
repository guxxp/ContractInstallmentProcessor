using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Entities
{
    internal class Installment /// Parcelas
    {

        private DateTime DueDate; /// data vencimento
        private double Value; // valor



        public Installment(DateTime duedate, double value)
        {
            DueDate = duedate;
            Value = value;
        }

        public DateTime duedate
        {
            get { return DueDate; }
            set { duedate = value; }
        }
        public double valuer
        {
            get { return Value; }
            set { valuer = value; }
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Value.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
