using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface IDesignationService
    {
        List<Designation> GetAllDesignation();
        void AddDesignation(Designation Designation);
        Designation GetDesignation(long id);
        void UpdateDesignation(Designation Designation);
        List<Designation> GetDesignation();


        List<DesignationGroup> GetAllDesignationGroup();
        void AddDesignationGroup(DesignationGroup DesignationGroup);
        DesignationGroup GetDesignationGroup(long id);
        void UpdateDesignationGroup(DesignationGroup DesignationGroup);
        List<DesignationGroup> GetDesignationGroup();
    }
}
