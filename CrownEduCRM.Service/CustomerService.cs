using CrownEduCRM.Data;
using CrownEduCRM.Model;
using System;

namespace CrownEduCRM.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> customerRepository;
        private readonly IUnitOfWork unitOfWork;
        public CustomerService(IRepository<Customer> customerRepository, IUnitOfWork unitOfWork)
        {
            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }
        public void Delete(string id)
        {
            var customer = customerRepository.Get(id);
            if (customer != null) {
                customerRepository.Delete(customer);
                unitOfWork.SaveChanges();
            }
        }

        public Customer Get(string id)
        {
            return customerRepository.Get(id);
        }

        public void Insert(Customer entity)
        {
            customerRepository.Insert(entity);
            unitOfWork.SaveChanges();
        }

        public void Update(Customer entity)
        {
            customerRepository.Update(entity);
            unitOfWork.SaveChanges();
        }
    }

    public interface ICustomerService
    {
        Customer Get(string id);
        void Insert(Customer entity);
        void Update(Customer entity);
        void Delete(string id);
    }
}
