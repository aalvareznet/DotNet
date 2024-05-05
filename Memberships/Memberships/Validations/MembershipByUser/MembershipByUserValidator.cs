using FluentValidation;
using Memberships.DTOs.MembershipByUser;

namespace Memberships.Validations.MembershipByUser
{
    public class MembershipByUserValidator : AbstractValidator<MembershipByUserDto>
    {
        public MembershipByUserValidator()
        {
            RuleFor(m => m.MembershipId).NotEmpty().WithMessage("Membership ID is required.");
            RuleFor(m => m.MembershipStatusId).NotEmpty().WithMessage("Membership Status ID is required.");
            RuleFor(m => m.UserId).NotEmpty().WithMessage("User ID is required.");
        }
    }
}
