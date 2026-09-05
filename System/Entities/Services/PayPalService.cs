using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Entities.Services
{
    internal class PayPaalService : IServicePagmentOnline
    {
        public double paymentFee(double amount) // taxa 
        {
            return (amount * 0.01) + 1;

        }
        public double interest (double amount, int month) // juros
        {
            return (amount + 1) * month;

        }

    }
}
