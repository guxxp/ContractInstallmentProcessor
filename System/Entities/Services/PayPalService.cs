using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Entities.Services
{
    internal class PayPaalService : IServicePagmentOnline
    {
        public double paymentFee(double amount)
        {
            return amount * 0.02;

        }
        public double interest (double amount, int month)
        {
            return (amount * 0.01) * month;

        }

    }
}
