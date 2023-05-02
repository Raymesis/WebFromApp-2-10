using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace WebApplication1.Database
{
    public sealed class Db
    {
        public SqlConnection cnn { get; }
        private Db()
        {
            string connetionString;
            connetionString = @"Data Source=DESKTOP-G760BD0;Initial Catalog=DivarClone_DB;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
           
        }
        private static readonly Lazy<Db> lazy = new Lazy<Db>(() => new Db());
        public static Db Instance
        {
            get
            {
                return lazy.Value;
            }
        }


    }
}