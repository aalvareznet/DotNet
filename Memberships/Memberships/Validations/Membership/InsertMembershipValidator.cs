using FluentValidation;
using Memberships.DTOs.Membership;

namespace Memberships.Validations.Membership
{
    public class InsertMembershipValidator : AbstractValidator<InsertMembershipDto>
    {
        public InsertMembershipValidator() 
        {
            RuleFor(m => m.MembershipDesc).NotEmpty().WithMessage("Membership description is required.");
            RuleFor(m => m.MembershipDesc).MaximumLength(50).WithMessage("Membership description must not exceed 50 characters.");
            RuleFor(m => m.MembershipDesc).NotNull().WithMessage("Membership description is required.");
        }
    }
}
