using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Model;

namespace WebApplication2.Repository
{
    interface IStatesDao
    {
        List<State> GetStates();

         int EditState(State state, string p);

         int InsertState(State state);

         int DeleteState(int stateId, string p);

         State GetStateById(int stateId);
    }
}