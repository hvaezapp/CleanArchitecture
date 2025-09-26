using System.Reflection;

namespace CleanArchitecture.Domain.Entities;
public class User : BaseEntity
{
    #region props
    public string FirstName { get; private set; } = null!;
    public string LastName { get; private set; } = null!;
    public string Mobile { get; private set; } = null!;
    public string Email { get; private set; } = null!;
    public string UserName { get; private set; } = null!;
    public string Password { get; private set; } = null!;
    public Address Address { get; private set; } = null!;
    public Gender Gender { get; private set; }
    #endregion

    #region ctors
    public User(string? firstName, string? lastName, 
                string? mobile, string? email)
    {
        FirstName = firstName;
        LastName = lastName;
        Mobile = mobile;
        Email = email;
    }

    public User(string? firstName, string? lastName,
                string? mobile ,string? email, 
                string? username,string? password,
                Address address,Gender gender)
    {
        FirstName = firstName;
        LastName = lastName;
        Mobile = mobile;
        Email = email;
        UserName = username;
        Password = password;
        Address = address;
        Gender = gender;
    }


    #endregion


    public override string ToString() => $"{FirstName} {LastName}";


}
