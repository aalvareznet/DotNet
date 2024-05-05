using FluentValidation;
using Memberships.DTOs.MembershipByUser;
using Memberships.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Memberships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipByUserController : ControllerBase
    {
        private MemberSecurityContext _context;
        private IValidator<InsertMembershipByUserDto> _insertValidator;
        private IValidator<UpdateMembershipByUserDto> _updateValidator;
    
        public MembershipByUserController(MemberSecurityContext context, IValidator<InsertMembershipByUserDto> insertValidator, IValidator<UpdateMembershipByUserDto> updateValidator)
        {
            _context = context;
            _insertValidator = insertValidator;
            _updateValidator = updateValidator;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<MembershipByUserDto>> GetById(int userId) 
        {
            var membershipByUser = await _context.MembershipByUsers.FirstOrDefaultAsync(m => m.UserId == userId);

            if (membershipByUser == null)
            {
                return NotFound();
            }
            var membershipByUserDto = new MembershipByUserDto
            {
                UserId = membershipByUser.UserId,
                MembershipId = membershipByUser.MembershipId
            };
            return Ok(membershipByUserDto);
        }

        [HttpPost]
        public async Task<ActionResult<MembershipByUserDto>> Add(InsertMembershipByUserDto insertDto)
        {
            var validation = await _insertValidator.ValidateAsync(insertDto);
            if (!validation.IsValid)
            {
                return BadRequest(validation.Errors);
            }

            var membershipByUser = new MembershipByUser
            {
                UserId = insertDto.UserId,
                MembershipId = insertDto.MembershipId
            };

            _context.MembershipByUsers.Add(membershipByUser);
            await _context.SaveChangesAsync();

            var membershipByUserDto = new MembershipByUserDto
            {
                UserId = membershipByUser.UserId,
                MembershipId = membershipByUser.MembershipId
            };
            return CreatedAtAction(nameof(GetById), new { userId = membershipByUser.UserId }, membershipByUserDto);
        }
        [HttpPut("{userId}")]
        public async Task<ActionResult<MembershipByUserDto>> Update(int userId, UpdateMembershipByUserDto updateDto)
        {
            var membershipByUser = await _context.MembershipByUsers.FirstOrDefaultAsync(m => m.UserId == userId);

            if (membershipByUser == null)
            {
                return NotFound();
            }

            var validation = await _updateValidator.ValidateAsync(updateDto);
            if (!validation.IsValid)
            {
                return BadRequest(validation.Errors);
            }

            membershipByUser.MembershipId = updateDto.MembershipId;

            await _context.SaveChangesAsync();

            var membershipByUserDto = new MembershipByUserDto
            {
                UserId = membershipByUser.UserId,
                MembershipId = membershipByUser.MembershipId
            };
            return Ok(membershipByUserDto);
        }

    }

}
