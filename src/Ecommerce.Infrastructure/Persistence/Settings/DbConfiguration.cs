using Ecommerce.Domain.Kernel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.Settings;

/// <summary>
/// This class is about how to map the domain entities into ef core entities
/// </summary>
public class DbConfiguration : 
    IEntityTypeConfiguration<Category>,
    IEntityTypeConfiguration<CategoryAttribute>,
    IEntityTypeConfiguration<SPU>
{
    
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(category => category.Code);
        builder.Property(x => x.Code).UseSerialColumn();
        builder.HasIndex(x => x.Name).IsUnique();
        
    }
    
    public void Configure(EntityTypeBuilder<CategoryAttribute> builder)
    {
        builder.Property<long>("id").IsRequired();
        builder.HasKey("id");
    }

    public void Configure(EntityTypeBuilder<SPU> builder)
    {
        builder.HasKey(spu => spu.Id);
    }
}