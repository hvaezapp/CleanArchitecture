namespace CleanArchitecture.Domain.ValueObjects;
public class Address : ValueObject
{
    public string City { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
}