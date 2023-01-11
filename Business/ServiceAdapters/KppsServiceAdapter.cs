using Business.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ServiceAdapters
{
    //Bu koda dokunamıyoruz
    public class KpsService
    {
        public bool CheckPerson(long tcNo, string adi, string soyadi, int yil)
        {
            return true;
        }
    }
    public class KpsServiceAdapter : IPersonService
    {
        public bool CheckPerson(Person person)
        {
            KpsService kpsService = new KpsService();
            return kpsService.CheckPerson(Convert.ToInt64(person.IdentityNumber), person.FirstName, person.LastName, person.YearOfBirth);
        }
    }
}
