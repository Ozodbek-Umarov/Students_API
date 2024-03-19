using Domain;
using FluentValidation;

namespace Application.Validators;

public class StudentValidator : AbstractValidator<Student>
{
    public StudentValidator()
    {
        RuleFor(x => x.FullName).NotEmpty().WithMessage("Ism familya kiriting");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email kiriting");
        RuleFor(x => x.AvatarUrl).NotEmpty().WithMessage("Rasm joylang");
    }
}
