using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : IEmployeeDal
    {
        public List<Employee> GetAll()
        {
            return new List<Employee> { 
                new Employee { Id = 1, FirstName = "Ferit",
                LastName = "Simsek",IdentityNumber="12345",YearOfBirth=1995,Salary=5000 },
                new Employee { Id = 2, FirstName = "Seyma",
                LastName = "Simsek",IdentityNumber="54321",YearOfBirth=1996,Salary=8000 }
            };
        }
    }
}
