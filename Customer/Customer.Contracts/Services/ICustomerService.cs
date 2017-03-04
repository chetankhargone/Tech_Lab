namespace Customer.Contracts.Services
{
    using Customer.DTO.Customer;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICustomerService
    {
        //C -create
        int AddCustomer(CustomerTO customer);
        //R -read
        IEnumerable<CustomerTO> GetCustomers();
        CustomerTO GetCustomer(int customerId);
        //U - update
        bool UpdateCustomer(CustomerTO customer);
        //D- delete
        bool DeletCustomer(int customerId);

    }
}
