using Dapper;
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
            string _cond = $"SELECT * FROM [User] WHERE EXISTS (SELECT UserId FROM[User] WHERE UserId= '{id}')";

            using (var con = new SqlConnection(ConnStr))
            {
                //using Dapper/ <User> is a table from DB
                var user = con.Query<User>(_getUserById).FirstOrDefault();
                return user;
            }
        }

        public ICollection<User> GetAll( )
        {
            string _getAllUsers = $"select * from [User]";

            using (var con = new SqlConnection(ConnStr))
            {
                var users = con.Query<User>(_getAllUsers).ToList();
                return users;
            }
        }

        public void AddUser(SQLModel.User newUser)
        {
            string _addingNewUser = $"insert into [User] values('{newUser.Email}', '{newUser.Password}')";

            using (var con = new SqlConnection(ConnStr))
            {
                con.Query<User>(_addingNewUser);
            }
        }

        public void UpdateUser (SQLModel.User user)
        {
            string _updateUser = $"update [User] SET Email = '{user.Email}', Password = '{user.Password}' where UserId = {user.UserId}";
            //UPDATE table_name SET column1 = value1, column2 = value2, WHERE condition;

            using (var con = new SqlConnection(ConnStr))
            {
                con.Query<User>(_updateUser);
            }
        }

        public void DeleteUser (int id)
        {
            string _deleteUser = "";

            using (SqlConnection connection = new SqlConnection(_deleteUser))
            {
                connection.Query(_deleteUser);
            }
        }
    }
}
