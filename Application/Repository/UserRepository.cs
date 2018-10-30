﻿using Dapper;
using SQLModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repository
{
    public class UserRepository
    {
        private const string ConnStr = "Data Source=PETRENKOPC\\SQLEXPRESS; Initial Catalog=CommunalPayment; " +
            "Integrated Security = SSPI;";
        //username = *** password=****

        public User GetById (int id)
        {
            string _getUserById = $"select * from [User] where UserId = {id}";

            using (var con = new SqlConnection(ConnStr))
            {
                //using Dapper/ <User> is a table from DB
                var user = con.Query<User>(_getUserById).FirstOrDefault();

                return user;
            }
        }

        public string GetAll( )
        {
            string _getAllUsers = $"select * from [User]";

            using (var con = new SqlConnection(ConnStr))
            {
                var users = con.Query<User>(_getAllUsers);
                return users;
            }
        }

        public void Update (int id, string email, string password)
        {
            string _updateUser = $"update User SET Email = {email}, Password = {password} where UserId = {id}";

            using (var con = new SqlConnection(ConnStr))
            {
                var user = con.Query<User>(_updateUser);
            }
        }
    }
}
