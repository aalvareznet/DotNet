using FluentValidation;
using Memberships.DTOs.User;
using Memberships.Models;
using Memberships.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Memberships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private MemberSecurityContext _context;
        private IValidator<InsertUserDto> _insertValidator;
        private IValidator<UpdateUserDto> _updateValidator;
        private IPasswordHasher _passwordHasher;


        public UserController(MemberSecurityContext context, IValidator<InsertUserDto> insertValidator, IValidator<UpdateUserDto> updateValidator, IPasswordHasher passwordHasher)
        {
            _context = context;
            _insertValidator = insertValidator;
            _updateValidator = updateValidator;
            _passwordHasher = passwordHasher;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> Get() => await _context.Users.Select(u => new UserDto
        {
            UserId = u.UserId,
            UserName = u.UserName,
            PasswordHash = u.PasswordHash
        }).ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetById(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var userDto = new UserDto
            {
                UserId = user.UserId,
                UserName = user.UserName,
                PasswordHash = user.PasswordHash
            };
            return Ok(userDto);
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> Add(InsertUserDto insertDto)
        {
            var validation = await _insertValidator.ValidateAsync(insertDto);
            if (!validation.IsValid)
            {
                return BadRequest(validation.Errors);
            }

            var userExists = await _context.Users.AnyAsync(u => u.UserName == insertDto.UserName);
            if (userExists)
            {
                return StatusCode(StatusCodes.Status409Conflict, "User already exists");
            }

            var passwordHash = _passwordHasher.Hash(insertDto.PasswordHash);
            var user = new User
            {
                UserName = insertDto.UserName,
                PasswordHash = passwordHash
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            var userDto = new UserDto
            {
                UserId = user.UserId,
                UserName = user.UserName,
                PasswordHash = user.PasswordHash
            };
            return CreatedAtAction(nameof(GetById), new { id = user.UserId }, userDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserDto>> Update(int id, UpdateUserDto updateDto)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var validation = await _updateValidator.ValidateAsync(updateDto);
            if (!validation.IsValid)
            {
                return BadRequest(validation.Errors);
            }

            user.UserName = updateDto.UserName;
            user.PasswordHash = updateDto.PasswordHash;

            await _context.SaveChangesAsync();

            var userDto = new UserDto
            {
                UserId = user.UserId,
                UserName = user.UserName,
                PasswordHash = user.PasswordHash
            };
            return Ok(userDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UserDto>> Delete(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
