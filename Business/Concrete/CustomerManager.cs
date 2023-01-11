using Business.Abstract;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        ICustomerDal _customerDal;
        IPersonService _personService;
        ICustomerService _customerService;
        public CustomerManager(ICustomerDal customerDal, IPersonService personService, ICustomerService customerService)
        {
            _customerDal = customerDal;
            _personService = personService;
            _customerService = customerService;

        }
        public void Add(Customer customer)
        {
            Utility.Validate(new CustomerValidator(), customer);
            CheckPersonExists(customer);
            CheckCustomerExists(customer);
            _customerDal.Add(customer);
        }

        public void AddByOtherBusiness(Customer customer)
        {
            ValidateFirstNameIfEmpty(customer);
            ValidateLastNameIfEmpty(customer);
            ValidateIdentityNumberIfEmpty(customer);
            ValidateFirstNameLenght(customer);
            _customerDal.Add(customer);
            CheckCustomerExists(customer);
        }
        /// <summary>
        /// Kişi bilgilerinin doğruluğunu kontrol ediyoruz
        /// </summary>
        /// <param name="person">Kişi bilgisi</param>
        /// <exception cref="Exception"></exception>
        private void CheckPersonExists(Person person)
        {
            if (!_personService.CheckPerson(person))
            {
                throw new Exception("Kişi bilgileri hatalı");
            }
        }
        private void CheckCustomerExists(Customer customer)
        {

            if (_customerDal.CustomerExists(customer))
            {
                throw new Exception("Müşteri zaten mevcut");
            }
        }

        private void ValidateFirstNameIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.FirstName))

            {
                throw new Exception("Validasyon hatası oldu!");
            }
        }
        private void ValidateLastNameIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.LastName))

            {
                throw new Exception("Validasyon hatası oldu!");
            }
        }
        private void ValidateIdentityNumberIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.IdentityNumber))

            {
                throw new Exception("Validasyon hatası oldu!");
            }
        }
        private void ValidateFirstNameLenght(Customer customer)
        {
            if (customer.FirstName.Length < 2)

            {
                throw new Exception("Validasyon hatası oldu!");
            }
        }

    }

}
