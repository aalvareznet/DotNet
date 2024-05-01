using FishesApi.DTOs.Fishes;
using FluentValidation;

namespace FishesApi.Validators
{
    public class FishValidation : AbstractValidator<FishInsertDto>
    {
        public FishValidation()
        {
            RuleFor(f => f.FishName).NotEmpty().MaximumLength(50).WithMessage("El nombre debe medir entre 1 y 50 caracteres");
            RuleFor(f => f.FishDescription).NotEmpty().MaximumLength(200);
            RuleFor(f => f.FishWeight).NotEmpty().GreaterThan(0);
            RuleFor(f => f.FishLength).NotEmpty().GreaterThan(0);
            RuleFor(f => f.FishColor).NotEmpty().MaximumLength(50);
            RuleFor(f => f.PlaceOfCapture).NotEmpty().MaximumLength(50);
            RuleFor(f => f.FishCategoryId).NotEmpty().GreaterThan(0);
        }
    }
}
