﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Model;
using WebApplication1.Database;
using System.Data;
using System.Data.SqlClient;
namespace WebApplication1.Repository
{
    public class PostDaoImp : IPostDao
    {
        public void addPost(PostModel post)
        {
            throw new NotImplementedException();
        }

        public List<PostModel> getPosts()
        {
            List<PostModel> posts = new List<PostModel>();

            SqlCommand command;
            SqlDataReader reader;
            String sql = "";

            sql = "select * from Post";

            Db.Instance.cnn.Open();

            command = new SqlCommand(sql, Db.Instance.cnn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                posts.Add(
                   new PostModel(
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetInt32(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetInt32(6),             
                    "",
                    "",//reader.GetString(8),
                    System.DateTime.Now,//reader.GetDateTime(9),
                    true//reader.GetBoolean(10))
                ));

            }
            Db.Instance.cnn.Close();
            return posts;
        }
    }
}
/*posts.Add(
  new PostModel(reader["id"],
   reader["daste_id"],
   reader["user_id"],
   reader["gheimat"],
   reader["onvan"],
   reader["tozihat"],
   reader["vaziat_forosh"],
   reader["img"],
   reader["shomare_tamas"],
   reader["tarikh_sabt"],
   reader["is_active"]));*/
