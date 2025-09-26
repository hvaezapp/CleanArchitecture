namespace CleanArchitecture.Application.Authentication.Queries.UserLogin;

public record UserDto(string FirstName, string LastName, 
                      string Mobile,  string Email);