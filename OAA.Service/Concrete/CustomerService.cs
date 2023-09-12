using Microsoft.EntityFrameworkCore;
using SC.Data;
using SC.Repository;
using SC.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SC.Service.Concrete
{
   public class CustomerService : ICustomerService
    {
        private IRepository<Customer> CustomerRepository;
        private IRepository<customercategory> CustomercategoryRepository;
        private IRepository<CustomerContact> CustomerContactRepository;
        private IRepository<customergroup> CustomergroupRepository;        
        private IRepository<CustomerUserAssign> CustomerUserAssignRepository;

        public CustomerService(IRepository<Customer> customerRepository, IRepository<CustomerContact> customerContactRepository, IRepository<customercategory> customercategoryRepository
            , IRepository<customergroup> customergroupRepository, IRepository<CustomerUserAssign> _CustomerUserAssignRepository)
        {

            this.CustomerRepository = customerRepository;
            this.CustomerContactRepository = customerContactRepository;
            this.CustomercategoryRepository = customercategoryRepository;
            this.CustomergroupRepository = customergroupRepository;
            this.CustomerUserAssignRepository = _CustomerUserAssignRepository;
        }
        public List<Customer> GetAllCustomer()
        {
            return CustomerRepository.GetQueryable().Include(b => b.City).Include(c=>c.customercategory).Include(b=>b.customergroup).ToList();
        }
        public List<Customer> GetCustomer()
        {
            return CustomerRepository.GetAll().ToList();
        }
        public void AddCustomer(Customer Customer)
        {
            CustomerRepository.Insert(Customer);
        }
        public Customer GetCustomer(long id)
        {
            return CustomerRepository.Get(id);
        }
        public void UpdateCustomer(Customer Customer)
        {
            CustomerRepository.Update(Customer);
        }


        public List<CustomerContact> GetAllCustomerContact()
        {
            return CustomerContactRepository.GetQueryable().ToList();
        }
        public List<CustomerContact> GetCustomerContact()
        {
            return CustomerContactRepository.GetAll().ToList();
        }
        public void AddCustomerContact(CustomerContact CustomerContact)
        {
            CustomerContactRepository.Insert(CustomerContact);
        }
        public CustomerContact GetCustomerContact(long id)
        {
            return CustomerContactRepository.Get(id);
        }
        public void UpdateCustomerContact(CustomerContact CustomerContact)
        {
            CustomerContactRepository.Update(CustomerContact);
        }

        public List<customercategory> GetAllCustomerCategory()
        {
            return CustomercategoryRepository.GetQueryable().ToList();
        }
        public List<customercategory> GetCustomerCategory()
        {
            return CustomercategoryRepository.GetAll().ToList();
        }
        public void AddCustomerCategory(customercategory customercategory)
        {
            CustomercategoryRepository.Insert(customercategory);
        }
        public customercategory GetCustomerCategory(long id)
        {
            return CustomercategoryRepository.Get(id);
        }
        public void UpdateCustomerCategory(customercategory customercategory)
        {
            CustomercategoryRepository.Update(customercategory);
        }


        public List<customergroup> GetAllCustomergroup()
        {
            return CustomergroupRepository.GetQueryable().ToList();
        }
        public List<customergroup> GetCustomergroup()
        {
            return CustomergroupRepository.GetAll().ToList();
        }
        public void AddCustomergroup(customergroup customergroup)
        {
            CustomergroupRepository.Insert(customergroup);
        }
        public customergroup GetCustomergroup(long id)
        {
            return CustomergroupRepository.Get(id);
        }
        public void UpdateCustomergroup(customergroup customergroup)
        {
            CustomergroupRepository.Update(customergroup);
        }

        public void DeleteCustomerContact(long Id)
        {
            try
            {
                var items = CustomerContactRepository.GetAll().Where(x => x.CustomerId == Id).ToList();
                foreach (var item in items)
                {
                    CustomerContactRepository.Delete(item);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<CustomerUserAssign> GetAllCustomerUserAssign()
        {
            return CustomerUserAssignRepository.GetAll().Include(x=>x.Customer).Include(x=>x.AssignedUser).ToList();
            
        }

        public void AddCustomerUserAssign(CustomerUserAssign CustomerUserAssign)
        {
            CustomerUserAssignRepository.Insert(CustomerUserAssign);
        }

        public CustomerUserAssign GetCustomerUserAssign(long id)
        {
            return CustomerUserAssignRepository.Get(id);
        }

        public void UpdateCustomerUserAssign(CustomerUserAssign CustomerUserAssign)
        {
            CustomerUserAssignRepository.Update(CustomerUserAssign);
        }
    }
}
