using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Entities.Services;
using System.Entities;




namespace System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" Enter contract data");

            Console.Write(" Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write(" Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write(" Contract value: ");
            double value = double.Parse(Console.ReadLine());



            Console.Write(" Enter number of installments: ");
            int Month = int.Parse(Console.ReadLine());


            Contract mycontract = new Contract(number, date, value);

            ServiceContract serviceContract = new ServiceContract(new PayPaalService());

            serviceContract.processContract(mycontract, Month);

            Console.WriteLine("Installments:");
            Console.WriteLine(mycontract);


            Console.ReadLine();
        }
    }
}
