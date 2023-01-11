using Business.DependencyResolvers.Ninject;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities
{
    public class NinjectInstanceFactory
    {
        public static T GetInstance<T>()
        {
            IKernel kernel = new StandardKernel(new BuisnessModule());
            return kernel.Get<T>();
        }
    }
}
