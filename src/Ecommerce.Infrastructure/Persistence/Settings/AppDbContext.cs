using Ecommerce.Domain.Kernel;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Persistence.Settings;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSnakeCaseNamingConvention();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var configuration = new DbConfiguration();
        modelBuilder.ApplyConfiguration<Category>(configuration);
        modelBuilder.ApplyConfiguration<CategoryAttribute>(configuration);
        modelBuilder.ApplyConfiguration<SPU>(configuration);
    }
}