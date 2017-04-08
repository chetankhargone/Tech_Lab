using Angular_app.DTO;
using Angular_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular_app.DAL
{
    public class CustomerHandler : BaseHandler
    {
        //add
        public bool AddCustomer(CustomerTO customer)
        {
            using (CustomerContext entites = new CustomerContext())
            {
                try
                {
                    var customerEntity = _mapper.Map(customer);
                    entites.Customers.Add(customerEntity);
                    entites.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                
            }
        }
        //get
        public IEnumerable<CustomerTO> GetCustomers()
        {
            using (CustomerContext entities = new CustomerContext())
            {
                var query = (from c in entities.Customers
                                              orderby c.CustId
                                              select c).ToList<Customer>();

                var customers = _mapper.Map(query);
                return customers;



            }

        }

        public CustomerTO GetCustomer(int id)
        {
            throw new NotImplementedException();
        }
        //update
        //delete
    }
}