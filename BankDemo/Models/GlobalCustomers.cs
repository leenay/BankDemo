using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankDemo.Models
{
    public static class GlobalCustomers
    {
        static GlobalCustomers()
        {
            Customers = new List<Customer> {
                new Customer { Id = 1, Name = "Customer1" },
                new Customer { Id = 2, Name = "Customer2" }
            };
        }
        public static List<Customer> Customers { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
