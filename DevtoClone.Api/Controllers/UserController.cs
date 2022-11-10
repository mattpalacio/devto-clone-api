using DevtoClone.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DevtoClone.Api.Controllers
{
    [Route("api/users")]
    public class UserController : Controller
    {
        private UnitOfWork unitOfWork = new();

        [HttpGet]
        public  IActionResult GetAllUsers()
        {
            try
            {
                var users = unitOfWork.UserRepository.Get();
                return Ok(users);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error.");
            }
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetUserById()
        //{

        //}

        //[HttpPost]
        //public async Task<IActionResult> CreateUser()
        //{

        //}

        //[HttpPut]
        //public async Task<IActionResult> UpdateUser()
        //{

        //}

        //[HttpDelete]
        //public async Task<IActionResult> DeleteUser()
        //{

        //}
    }
}
