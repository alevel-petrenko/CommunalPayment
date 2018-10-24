using ApplicationServices;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApplication.Services
{
    public class UserServices
    {
        private readonly UserRepository _userRepository = new UserRepository();

        public DomainModel.User GetById (int id)
        {
            var h1 = _userRepository.GetById(id);

            return h1.ToDomain();
        }

        public ICollection<DomainModel.User> GetAll ()
        {
            var userList = new List<SQLModel.User>()
            {
                //new SQLModel.Human { Email = "some@email", Id = 1, Name = "Name1" },
                //new SQLModel.Human { Email = "some@email", Id = 2, Name = "Name2" },
                //new SQLModel.Human { Email = "some@email", Id = 3, Name = "Name3" }
        };
            return userList.ToDomain();
        }
    }
}
