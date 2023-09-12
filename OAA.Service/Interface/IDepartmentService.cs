using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface IDepartmentService
    {
        List<Department> GetAllDepartment();
        void AddDepartment(Department Department);
        Department GetDepartment(long id);
        void UpdateDepartment(Department Department);
        List<Department> GetDepartment();


        List<DepartmentGroup> GetAllDepartmentGroup();
        void AddDepartmentGroup(DepartmentGroup DepartmentGroup);
        DepartmentGroup GetDepartmentGroup(long id);
        void UpdateDepartmentGroup(DepartmentGroup DepartmentGroup);
        List<DepartmentGroup> GetDepartmentGroup();
    }
}
