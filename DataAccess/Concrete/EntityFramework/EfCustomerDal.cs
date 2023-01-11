using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Entityframework kullanarak veritabanına Eklendi");
        }

        public bool CustomerExists(Customer customer)
        {
            return true;
        }
    }
}
