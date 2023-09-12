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
  public  class EmployeeService : IEmployeeService
    {
        private IRepository<Employee> EmployeeRepository;
        private IRepository<EmployeeCategory> EmployeeCategoryRepository;
        private IRepository<EmployeeGroup> EmployeeGroupRepository;
        public EmployeeService(IRepository<Employee> employeeRepository, IRepository<EmployeeCategory> employeeCategoryRepository, IRepository<EmployeeGroup> employeeGroupRepository)
        {
            this.EmployeeRepository = employeeRepository;
            this.EmployeeCategoryRepository = employeeCategoryRepository;
            this.EmployeeGroupRepository = employeeGroupRepository;
        }

        public List<Employee> GetAllEmployee()
        {
            return EmployeeRepository.GetQueryable().Include(b => b.EmployeeCategory).Include(c=>c.EmployeeGroup).Include(d=>d.Department).Include(e=>e.Designation).ToList();
        }
        public List<Employee> GetDEmployee()
        {
            return EmployeeRepository.GetAll().ToList();
        }
        public void AddEmployee(Employee Employee)
        {
            EmployeeRepository.Insert(Employee);
        }
        public Employee GetEmployee(long id)
        {
            return EmployeeRepository.Get(id);
        }
        public void UpdateEmployee(Employee Employee)
        {
            EmployeeRepository.Update(Employee);
        }



        public List<EmployeeCategory> GetAllEmployeeCategory()
        {
            return EmployeeCategoryRepository.GetQueryable().ToList();
        }
        public List<EmployeeCategory> GetEmployeeCategory()
        {
            return EmployeeCategoryRepository.GetAll().ToList();
        }
        public void AddEmployeeCategory(EmployeeCategory EmployeeCategory)
        {
            EmployeeCategoryRepository.Insert(EmployeeCategory);
        }
        public EmployeeCategory GetEmployeeCategory(long id)
        {
            return EmployeeCategoryRepository.Get(id);
        }
        public void UpdateEmployeeCategory(EmployeeCategory EmployeeCategory)
        {
            EmployeeCategoryRepository.Update(EmployeeCategory);
        }



        public List<EmployeeGroup> GetAllEmployeeGroup()
        {
            return EmployeeGroupRepository.GetQueryable().ToList();
        }
        public List<EmployeeGroup> GetEmployeeGroup()
        {
            return EmployeeGroupRepository.GetAll().ToList();
        }
        public void AddEmployeeGroup(EmployeeGroup EmployeeGroup)
        {
            EmployeeGroupRepository.Insert(EmployeeGroup);
        }
        public EmployeeGroup GetEmployeeGroup(long id)
        {
            return EmployeeGroupRepository.Get(id);
        }
        public void UpdateEmployeeGroup(EmployeeGroup EmployeeGroup)
        {
            EmployeeGroupRepository.Update(EmployeeGroup);
        }
    }
}
