using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.DatabaseModel;
using WebApplication2.Model;
using System.Data.Entity;
using WebApplication2.Authentication.Roles;

namespace WebApplication2.Repository
{
    public class StateDaoImp:IStatesDao
    {
        ApplicationDbContext Db = ApplicationDbContext.Instance;
        public IQueryable<State> GetStates()
        {
            return Db.States;
        }

        public async void EditState(State state, string userId)
        {
            try
            {
                if (RoleActions.IsAdmin(userId))
                {
                    State item = Db.States.Find(state.StateId);

                    item.StateName = state.StateName;


                    await Db.SaveChangesAsync();

                }
            }
            catch (Exception e)
            {

            }
        }

        public async void InsertState(State state)
        {
            Db.States.Add(state);
            await Db.SaveChangesAsync();
        }

        public async void DeleteState(int stateId, string userId)
        {
            State state = Db.States.Find(stateId);
            Db.States.Remove(state);

            await Db.SaveChangesAsync();
        }

        public State GetStateById(int stateId)
        {
            return Db.States.Find(stateId);
        }
    }
}