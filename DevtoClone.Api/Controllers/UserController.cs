using DevtoClone.Entities.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace DevtoClone.Api.Controllers
{
    [Route("api/users")]
    public class UserController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var users = await _unitOfWork.Users.GetAsync();
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
