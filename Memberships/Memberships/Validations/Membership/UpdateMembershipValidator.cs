using FluentValidation;
using Memberships.DTOs.Membership;

namespace Memberships.Validations.Membership
{
    public class UpdateMembershipValidator : AbstractValidator<UpdateMembershipDto>
    {
        public UpdateMembershipValidator()
        {
            RuleFor(m => m.MembershipDesc).NotEmpty().WithMessage("Membership description is required.");
            RuleFor(m => m.MembershipDesc).MaximumLength(50).WithMessage("Membership description must not exceed 50 characters.");
            RuleFor(m => m.MembershipDesc).NotNull().WithMessage("Membership description is required.");
            RuleFor(M => M.MembershipId).NotEmpty().WithMessage("Membership ID is required.");
        }
    }
}
