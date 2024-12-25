using FirstAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstAPI.Configurations;

public class GameConfiguration
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder
            .HasKey(x => x.Id);
        builder
            .Property(x => x.LanguageCode)
            .HasDefaultValue("az");
        builder
            .HasOne(x => x.Language)
            .WithMany(x => x.Games)
            .HasForeignKey(x => x.LanguageCode);

    }
}
