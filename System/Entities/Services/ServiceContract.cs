using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Entities.Services
{
    internal class ServiceContract
    {

        public void processContract(Contract contract, int Month)
        {
            
           
            for(int i = 1; i <= Month; i++) /// Mes 1 
            {
                double amount = contract.valuer / Month;


                PayPaalService payPaalService = new PayPaalService();

                double valuetax = payPaalService.paymentFee(contract.valuer);

                double valueinterest = payPaalService.interest(contract.valuer, i);


                amount += valueinterest;



                DateTime duedate = contract.date.AddMonths(i);

                Installment installment = new Installment(duedate, amount);

                contract.Installment.Add(installment);
                
            }



        }
    }
}
