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
    public class BranchService : IBranchService
    {
        private IRepository<Branch> BranchRepository;
        private IRepository<BranchGroup> BranchGroupRepository;
        public BranchService(IRepository<Branch> branchRepository, IRepository<BranchGroup> branchGroupRepository)
        {
            this.BranchRepository = branchRepository;
            this.BranchGroupRepository = branchGroupRepository;
        }
        public List<Branch> GetAllBranch()
        {
            return BranchRepository.GetQueryable().Include(b=>b.BranchGroup).ToList();
        }
        public List<Branch> GetBranch()
        {
            return BranchRepository.GetAll().ToList();
        }
        public void AddBranch(Branch Branch)
        {
            BranchRepository.Insert(Branch);
        }
        public Branch GetBranch(long id)
        {
            return BranchRepository.Get(id);
        }
        public void UpdateBranch(Branch Branch)
        {
            BranchRepository.Update(Branch);
        }


        public List<BranchGroup> GetAllBranchGroup()
        {
            return BranchGroupRepository.GetQueryable().ToList();
        }
        public List<BranchGroup> GetBranchGroup()
        {
            return BranchGroupRepository.GetAll().ToList();
        }
        public void AddBranchGroup(BranchGroup BranchGroup)
        {
            BranchGroupRepository.Insert(BranchGroup);
        }
        public BranchGroup GetBranchGroup(long id)
        {
            return BranchGroupRepository.Get(id);
        }
        public void UpdateBranchGroup(BranchGroup BranchGroup)
        {
            BranchGroupRepository.Update(BranchGroup);
        }
    }
}
