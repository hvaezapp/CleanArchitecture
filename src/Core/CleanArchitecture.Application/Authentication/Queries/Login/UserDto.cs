namespace CleanArchitecture.Application.Authentication.Queries.Login;

public record UserDto(string FirstName, string LastName, 
                      string Mobile,  string Email);