using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationServices
{
    public static class DomainToSqlMapper
    {
        public static DomainModel.User ToDomain(this SQLModel.User sqlModel)
        {
            return new DomainModel.User
            {
                Email = sqlModel.Email,
                UserId = sqlModel.UserId,
                Password = sqlModel.Password
            };
        }

        public static ICollection<DomainModel.User> ToDomain(this ICollection<SQLModel.User> sqlCollection)
        {
            return sqlCollection.Select(m => m.ToDomain()).ToList();
        }
    }
}
