using AutoMapper;
using DevtoClone.Api.DTOs.User;
using DevtoClone.Api.Mapper;
using DevtoClone.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevtoClone.Api.Controllers
{
    [Route("api/users")]
    public class UserController : Controller
    {
        private IMapper _mapper;
        private IUserService _userService;

        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();

            var usersDto = _mapper.MapUsers(users);

            return Ok(usersDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await _userService.GetUserById(id);

            var userDto = _mapper.Map<UserDto>(user);

            return Ok(userDto);
        }

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
