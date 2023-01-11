using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithMethods
{
    internal class Program
    {



        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new NhCustomerDal(),new KpsServiceAdapter());

            customerManager.Add(new Customer
            {
                FirstName = "Ferit",
                LastName = "Simsek",
                IdentityNumber = "222"
            });
            //FirstName min iki karakter
            customerManager.AddByOtherBusiness(new Customer
            {
                FirstName = "S",
                LastName = "Simsek",
                IdentityNumber = "222"
            });
        }
    }


    


    
   
    
   

    
}
