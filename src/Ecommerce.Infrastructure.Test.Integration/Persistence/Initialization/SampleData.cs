using Ecommerce.Domain.Kernel;

namespace Ecommerce.Infrastructure.Test.Integration.Persistence.Initialization;

public static class SampleData
{
    public static List<Category> Categories => new()
    {
        new Category()
        {
            Code = 1, 
            Name = "時裝",
        },
        new Category()
        {
            Code = 2, 
            Name = "電玩"
        },
    };
}