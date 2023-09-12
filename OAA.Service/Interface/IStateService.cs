using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service
{
    public interface IStateService
    {
        void AddState(State State);
        List<State> GetAllState();
        State GetState(long id);
        void UpdateState(State State);
        void DeleteState(State State);
    }
}
