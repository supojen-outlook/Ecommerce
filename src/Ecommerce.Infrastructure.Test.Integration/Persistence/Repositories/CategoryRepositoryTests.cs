using Xunit.Abstractions;

namespace Ecommerce.Infrastructure.Test.Integration.Persistence.Repositories;

public class CategoryRepositoryTests
{
    private readonly ITestOutputHelper output;

    public CategoryRepositoryTests(ITestOutputHelper output)
    {
        this.output = output;
    }
}