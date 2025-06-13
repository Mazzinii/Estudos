using System.Data.Entity;
using AutoMapper;
using Mapper.Data;
using Mapper.Endpoint.User;
using Mapper.Models.DTOs;
using Mapper.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Mapper.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UserController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("users")]
        public async Task<ActionResult> CreateUser(UserRequest request)
        {
            //usando o perfil do automapper
            //transformando de request para model
            var user = _mapper.Map<User>(request);

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            //transformando em DTO para view
            var userView = _mapper.Map<UserDTO>(user);

            return Ok(userView);
        }

        [HttpGet("users")]
        public async Task<ActionResult> GetUsers()
        {
            var users = _context.Users.ToList();

            var usersView = _mapper.Map<List<UserDTO>>(users);

            return Ok(usersView);
        }

        [HttpGet("users/{id}")]
        public async Task<ActionResult> GetUserbyId(int id)
        {
            var users = _context.Users.Where(x => x.Id == id).ToList();

            var usersView = _mapper.Map<List<UserDTO>>(users);

            return Ok(usersView);
        }
    }
}
