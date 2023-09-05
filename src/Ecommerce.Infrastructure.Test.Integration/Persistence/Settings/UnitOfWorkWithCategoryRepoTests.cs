using Ecommerce.Domain.Kernel;
using Ecommerce.Infrastructure.Persistence.Repositories;
using Ecommerce.Infrastructure.Persistence.Settings;
using Ecommerce.Infrastructure.Test.Integration.Persistence.Initialization;
using Shouldly;
using Test.Helpers;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions.AssertExtensions;

namespace Ecommerce.Infrastructure.Test.Integration.Persistence.Settings;

/// <summary>
/// Unit odf work with category repository
/// </summary>
public class UnitOfWorkWithCategoryRepoTests
{
    private readonly ITestOutputHelper output;
    
    public UnitOfWorkWithCategoryRepoTests(ITestOutputHelper output)
    {
        this.output = output;
    }
    
    //[Fact]
    //public async Task GetAsync_IfExist_ShouldGetTheData()
    //{
    //    var options = this.CreatePostgreSqlUniqueClassOptionsWithLogTo<AppDbContext>(output.WriteLine);
    //    await using (var context = new AppDbContext(options))
    //    {
    //        // SETUP DB_CONTEXT
    //        context.Database.EnsureDeleted();
    //        context.Database.EnsureCreated();
    //        
    //        // arrange
    //        var repository = new CategoryRepository(context);
    //        var unitOfWork = new UnitOfWork(context);
    //        SampleDataInitializer.Seed(context,SampleData.Categories);
    //        
    //        // act
    //        using var transaction = unitOfWork.Begin();
    //        var target = await repository.GetAsync(SampleData.Categories[0].Code);
    //        unitOfWork.Commit(transaction);
    //        
    //        // assert
    //        target.Value.ShouldBeType<Category>();
    //        target.AsT1.Id.ShouldBe(SampleData.Categories[0].Id);
    //        target.AsT1.Name.ShouldBe(SampleData.Categories[0].Name);
    //    }
    //}

    //[Fact]
    //public async Task GetAsync_IfNotExist_ShouldReturnFailure()
    //{
    //    var options = this.CreatePostgreSqlUniqueClassOptionsWithLogTo<AppDbContext>(output.WriteLine);
    //    await using (var context = new AppDbContext(options))
    //    {
    //        // SETUP DB_CONTEXT
    //        context.Database.EnsureDeleted();
    //        context.Database.EnsureCreated();
    //        
    //        // arrange
    //        var repository = new CategoryRepository(context);
    //        var unitOfWork = new UnitOfWork(context);
    //
    //        // act
    //        using var transaction = unitOfWork.Begin();
    //        var target = await repository.GetAsync(SampleData.Categories[0].Id);
    //        unitOfWork.Commit(transaction);
    //        
    //        // assert
    //        target.Value.ShouldBeType<Failure>();
    //        target.AsT0.Code.ShouldBe(CategoryCode.NotExist.GetCode());
    //        target.AsT0.Message.ShouldBe(CategoryCode.NotExist.GetMessage());
    //    }
    //}
    
    //[Fact]
    //public async Task AddAsync_Execute_ShouldSuccess()
    //{
    //    var options = this.CreatePostgreSqlUniqueClassOptionsWithLogTo<AppDbContext>(output.WriteLine);
    //    await using (var context = new AppDbContext(options))
    //    {
    //        // SETUP DB_CONTEXT
    //        context.Database.EnsureDeleted();
    //        context.Database.EnsureCreated();
    //        
    //        // arrange
    //        var repository = new CategoryRepository(context);
    //        var unitOfWork = new UnitOfWork(context);
    //        
    //        // act 
    //        using var transaction = unitOfWork.Begin();
    //        var target = await repository.AddAsync(SampleData.Categories[0]);
    //        transaction.Commit();
    //        
    //        // assert
    //        target.Value.ShouldBeType<int>();
    //        target.Value.ShouldEqual(1);
    //    }
    //}
    
    //[Fact]
    //public async Task AddAsync_IfNameExistYet_ShouldBeUnSuccessfully()
    //{
    //    var options = this.CreatePostgreSqlUniqueClassOptions<AppDbContext>();
    //    await using (var context = new AppDbContext(options))
    //    {
    //        // SETUP DB_CONTEXT
    //        context.Database.EnsureDeleted();
    //        context.Database.EnsureCreated();
    //        
    //        // arrange
    //        var repository = new CategoryRepository(context);
    //        var unitOfWork = new UnitOfWork(context);
    //        SampleDataInitializer.Seed(context,SampleData.Categories);
    //        var category = new Category()
    //        {
    //            Code = 1000,
    //            Name = SampleData.Categories[0].Name
    //        };
    //
    //        // act 
    //        using var transaction = unitOfWork.Begin();
    //        var target = await repository.AddAsync(category);
    //        unitOfWork.Commit(transaction);
    //
    //        // assert
    //        target.Value.ShouldBeType<Failure>();
    //        target.AsT0.Code.ShouldBe(CategoryCode.AddFailure.GetCode());
    //        target.AsT0.Message.ShouldBe(CategoryCode.AddFailure.GetMessage());
    //    }
    //}
}