using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomer();
        void AddCustomer(Customer Customer);
        Customer GetCustomer(long id);
        void UpdateCustomer(Customer Customer);
        List<Customer> GetCustomer();


        List<CustomerContact> GetAllCustomerContact();
        void AddCustomerContact(CustomerContact CustomerContact);
        CustomerContact GetCustomerContact(long id);
        void UpdateCustomerContact(CustomerContact CustomerContact);
        List<CustomerContact> GetCustomerContact();

        List<customercategory> GetAllCustomerCategory();
        void AddCustomerCategory(customercategory customercategory);
        customercategory GetCustomerCategory(long id);
        void UpdateCustomerCategory(customercategory customercategory);
        List<customercategory> GetCustomerCategory();

        List<customergroup> GetAllCustomergroup();
        void AddCustomergroup(customergroup customergroup);
        customergroup GetCustomergroup(long id);
        void UpdateCustomergroup(customergroup customergroup);
        List<customergroup> GetCustomergroup();

        void DeleteCustomerContact(long Id);


        List<CustomerUserAssign> GetAllCustomerUserAssign();
        void AddCustomerUserAssign(CustomerUserAssign CustomerUserAssign);
        CustomerUserAssign GetCustomerUserAssign(long id);
        void UpdateCustomerUserAssign(CustomerUserAssign CustomerUserAssign);
        

    }
}
