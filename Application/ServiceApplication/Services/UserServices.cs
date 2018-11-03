using ApplicationServices;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json;
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
            var jsonList = JsonConvert.SerializeObject(userList);

            return jsonList;
        }

        public void AddUser (string email, string password)
        {
            _userRepository.AddNewUser(email, password);
        }
    }
}
