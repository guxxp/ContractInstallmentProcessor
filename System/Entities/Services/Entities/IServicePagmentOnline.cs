using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Entities.Services
{
    internal interface IServicePagmentOnline
    {
        double paymentFee(double amount);

        double interest(double amount, int month);
      
    }
}
