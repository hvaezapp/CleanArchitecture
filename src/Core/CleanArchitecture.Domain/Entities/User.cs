namespace CleanArchitecture.Domain.Entities;
public class User : BaseEntity
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
    public Address Address { get; set; } = null!;
    public Gender Gender { get; set; }
}
