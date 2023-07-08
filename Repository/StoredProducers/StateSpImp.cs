using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication2.DatabaseModel;
using WebApplication2.Adapter;

namespace WebApplication2.Repository.StoredProducers
{
    public class StateSpImp : IStatesDao
    {
        SpImp<List<Model.State>> spImp = new SpImp<List<Model.State>>();
        public List<Model.State> GetStates()
        {
            SqlParameter[] parameters = { };

            return spImp.Read(
                "dbo.GetStates",
                parameters,
                new StateAdapter().ToList
                );
        }

        public int EditState(Model.State state, string p)
        {


            SqlParameter[] parameters = 
            {                                            
                new SqlParameter("@StateId", state.StateId),         
                new SqlParameter("@StateName", state.StateName) 
            };

            return spImp.Write("dbo.EditState", parameters);
        }

        public int InsertState(Model.State state)
        {
            SqlParameter[] parameters = 
            {                                                    
                new SqlParameter("@StateName", state.StateName)

            };

            return spImp.Write("dbo.InsertState", parameters);
        }

        public int DeleteState(int stateId, string p)
        {
            SqlParameter[] parameters = 
            {                                                    
                new SqlParameter("@StateId", stateId)

            };

            return spImp.Write("dbo.DeleteState", parameters);
        }

        public Model.State GetStateById(int stateId)
        {

            SqlParameter[] parameters = 
            {                                                    
                new SqlParameter("@StateId", stateId)

            };

            return spImp.Read(
                "dbo.GetStateById",
                parameters,
                new StateAdapter().ToList).First();

        }
    }
}