using Ecommerce.Domain.Failures;
using OneOf;

namespace Ecommerce.Domain.Kernel.Repositories;

public interface ICategoryRepository
{
    /// <summary>
    /// 取得類目
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<OneOf<Failure,Category>> GetAsync(long id);
    
    /// <summary>
    /// 新增一比根類目
    /// </summary>
    /// <param name="category"></param>
    Task<OneOf<Failure,int>> AddAsync(Category category);

    /// <summary>
    /// 儲存類目改變
    /// </summary>
    /// <param name="category"></param>
    Task<OneOf<Failure,int>> UpdateAsync(Category category);
}