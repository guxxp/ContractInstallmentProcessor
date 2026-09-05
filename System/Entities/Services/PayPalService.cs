using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Entities.Services
{
    internal class PayPaalService : IServicePagmentOnline
    {

        const double FeePorcentage = 0.02;
        const double Monthlyinterest  = 0.01;
        public double interest(double amount, int month) // juros
        {
            return amount * Monthlyinterest * month;

        }
        public double paymentFee(double amount) // taxa 
        {
            return amount * FeePorcentage;

        }
        

    }
}
