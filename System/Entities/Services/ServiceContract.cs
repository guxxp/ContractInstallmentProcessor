using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Entities.Services
{
    internal class PayPalService
    {

        public void processContract(Contract contract, int Month)
        {
            
           
            for(int i = 1; i <= Month; i++)
            {

                contract.date = contract.date.AddMonths(i);
                Console.WriteLine(contract.date);
                
            }
        }
    }
}
