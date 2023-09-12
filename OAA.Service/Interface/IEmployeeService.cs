using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployee();
        List<Employee> GetDEmployee();
        void AddEmployee(Employee Employee);
        Employee GetEmployee(long id);
        void UpdateEmployee(Employee Employee);

        List<EmployeeCategory> GetAllEmployeeCategory();
        List<EmployeeCategory> GetEmployeeCategory();
        void AddEmployeeCategory(EmployeeCategory EmployeeCategory);
        EmployeeCategory GetEmployeeCategory(long id);
        void UpdateEmployeeCategory(EmployeeCategory EmployeeCategory);

        List<EmployeeGroup> GetAllEmployeeGroup();
        List<EmployeeGroup> GetEmployeeGroup();
        void AddEmployeeGroup(EmployeeGroup EmployeeGroup);
        EmployeeGroup GetEmployeeGroup(long id);
        void UpdateEmployeeGroup(EmployeeGroup EmployeeGroup);
    }
}
