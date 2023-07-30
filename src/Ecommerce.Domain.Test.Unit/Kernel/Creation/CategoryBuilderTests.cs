using Ecommerce.Domain.Failures;
using Ecommerce.Domain.Failures.Attributes;
using Ecommerce.Domain.Kernel;
using Ecommerce.Domain.Kernel.Creation;
using Shouldly;
using Xunit;

namespace Ecommerce.Domain.Test.Unit.Kernel.Creation;

public class CategoryBuilderTests
{
    //[Fact]
    //public void build_IfNameIsNotBeenSet_ShouldBeFail()
    //{
    //    var builder = new CategoryBuilderImpl();
    //    builder.SetCode(1);
    //
    //    var target = builder.Build();
    //
    //    target.Value.ShouldBeOfType<Failure>();
    //    target.AsT0.Code.ShouldBe(CategoryCode.MustHasName.GetCode());
    //    target.AsT0.Message.ShouldBe(CategoryCode.MustHasName.GetMessage());
    //}
    
    //[Fact]
    //public void build_IfCodeIsNotBeenSet_ShouldBeFail()
    //{
    //    var builder = new CategoryBuilderImpl();
    //    builder.SetName("Fashion");
    //
    //    var target = builder.Build();
    //
    //    target.Value.ShouldBeOfType<Failure>();
    //    target.AsT0.Code.ShouldBe(CategoryCode.MustHasCode.GetCode());
    //    target.AsT0.Message.ShouldBe(CategoryCode.MustHasCode.GetMessage());
    //}

    //[Fact]
    //public void AddChild_TheChildHasSameName_ShouldBeFail()
    //{
    //    var builder = new CategoryBuilderImpl();
    //    
    //    var target1 = builder.AddChild(1, "Fashion");
    //    var target2 = builder.AddChild(2, "Fashion");
    //
    //    target1.Value.ShouldBeOfType<Category>();
    //    target1.AsT1.Code.ShouldBe(1);
    //    target1.AsT1.Name.ShouldBe("Fashion");
    //    target2.Value.ShouldBeOfType<Failure>();
    //    target2.AsT0.Code.ShouldBe(CategoryCode.DuplicatedName.GetCode());
    //    target2.AsT0.Message.ShouldBe(CategoryCode.DuplicatedName.GetMessage());
    //}

    //[Fact]
    //public void AddChild_ShouldBeSuccess()
    //{
    //    var builder = new CategoryBuilderImpl();
    //    builder.SetCode(1);
    //    builder.SetName("配件");
    //
    //    var target = builder.AddChild(2, "帽子");
    //    var root = builder.Build();
    //    
    //    target.Value.ShouldBeOfType<Category>();
    //    target.AsT1.Code.ShouldBe(2);
    //    target.AsT1.Name.ShouldBe("帽子");
    //    target.AsT1.Parent.ShouldBe(root.AsT1);
    //}
    
    //[Fact]
    //public void AddChild_TheDeepOfLayerHigherThanThree_ShouldBeFail()
    //{
    //    // Arrange
    //    var level1 = new Category()
    //    {
    //        Code = 1,
    //        Name = "時尚流行",
    //        Children = new ()
    //    };
    //    var level2 = new Category()
    //    {
    //        Code = 2,
    //        Name = "男性",
    //        Children = new ()
    //    };
    //    var level3= new Category()
    //    {
    //        Code = 3,
    //        Name = "配件",
    //        Children = new ()
    //    };
    //    level2.Children.Add(level3);
    //    level3.Parent = level2;
    //    level1.Children.Add(level2);
    //    level2.Parent = level1;
    //    
    //    var builder = new CategoryBuilderImpl();
    //    builder.Init(level3);
    //
    //    // Act
    //    var target = builder.AddChild(4, "帽子");
    //    
    //    // Assert
    //    target.Value.ShouldBeOfType<Failure>();
    //    target.AsT0.Code.ShouldBe(CategoryCode.DeepNumberCannotOverThree.GetCode());
    //    target.AsT0.Message.ShouldBe(CategoryCode.DeepNumberCannotOverThree.GetMessage());
    //}
}