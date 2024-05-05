using FluentValidation;
using Memberships.DTOs.MembershipStatus;
using Memberships.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Memberships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipStatusController : ControllerBase
    {
        private MemberSecurityContext _context;

        public MembershipStatusController(MemberSecurityContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<MembershipStatusDto>> Get() => await _context.MembershipStatuses.Select(m => new MembershipStatusDto
        {
            MembershipStatusId = m.MembershipStatusId,
            MembershipStatusDesc = m.MembershipStatusDesc
        }).ToListAsync();
    }
}
    
