using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Repository.StoredProducers;
using WebApplication2.Repository;
using WebApplication2.Model;

namespace WebApplication2.BusinessLogic
{
     
    public class StatesLogic
    {
        IStatesDao StatesDao = new StateSpImp();
        internal List<State> GetAll()
        {
            return StatesDao.GetStates();
        }
        internal void Edit(State state, System.Security.Principal.IIdentity user)
        {
            StatesDao.EditState(state, Utilities.Utils.GetUserId(user));
        }

        internal void Insert(State state)
        {
            StatesDao.InsertState(state);
        }

        internal void Delete(int stateId, System.Security.Principal.IIdentity user)
        {
            StatesDao.DeleteState(stateId, Utilities.Utils.GetUserId(user));
        }

        internal State GetById(int stateId)
        {
            return StatesDao.GetStateById(stateId);
        }
    }
}