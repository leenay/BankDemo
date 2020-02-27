﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankDemo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/Customer
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetCustomers()
        {
            return GlobalCustomers.Customers;
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Customer> GetCustomer(int id)
        {
            var customer = GlobalCustomers.Customers.Find(x => x.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        // POST: api/Customer
        [HttpPost]
        public ActionResult<Customer> PostCustomer(Customer customer)
        {
            GlobalCustomers.Customers.Add(customer);
            return CreatedAtAction("Get", new { id = customer.Id }, customer);
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public ActionResult PutCustomer(int id, [FromBody] Customer customer)
        {
            if (id != customer.Id)
            {
                return BadRequest();
            }

            var customerToUpdate = GlobalCustomers.Customers.Find(x => x.Id == id);
            if (customerToUpdate == null)
            {
                GlobalCustomers.Customers.Add(customer);
                return CreatedAtAction("Get", new { id = customer.Id }, customer);
            }
            else
            {
                customerToUpdate.Name = customer.Name;
                return Ok();
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<Customer> DeleteCustomer(int id)
        {
            var customer = GlobalCustomers.Customers.Find(x => x.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            GlobalCustomers.Customers.Remove(customer);

            return NoContent();
        }
    }
}
