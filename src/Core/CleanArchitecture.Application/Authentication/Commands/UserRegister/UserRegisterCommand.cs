namespace CleanArchitecture.Application.Authentication.Commands.UserRegister;

public record UserRegisterCommand(
     string FirstName,
     string LastName,
     string Mobile,
     string Email,
     string UserName,
     string Password,
     Address Address,
     Gender Gender

) : IRequest<Guid>;