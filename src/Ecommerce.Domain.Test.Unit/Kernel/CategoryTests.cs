using Ecommerce.Domain.Kernel;
using Shouldly;
using Xunit;

namespace Ecommerce.Domain.Test.Unit.Kernel;

public class CategoryTests
{
    
    [Fact]
    public void Name_MustBeUnique()
    {
        var category1 = new Category();
        category1.Code = 100;
        category1.Name = "Fashion";
        var category2 = new Category();
        category2.Code = 1;
        category2.Name = "Fashion";

        var set = new HashSet<Category>();
        set.Add(category1);
        set.Add(category2);
        
        set.Count.ShouldBe(1);      
        set.First().Code.ShouldBe(100);
    }

}