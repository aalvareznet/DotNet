using FluentValidation;
using Memberships.DTOs.PermissionByUser;

namespace Memberships.Validations.PermissionByUser
{
    public class PermissionByUserValidator: AbstractValidator<PermissionByUserDto>
    {
        public PermissionByUserValidator()
        {
            RuleFor(p => p.PermissionId).NotEmpty().WithMessage("Permission ID is required.");
            RuleFor(p => p.UserId).NotEmpty().WithMessage("User ID is required.");
        }
    }
}
