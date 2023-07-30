using System.Data;
using Ecommerce.Domain.Kernel.Repositories;

namespace Ecommerce.Application.Interfaces.Database;

public interface IUnitOfWork
{
    /// <summary>
    /// Begin the transaction
    /// </summary>
    /// <param name="level"></param>
    /// <returns></returns>
    IDbTransaction Begin(IsolationLevel level = IsolationLevel.ReadCommitted);

    /// <summary>
    /// Commit the transaction 
    /// </summary>
    /// <param name="transaction"></param>
    void Commit(IDbTransaction transaction);

    /// <summary>
    /// 基礎類目倉庫
    /// </summary>
    public ICategoryRepository CategoryRepository { get; }
}