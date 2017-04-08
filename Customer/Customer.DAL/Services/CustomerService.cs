namespace ECommerce.DAL.Services
{
    using Contracts.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DTO.Customer;
    using Mapper;
    using EF.Repository;
    public class CustomerService : ICustomerService
    {
        private readonly CustomerRepository _custRepository;
        private AppMapper _appMapper;
        public CustomerService(CustomerRepository custRepository,AppMapper mapper)
        {
            _custRepository = custRepository;
            _appMapper = mapper;
        }
        public bool AddCustomer(CustomerTO customer)
        {
            try
            {
                var custEntity = _appMapper.Map(customer);
                _custRepository.Add(custEntity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeletCustomer(int customerId)
        {
            try
            {
                var entity =_custRepository.GetQuery().Where(x => x.Id == customerId).FirstOrDefault();
                _custRepository.Delete(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public CustomerTO GetCustomer(int customerId)
        {
            try
            {
                var entity = _custRepository.GetQuery().Where(x => x.Id == customerId).FirstOrDefault();
                var customer = _appMapper.Map(entity);
                return customer;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<CustomerTO> GetCustomers()
        {
            var entitiy = _custRepository.GetAll();
            var customers = _appMapper.Map(entitiy);
            return customers;
        }

        public bool UpdateCustomer(CustomerTO customer)
        {
            try
            {
                var entitiy = _appMapper.Map(customer);
                _custRepository.Update(entitiy);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
