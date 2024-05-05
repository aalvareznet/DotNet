using FluentValidation;
using Memberships.DTOs.User;

namespace Memberships.Validations.User
{
    public class InsertUserValidator : AbstractValidator<InsertUserDto>
    {
        public InsertUserValidator()
        {
            RuleFor(u => u.UserName).NotEmpty().WithMessage("User Name is required");
            RuleFor(u => u.UserName).MaximumLength(50).WithMessage("User Name must not exceed 50 characters.");
            RuleFor(u => u.UserName).NotNull().WithMessage("User Name is required.");
            RuleFor(u => u.PasswordHash).NotEmpty().WithMessage("Password is required.");
            RuleFor(u => u.PasswordHash).NotNull().WithMessage("Password is required.");
            RuleFor(u => u.PasswordHash).MaximumLength(50).WithMessage("Password must not exceed 50 characters.");
            RuleFor(u => u.PasswordHash).MinimumLength(8).WithMessage("Password must be at least 8 characters.");

        }
    }
}
