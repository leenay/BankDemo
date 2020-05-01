using System.Collections.Generic;

namespace BankDemo.Models
{
    public static class GlobalCustomers
    {
        static GlobalCustomers()
        {
            Customers = new List<Customer> {
                new Customer { Id = 1, Name = "Customer1", 
                    Accounts = new List<Account>{ new Account { SortCode = "010101", AccountNumber = "00000001" } } 
                },
                new Customer { Id = 2, Name = "Customer2", 
                    Accounts = new List<Account>{ new Account { SortCode = "020202", AccountNumber = "00000002" },
                                                  new Account { SortCode = "030303", AccountNumber = "00000003"} 
                    } 
                }
            };
        }
        public static List<Customer> Customers { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Account> Accounts { get; set; }
    }

    public class Account
    {
        public string SortCode { get; set; }
        public string AccountNumber { get; set; }
    }

}
