using Business;
using Business.Abstract;
using Business.Concrete;
using Business.ServiceAdapters;
using Business.Utilities;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
     class Program
    {
        static void Main(string[] args)
        {
            //CustomerDemo();
            //EmployeeDemo();
            IProductService productService = NinjectInstanceFactory.GetInstance<IProductService>();
            var result = productService.GetAll();

            foreach (var product in result)
            {
                Console.WriteLine(product.Name);

            }
            Console.ReadLine();
        }

        private static void EmployeeDemo()
        {
            IEmployeeService employeeService = NinjectInstanceFactory.GetInstance<IEmployeeService>();
            var result = employeeService.GetAll();

            foreach (var employee in result)
            {
                Console.WriteLine(employee.FirstName);

            }
        }

        private static void CustomerDemo()
        {
            ICustomerService customerService = NinjectInstanceFactory.GetInstance<ICustomerService>();
            customerService.Add(new Customer());
        }
    }
}
