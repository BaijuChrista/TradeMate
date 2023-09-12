using Microsoft.EntityFrameworkCore;
using SC.Data;
using SC.Repository;
using System.Collections.Generic;
using System.Linq;

namespace SC.Service
{
    public class StateService : IStateService
    {
        private IRepository<State> stateRepository;

        public StateService(IRepository<State> stateRepository)
        {
            this.stateRepository = stateRepository;
        }

        public List<State> GetAllState()
        {
            return stateRepository.GetQueryable().Include(b => b.Country).ToList();
        }

        public void AddState(State State)
        {
            stateRepository.Insert(State);
        }

        public State GetState(long id)
        {
            return stateRepository.Get(id);
        }

        public void UpdateState(State State)
        {
            stateRepository.Update(State);
        }

        public void DeleteState(State State)
        {
            stateRepository.Delete(State);
        }
    }
}
