using Ecommerce.Domain.Failures.Attributes;
using Shouldly;
using Xunit;


namespace Ecommerce.Domain.Test.Unit.Failures.Attributes;

public class AttributeExtensionTests
{
    private const string MESSAGE = "MESSAGE";

    private const string CODE = "CODE";
    
    enum TestingEnum
    {
        [Message(MESSAGE)]
        Message,
        
        WithoutMessage,
        
        [Code(CODE)]
        code,
        
        WithoutCode
    }
    

    [Fact]
    public void GetMessage_EnumHasMessageAttribute_ShouldGetTheMessage()
    {
        // act
        var target = TestingEnum.Message.GetMessage();
        // assert
        target.ShouldBe(MESSAGE);
    }

    [Fact]
    public void GetMessage_EnumDoseNotHaveMessageAttribute_ShouldThrowAException()
    {
        // act
        var getCode = () => {
            TestingEnum.WithoutCode.GetCode();
        };
        // assert
        getCode.ShouldThrow<ArgumentNullException>();
    }

    [Fact]
    public void GetCode_EnumHasCodeAttribute_ShouldGetTheCode()
    {
        // act 
        var target = TestingEnum.code.GetCode();
        // assert
        target.ShouldBe(CODE);
    }
    
    [Fact]
    public void GetCode_EnumDoseNotHaveCodeAttribute_ShouldThrowAException()
    {
        // act
        var getMessage = () =>
        {
            TestingEnum.WithoutCode.GetMessage();
        };
        // assert 
        getMessage.ShouldThrow<ArgumentNullException>();
    }
}