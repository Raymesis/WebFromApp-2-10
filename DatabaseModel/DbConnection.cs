using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication2.DatabaseModel
{
    public class DbConnection
    {
        public SqlConnection sqlConn;
        

        public SqlParameterCollection sqlParameters;
        public string procString;

        private DbConnection()
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            sqlConn = new SqlConnection(connectionStr);
           
           
        }

        private static readonly Lazy<DbConnection> lazy = new Lazy<DbConnection>(() => new DbConnection());
        public static DbConnection Instance
        {
            get
            {
                return lazy.Value;
            }
        }


    }
}