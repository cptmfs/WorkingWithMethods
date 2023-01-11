using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.NHibernate
{
    public class NhCustomerDal:ICustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Nhibernate kullanarak veritabanına Eklendi");
        }

        public bool CustomerExists(Customer customer)
        {
            return true;
        }
    }
}
