using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 23, FirstName = "Gülce", LastName = "Yılmaz", City = "Izmir" };
            Customer customer2 = new Customer(21, "Salih", "Özgün", "Ankara");
        }
        
    }
    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
