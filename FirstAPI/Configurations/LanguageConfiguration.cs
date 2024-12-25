using FirstAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Configurations
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Language> builder)
        {
            builder.HasKey(x => x.Code);
            builder.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(2);
            builder.HasIndex(x => x.Name)
                .IsUnique();
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(64);
           
        }
    }
}
