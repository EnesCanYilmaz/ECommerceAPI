using ECommerceAPI.Application.ViewModels.Products;
using FluentValidation;

namespace ECommerceAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Product_Create>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                        .WithMessage("product name cannot to be empty")
                .MaximumLength(150)
                .MinimumLength(2)
                        .WithMessage("product name must be between 1 and 150");
            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("stock cannot to be empty")
                .Must(s => s >= 0)
                        .WithMessage("stock must be 0 or greater");
            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("price cannot to be empty")
                .Must(p => p >= 0)
                        .WithMessage("price must be 0 or greater");


        }
    }
}
