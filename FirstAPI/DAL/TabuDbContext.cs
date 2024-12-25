using FirstAPI.Entities;
using Microsoft.EntityFrameworkCore;
namespace FirstAPI.DAL;

public class TabuDBContext : DbContext
{
    public TabuDBContext(DbContextOptions<TabuDBContext> options) : base(options)
    {
    }

    public DbSet<Language> Languages { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TabuDBContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
