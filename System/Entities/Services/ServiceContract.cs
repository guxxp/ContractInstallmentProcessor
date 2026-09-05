using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Entities.Services
{
    internal class ServiceContract
    {
        private IServicePagmentOnline _onlinePaymentService;

        public ServiceContract(IServicePagmentOnline onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }


        public void processContract(Contract contract, int Month)
        {
            double installment_value = contract.totalvalue / Month; /// valor das parcelas 

            for (int i = 1; i <= Month; i++) 
            {
                DateTime duedate = contract.date.AddMonths(i);

                double valueinterest = installment_value +  _onlinePaymentService.interest(installment_value, i);
                double valuetax = valueinterest + _onlinePaymentService.paymentFee(valueinterest);
               
                

                Installment installment = new Installment(duedate, valuetax);

                contract.Installment.Add(installment);
            }

        }
    }
}
