using ApplicationServices;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json;
using System.Collections;
//using System.Web.Script.Serialization;

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

        public string GetAll()
        {
            var userList = _userRepository.GetAll();
            var jsonList = JsonConvert.SerializeObject(userList.ToDomain());

            return jsonList;
        }

        public void AddUser (SQLModel.User user)
        {
            _userRepository.AddUser(user);
        }

        public void UpdateUser(int id, SQLModel.User updateUser)
        {
            var user = GetById(id);

            _userRepository.UpdateUser(_GetAndUpdateUser(id, updateUser));
        }

        private SQLModel.User _GetAndUpdateUser(int id, SQLModel.User updateUser)
        {
            var user = _userRepository.GetById(id);
            user.Email = updateUser.Email;
            user.Password = updateUser.Password;

            return user;
        }
    }
}
