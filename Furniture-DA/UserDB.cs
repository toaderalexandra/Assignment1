using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Furniture_Ob;

namespace Furniture_DA
{
    public class UserDB : IDBMUser
    {
        private string connString = null;

        public UserDB()
        {
            if (connString != null)
            {
                connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            }
        }

       /* public int CheckUser(string username, string password)
        {
            int usertype = 0;
            string cs = @"server=127.0.0.1;port=3306;user=root;database=userslogin";

            MySqlConnection conn = null;
            MySqlDataReader rdr = null;
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                
                string stm = "SELECT usertype.id FROM userslogin.users, userslogin.usertype WHERE users.username='"+
                    username+"' AND users.password='"+
                    password+"' AND usertype_id=usertype.id; ";
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    usertype = rdr.GetInt32("id");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }

            }
            return usertype;
        }
        * */
    
/*
        public IList<User> RetrieveUsers()
        {
            IList<User> userList = new List<User>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelectAllUser";
                MySqlDataReader reader = cmd.ExecuteReader();

                 if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                cmd.Parameters.Add(new MySqlParameter("UserID", user.ID));
                cmd.Parameters.Add(new MySqlParameter("EmployeeName", user.Name));
                cmd.Parameters.Add(new MySqlParameter("UserBirthDate", user.BirthDate));
                cmd.Parameters.Add(new MySqlParameter("UserAddress", user.Address));
                cmd.Parameters.Add(new MySqlParameter("UserName", user.UserName));
                cmd.Parameters.Add(new MySqlParameter("Password", user.Password));
                cmd.Parameters.Add(new MySqlParameter("UserType", user.Type));

                cmd.ExecuteNonQuery();
                
                
                
                
                
                
                conn.Open();
                string statement = "SELECT * FROM student";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Student student = new Student();
                        student.ID = reader.GetInt32("ID");
                        student.Name = reader.GetString("Name");
                        user.BirthDate = reader.GetDateTime("BirthDate");
                        user.Address = reader.GetString("Address");
                        userList.Add(student);
                    }
                }
            }

            return userList;*/
        
        public void AddUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertUser";

                cmd.Parameters.Add(new MySqlParameter("UserID", user.ID));
                cmd.Parameters.Add(new MySqlParameter("EmployeeName", user.Name));
                cmd.Parameters.Add(new MySqlParameter("UserBirthDate", user.BirthDate));
                cmd.Parameters.Add(new MySqlParameter("UserAddress", user.Address));
                cmd.Parameters.Add(new MySqlParameter("UserName", user.UserName));
                cmd.Parameters.Add(new MySqlParameter("Password", user.Password));
                //cmd.Parameters.Add(new MySqlParameter("UserType", user.Type));

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateUser";

                cmd.Parameters.Add(new MySqlParameter("UserID", user.ID));
                cmd.Parameters.Add(new MySqlParameter("EmployeeName", user.Name));
                cmd.Parameters.Add(new MySqlParameter("UserBirthDate", user.BirthDate));
                cmd.Parameters.Add(new MySqlParameter("UserAddress", user.Address));
                cmd.Parameters.Add(new MySqlParameter("UserName", user.UserName));
                cmd.Parameters.Add(new MySqlParameter("Password", user.Password));
                //cmd.Parameters.Add(new MySqlParameter("UserType", user.Type));

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteUser";

                cmd.Parameters.Add(new MySqlParameter("UserID", user.ID));

                cmd.ExecuteNonQuery();
            }
        }
    }
}
