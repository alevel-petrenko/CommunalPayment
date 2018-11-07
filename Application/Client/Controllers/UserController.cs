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
        public void Post([FromBody]User user)
        {
            _userServices.AddUser(user);
        }

        // PUT api/user/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            _userServices.UpdateUser(id, value);
        }

        // DELETE api/user/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
