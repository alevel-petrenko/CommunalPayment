using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationServices
{
    public static class DomainToSqlMapper
    {
        public static DomainModel.Human ToDomain(this SQLModel.Human sqlModel)
        {
            return new DomainModel.Human
            {
                Email = sqlModel.Email,
                Id = sqlModel.UserId,
                Name = sqlModel.Name
            };
        }

        public static ICollection<DomainModel.Human> ToDomain(this ICollection<SQLModel.Human> sqlCollection)
        {
            return sqlCollection.Select(m => m.ToDomain()).ToList();
        }
    }
}
