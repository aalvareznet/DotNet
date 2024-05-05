using FluentValidation;
using Memberships.DTOs.PermissionByUser;
using Memberships.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Memberships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionByUserController : ControllerBase
    {
        private MemberSecurityContext _context;
        private IValidator<InsertPermissionByUserDto> _insertValidator;
        private IValidator<UpdatePermissionByUserDto> _updateValidator;

        public PermissionByUserController(MemberSecurityContext context, IValidator<InsertPermissionByUserDto> insertValidator, IValidator<UpdatePermissionByUserDto> updateValidator)
        {
            _context = context;
            _insertValidator = insertValidator;
            _updateValidator = updateValidator;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<PermissionByUserDto>> GetById(int userId)
        {
            var permissionByUser = await _context.PermissionByUsers.FirstOrDefaultAsync(m => m.UserId == userId);

            if (permissionByUser == null)
            {
                return NotFound();
            }
            var permissionByUserDto = new PermissionByUserDto
            {
                UserId = permissionByUser.UserId,
                PermissionId = permissionByUser.PermissionId
            };
            return Ok(permissionByUserDto);
        }

        [HttpPost]
        public async Task<ActionResult<PermissionByUserDto>> Add(InsertPermissionByUserDto insertDto)
        {
            var validation = await _insertValidator.ValidateAsync(insertDto);
            if (!validation.IsValid)
            {
                return BadRequest(validation.Errors);
            }

            var permissionByUser = new PermissionByUser
            {
                UserId = insertDto.UserId,
                PermissionId = insertDto.PermissionId
            };

            _context.PermissionByUsers.Add(permissionByUser);
            await _context.SaveChangesAsync();

            var permissionByUserDto = new PermissionByUserDto
            {
                UserId = permissionByUser.UserId,
                PermissionId = permissionByUser.PermissionId
            };
            return CreatedAtAction(nameof(GetById), new { userId = permissionByUser.UserId }, permissionByUserDto);
        }
        [HttpPut("{userId}")]
        public async Task<ActionResult<PermissionByUserDto>> Update(int userId, UpdatePermissionByUserDto updateDto)
        {
            var permissionByUser = await _context.PermissionByUsers.FirstOrDefaultAsync(m => m.UserId == userId);

            if (permissionByUser == null)
            {
                return NotFound();
            }

            var validation = await _updateValidator.ValidateAsync(updateDto);
            if (!validation.IsValid)
            {
                return BadRequest(validation.Errors);
            }

            permissionByUser.PermissionId = updateDto.PermissionId;

            await _context.SaveChangesAsync();

            var permissionByUserDto = new PermissionByUserDto
            {
                UserId = permissionByUser.UserId,
                PermissionId = permissionByUser.PermissionId
            };
            return Ok(permissionByUserDto);
        }

    }
}
