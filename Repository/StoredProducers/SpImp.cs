using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WebApplication2.DatabaseModel;
using System.Data;

namespace WebApplication2.Repository.StoredProducers
{
    
    public class SpImp<T>
    {
        public delegate T TaskCompletedCallBack(SqlDataReader data);

        DbConnection db = DbConnection.Instance;
        public T Read(string sp,SqlParameter[] parameters,TaskCompletedCallBack CallbackMethod)
        {
            SqlCommand sqlCmd = new SqlCommand(sp, db.sqlConn);

            T data;

            sqlCmd.Parameters.AddRange(parameters);

            sqlCmd.CommandType = CommandType.StoredProcedure;
            
            try
            {

                db.sqlConn.Open();

                data = CallbackMethod(sqlCmd.ExecuteReader());

                db.sqlConn.Close();

                return data;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            return default(T);
        }
        public int Write(string sp, SqlParameter[] parameters)
        {
            SqlCommand sqlCmd = new SqlCommand(sp, db.sqlConn);
            sqlCmd.Parameters.AddRange(parameters);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter retValParam = sqlCmd.Parameters.Add("@returnValue", SqlDbType.Int);
            retValParam.Direction = ParameterDirection.ReturnValue;

            db.sqlConn.Open();

            sqlCmd.ExecuteNonQuery();

            db.sqlConn.Close();

            return Convert.ToInt32(retValParam.Value);
        }
    }
}