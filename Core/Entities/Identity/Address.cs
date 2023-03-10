namespace Core.Entities.Identity;

public class Address : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zipcode { get; set; }
    public string AppUserId { get; set; }

    public AppUser User { get; set; }
}