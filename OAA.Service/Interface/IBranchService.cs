using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface IBranchService
    {
        List<Branch> GetAllBranch();
        void AddBranch(Branch Branch);
        Branch GetBranch(long id);
        void UpdateBranch(Branch Branch);
        List<Branch> GetBranch();


        List<BranchGroup> GetAllBranchGroup();
        void AddBranchGroup(BranchGroup BranchGroup);
        BranchGroup GetBranchGroup(long id);
        void UpdateBranchGroup(BranchGroup BranchGroup);
        List<BranchGroup> GetBranchGroup();
    }
}
