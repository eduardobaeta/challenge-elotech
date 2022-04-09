using Challenge.Domain.Common;

namespace Challenge.Domain.Entities;

public class Contact : BaseEntity
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public Client Client { get; set; }
}