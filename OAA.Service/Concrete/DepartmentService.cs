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
   public class DepartmentService : IDepartmentService
    {
        private IRepository<Department> DepartmentRepository;
        private IRepository<DepartmentGroup> DepartmentGroupRepository;
        public DepartmentService(IRepository<Department> departmentRepository, IRepository<DepartmentGroup> departmentGroupRepository)
        {

            this.DepartmentRepository = departmentRepository;
            this.DepartmentGroupRepository = departmentGroupRepository;
        }
        public List<Department> GetAllDepartment()
        {
            return DepartmentRepository.GetQueryable().Include(b => b.DepartmentGroup).ToList();
        }
        public List<Department> GetDepartment()
        {
            return DepartmentRepository.GetAll().ToList();
        }
        public void AddDepartment(Department Department)
        {
            DepartmentRepository.Insert(Department);
        }
        public Department GetDepartment(long id)
        {
            return DepartmentRepository.Get(id);
        }
        public void UpdateDepartment(Department Department)
        {
            DepartmentRepository.Update(Department);
        }

        public List<DepartmentGroup> GetAllDepartmentGroup()
        {
            return DepartmentGroupRepository.GetQueryable().ToList();
        }
        public List<DepartmentGroup> GetDepartmentGroup()
        {
            return DepartmentGroupRepository.GetAll().ToList();
        }
        public void AddDepartmentGroup(DepartmentGroup DepartmentGroup)
        {
            DepartmentGroupRepository.Insert(DepartmentGroup);
        }
        public DepartmentGroup GetDepartmentGroup(long id)
        {
            return DepartmentGroupRepository.Get(id);
        }
        public void UpdateDepartmentGroup(DepartmentGroup DepartmentGroup)
        {
            DepartmentGroupRepository.Update(DepartmentGroup);
        }

    }
}
