using Challenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Challenge.Data.Mappings;

public class ClientMap : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("Client");
        
        builder.HasKey(client => client.Id);

        builder.Property(client => client.Name)
            .IsRequired()
            .HasMaxLength(200)
            .HasColumnType("VARCHAR")
            .HasColumnName("Name");

        builder.Property(client => client.Document)
            .IsRequired()
            .HasMaxLength(11)
            .HasColumnName("Document")
            .HasColumnType("VARCHAR");

        builder.Property(client => client.BirthDate)
            .IsRequired()
            .HasColumnName("BirthDate")
            .HasColumnType("DateTime");

        builder.HasMany(client => client.Contacts)
            .WithOne(contact => contact.Client);
    }
}