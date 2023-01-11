using Business.Abstract;
using Business.Concrete;
using Business.ServiceAdapters;
using DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.NHibernate;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Ninject
{
    public class BuisnessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerDal>().To<NhCustomerDal>();
            Bind<ICustomerService>().To<CustomerManager>();
            Bind<IEmployeeDal>().To<EfEmployeeDal>();
            Bind<IEmployeeService>().To<EmployeeManager>();
            Bind<IPersonService>().To<KpsServiceAdapter>();
            Bind<IProductDal>().To<EfProductDal>();
            Bind<IProductService>().To<ProductManager>();


        }
    }
}
