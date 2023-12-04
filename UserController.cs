using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // GET: api/user
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            // TODO: Implement logic to retrieve all users
            return new string[] { "User 1", "User 2", "User 3" };
        }

        // GET: api/user/{id}
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            // TODO: Implement logic to retrieve a specific user by ID
            return $"User with ID {id}";
        }

        // POST: api/user
        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {
            // TODO: Implement logic to create a new user
            return $"New user created: {value}";
        }

        // PUT: api/user/{id}
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] string value)
        {
            // TODO: Implement logic to update an existing user by ID
            return $"User with ID {id} updated: {value}";
        }

        // DELETE: api/user/{id}
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            // TODO: Implement logic to delete a user by ID
            return $"User with ID {id} deleted";
        }
    }
}
