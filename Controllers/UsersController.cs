using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Models;

namespace UserManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private static List<User> users = new();

        [HttpGet]
        public IActionResult GetAll() => Ok(users);

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            users.Add(user);
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, User updatedUser)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();

            if (!ModelState.IsValid) return BadRequest(ModelState);

            user.Name = updatedUser.Name;
            user.Email = updatedUser.Email;

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();

            users.Remove(user);
            return Ok(new { message = "User deleted" });
        }
    }
}
