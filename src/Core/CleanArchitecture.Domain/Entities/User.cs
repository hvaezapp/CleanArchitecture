namespace CleanArchitecture.Domain.Entities;
public class User : BaseEntity
{
    #region props
    public string FirstName { get; private set; } = null!;
    public string LastName { get; private set; } = null!;
    public string Email { get; private set; } = null!;
    public string UserName { get; private set; } = null!;
    public string Password { get; private set; } = null!;
    public Address Address { get; private set; } = null!;
    public Gender Gender { get; private set; }
    #endregion

    #region ctors
    public User(string? firstName, string? lastName, string? email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
    #endregion

}
