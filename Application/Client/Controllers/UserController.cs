using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceApplication.Services;
using SQLModel;

namespace Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserServices _userServices = new UserServices();

        // GET api/user
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok (_userServices.GetAll());
        }

        // GET api/user/id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_userServices.GetById(id));
        }

        // POST api/user
        [HttpPost]
        public string Post([FromBody] User user)
        {
            _userServices.AddUser(user);
            return ("User has been added!");
        }

        // PUT api/user/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] User user)
        {
            _userServices.UpdateUser(id, user);
            return ("User has been updated!");
        }

        // DELETE api/user/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
