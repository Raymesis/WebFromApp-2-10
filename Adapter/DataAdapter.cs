using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Adapter
{
    public abstract class DataAdapter<T>
    {
        protected System.Data.SqlClient.SqlDataReader data;
        internal List<T> ToList(System.Data.SqlClient.SqlDataReader _data)
        {
            data = _data;
            List<T> list = new List<T>();

            while (data.Read())
            {
                list.Add(ReadSingleRow());

            }
            return list;
        }
        internal T GetSingleRow(System.Data.SqlClient.SqlDataReader _data)
        {
            data = _data;

            return ReadSingleRow();
        }
        protected abstract T ReadSingleRow();
    }
}