using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceApplication.Services;

namespace Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private UserServices _humanServices = new UserServices();

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    return Ok(_humanServices.GetAll());
        //}

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            return Ok(_humanServices.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
