using Ecommerce.Domain.Failures.Attributes;
using Ecommerce.Infrastructure.Failures;
using Shouldly;
using Xunit;

namespace Ecommerce.Infrastructure.Test.Unit.Failures;

public class DatabaseCodeTests
{
    [Fact]
    public void IDIsAlreadyExist_ShouldHasCorrectCodeAndMessage()
    {
        // act
        var code = DatabaseCode.IDIsAlreadyExist.GetCode();
        var message = DatabaseCode.IDIsAlreadyExist.GetMessage();
        
        // assert
        code.ShouldBe("Database.IDIsAlreadyExist");
        message.ShouldBe("ID 已經使用過了");
    }
    
    [Fact]
    public void NameIsAlreadyExist_ShouldHasCorrectCodeAndMessage()
    {
        // act
        var code = DatabaseCode.NameIsAlreadyExist.GetCode();
        var message = DatabaseCode.NameIsAlreadyExist.GetMessage();
        
        // assert
        code.ShouldBe("Database.NameIsAlreadyExist");
        message.ShouldBe("名稱已經使用過了");
    }
}