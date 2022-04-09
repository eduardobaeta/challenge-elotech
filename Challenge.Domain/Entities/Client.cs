using Challenge.Domain.Common;

namespace Challenge.Domain.Entities;

public class Client : BaseEntity
{
    public string Name { get; set; }
    public string Document { get; set; }
    public DateTime BirthDate { get; set; }
    public List<Contact> Contacts { get; set; }
}