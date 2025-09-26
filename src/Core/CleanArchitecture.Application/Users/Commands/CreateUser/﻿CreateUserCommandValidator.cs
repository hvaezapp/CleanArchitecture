namespace CleanArchitecture.Application.Users.Commands.CreateUser;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(u => u.FirstName)
               .NotEmpty().WithMessage("this field is required")
               .MaximumLength(50).WithMessage("first name must be less than 50");


        RuleFor(u => u.LastName)
               .NotEmpty().WithMessage("this field is required")
               .MaximumLength(50).WithMessage("last name must be less than 50");


        RuleFor(u => u.Mobile)
            .NotEmpty().WithMessage("This field is required")
            .Length(11).WithMessage("Mobile number must be exactly 11 digits")
            .Matches(@"^\d{11}$").WithMessage("Mobile number must contain only digits");


        RuleFor(u => u.Email)
            .NotEmpty().WithMessage("This field is required")
            .EmailAddress().WithMessage("Invalid email format");
    }
}