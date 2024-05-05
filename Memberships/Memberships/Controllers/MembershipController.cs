using FluentValidation;
using Memberships.DTOs.Membership;
using Memberships.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Memberships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipController : ControllerBase
    {
        private MemberSecurityContext _context;
        private IValidator<InsertMembershipDto> _insertValidator;
        private IValidator<UpdateMembershipDto> _updateValidator;

        public MembershipController(MemberSecurityContext context, IValidator<InsertMembershipDto> insertValidator, IValidator<UpdateMembershipDto> updateValidator)
        {
            _context = context;
            _insertValidator = insertValidator;
            _updateValidator = updateValidator;
        }

        [HttpGet]
        public async Task<IEnumerable<MembershipDto>> Get() => await _context.Memberships.Select(m => new MembershipDto
        {
            MembershipId = m.MembershipId,
            MembershipDesc = m.MembershipDesc
        }).ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<MembershipDto>> GetById(int id)
        {
            var membership = await _context.Memberships.FindAsync(id);

            if (membership == null)
            {
                return NotFound();
            }

            var membershipDto = new MembershipDto
            {
                MembershipId = membership.MembershipId,
                MembershipDesc = membership.MembershipDesc
            };
            return Ok(membershipDto);
        }
        [HttpPost]
        public async Task<ActionResult<MembershipDto>> Add(InsertMembershipDto insertDto) 
        {
            var validation = await _insertValidator.ValidateAsync(insertDto);
            if (!validation.IsValid) 
            {
                return BadRequest(validation.Errors);
            }

            var membership = new Membership
            {
                MembershipDesc = insertDto.MembershipDesc
            };

            await _context.Memberships.AddAsync(membership);
            await _context.SaveChangesAsync();

            var membershipDto = new MembershipDto
            {
                MembershipId = membership.MembershipId,
                MembershipDesc = membership.MembershipDesc
            };
            return CreatedAtAction(nameof(GetById), new { id = membership.MembershipId }, membershipDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<MembershipDto>> Update(int id, UpdateMembershipDto updateDto)
        {

            var membership = await _context.Memberships.FindAsync(id);

            if (membership == null)
            {
                return NotFound();
            }

            var validation = await _updateValidator.ValidateAsync(updateDto);
            if (!validation.IsValid)
            {
                return BadRequest(validation.Errors);
            }

            membership.MembershipDesc = updateDto.MembershipDesc;

            await _context.SaveChangesAsync();

            var membershipDto = new MembershipDto
            {
                MembershipId = membership.MembershipId,
                MembershipDesc = membership.MembershipDesc
            };
            return Ok(membershipDto);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var membership = await _context.Memberships.FindAsync(id);

            if (membership == null)
            {
                return NotFound();
            }

            _context.Memberships.Remove(membership);
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
