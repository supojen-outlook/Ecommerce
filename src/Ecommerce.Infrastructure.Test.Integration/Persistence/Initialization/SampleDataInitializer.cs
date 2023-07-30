using Ecommerce.Infrastructure.Persistence.Settings;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Test.Integration.Persistence.Initialization;

public static class SampleDataInitializer
{
    internal static void Seed<TEntity>(AppDbContext context, List<TEntity> records) where TEntity : class
    {
        using var transaction = context.Database.BeginTransaction();
        context.Set<TEntity>().AddRange(records);
        context.SaveChanges();
        transaction.Commit();
    }
} 