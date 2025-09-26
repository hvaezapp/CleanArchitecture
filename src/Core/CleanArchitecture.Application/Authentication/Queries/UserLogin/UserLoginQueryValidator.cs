using CleanArchitecture.Application.Authentication.Queries.UserLogin;
public class UserLoginQueryValidator : AbstractValidator<UserLoginQuery>
{
    public UserLoginQueryValidator()
    {
        RuleFor(u => u.Username)
            .NotEmpty().WithMessage("This field is required")
            .MinimumLength(4).WithMessage("Username must be at least 4 characters")
            .MaximumLength(20).WithMessage("Username cannot exceed 20 characters");


        RuleFor(u => u.Password)
            .NotEmpty().WithMessage("This field is required")
            .MinimumLength(6).WithMessage("Password must be at least 6 characters")
            .MaximumLength(100).WithMessage("Password cannot exceed 100 characters")
            .Matches(@"[A-Z]").WithMessage("Password must contain at least one uppercase letter")
            .Matches(@"[a-z]").WithMessage("Password must contain at least one lowercase letter")
            .Matches(@"\d").WithMessage("Password must contain at least one number")
            .Matches(@"[!@#$%^&*(),.?""{}|<>]").WithMessage("Password must contain at least one special character");

    }
}
