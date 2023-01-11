using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 20;
            int sayi2 = 25;
            sayi1 = sayi2;
            sayi2 = 30;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 4, 5, 6 };
            sayilar1 = sayilar2;
            sayilar2[0] = 30;
            Console.WriteLine(sayilar1[0]);

            Customer customer= new Customer { Id = 1, FirstName = "Ferit" };
            Customer customer2 = customer;

            Person person1 = customer;
            Person person2 = new Employee();

            PersonDal personDal= new PersonDal();
            personDal.Add(new Visitor());


            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNo { get; set; }
    }

    class Employee : Person
    {
        public decimal Salary { get; set; }
    }
    class Visitor : Person
    {
        public string VisitorCard { get; set; }
    }
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class PersonDal
    {
        public void Add(Person person)
        {

        }
    }

}
