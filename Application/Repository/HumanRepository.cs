using Dapper;
using SQLModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repository
{
    public class HumanRepository
    {
        private const string ConnStr = "Data Source=PETRENKOPC\\SQLEXPRESS; Initial Catalog=CommunalPayment; Integrated Security = SSPI;";
        //username = *** password=****

        public Human GetById (int id)
        {
            string _getHumanById = $"select * from [Human] where UserId = {id}";

            using (var con = new SqlConnection(ConnStr))
            {
                //using Dapper <Human> is a table from DB
                var human = con.Query<Human>(_getHumanById).FirstOrDefault();

                return human;
            }
        }
    }
}
