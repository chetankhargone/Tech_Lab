namespace Customer.DAL.Services
{
    using Contracts.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DTO.Customer;

    public class CustomerService : ICustomerService
    {
        public int AddCustomer(CustomerTO customer)
        {
            throw new NotImplementedException();
        }

        public bool DeletCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public CustomerTO GetCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerTO> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(CustomerTO customer)
        {
            throw new NotImplementedException();
        }
    }
}
