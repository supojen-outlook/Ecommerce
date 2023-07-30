using Ecommerce.Domain.Failures;
using Ecommerce.Domain.Kernel;
using Ecommerce.Domain.Kernel.Repositories;
using Ecommerce.Infrastructure.Failures;
using Ecommerce.Infrastructure.Persistence.Settings;
using EntityFramework.Exceptions.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using OneOf;

namespace Ecommerce.Infrastructure.Persistence.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly AppDbContext _context;

    public CategoryRepository(AppDbContext appDbContext)
    {
        _context = appDbContext;
    }

    /// <summary>
    /// 取得類目
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<OneOf<Failure,Category>> GetAsync(long id)
    { 
        // processing - 
        var category = await _context.Categories.SingleOrDefaultAsync(x => x.Code == id);
        // processing - 
        if (category is null) return Failure.New(CategoryCode.NotExist);
        // processing - 
        return category;
    }
    
    /// <summary>
    /// 新增一比根類目
    /// </summary>
    /// <param name="category"></param>
    public async Task<OneOf<Failure,int>> AddAsync(Category category)
    {
        try
        {
            // Processing - Add the Category
            _context.Categories.Add(category);
            // Processing - Save the change into Database Context
            return await _context.SaveChangesAsync();
        }
        catch (InvalidOperationException)
        {
            return Failure.New(CategoryCode.AddFailure);
        }
        catch (DbUpdateException)
        {
            return Failure.New(CategoryCode.AddFailure);
        }
    }
    

    /// <summary>
    /// 儲存類目改變
    /// </summary>
    /// <param name="category"></param>
    public async Task<OneOf<Failure,int>> UpdateAsync(Category category)
    {
        // Processing - Update the Category (有可能是第一或二或三層)
        _context.Categories.Update(category);
        
        // Processing - Save the change into Database context
        return await _context.SaveChangesAsync();
    }
}