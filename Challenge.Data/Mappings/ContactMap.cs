using Challenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Challenge.Data.Mappings;

public class ContactMap : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("Contact");

        builder.HasKey(contact => contact.Id);

        builder.Property(contact => contact.Name)
            .IsRequired()
            .HasMaxLength(200)
            .HasColumnName("Name")
            .HasColumnType("VARCHAR");

        builder.Property(contact => contact.Email)
            .IsRequired()
            .HasMaxLength(200)
            .HasColumnName("Email")
            .HasColumnType("VARCHAR");

        builder.Property(contact => contact.Phone)
            .IsRequired()
            .HasMaxLength(11)
            .HasColumnName("Phone")
            .HasColumnType("VARCHAR");

        builder.HasOne(contact => contact.Client)
            .WithMany(client => client.Contacts);
    }
}