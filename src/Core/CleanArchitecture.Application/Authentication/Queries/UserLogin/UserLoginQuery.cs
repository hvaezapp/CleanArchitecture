namespace CleanArchitecture.Application.Authentication.Queries.UserLogin;

public record UserLoginQuery(string Username, string Password) : IRequest<UserDto>;