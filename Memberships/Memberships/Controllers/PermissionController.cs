using Memberships.DTOs.Permission;
using Memberships.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Memberships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private MemberSecurityContext _context;

        public PermissionController(MemberSecurityContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<PermissionDto>> Get() => await _context.Permissions.Select(m => new PermissionDto
        {
            PersmissionId = m.PersmissionId,
            PermissionDesc = m.PermissionDesc
        }).ToListAsync();
    }
}
