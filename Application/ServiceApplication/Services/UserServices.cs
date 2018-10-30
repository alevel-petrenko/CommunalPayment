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
            var user = _userRepository.GetById(id);

            return user.ToDomain();
        }

        //public ICollection<DomainModel.User> GetAll ()
        //{
        //    var userList = _userRepository.GetAll();

        //    return userList<>.ToDomain();
        //}
    }
}
