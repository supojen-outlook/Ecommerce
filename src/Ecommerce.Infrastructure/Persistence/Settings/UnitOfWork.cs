using System.Data;
using Ecommerce.Application.Interfaces.Database;
using Ecommerce.Domain.Failures;
using Ecommerce.Domain.Kernel.Repositories;
using Ecommerce.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using OneOf;

namespace Ecommerce.Infrastructure.Persistence.Settings;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly AppDbContext _appDbContext;
    private ICategoryRepository _categoryRepository;


    public UnitOfWork(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    /// <summary>
    /// Begin the transaction
    /// </summary>
    /// <param name="level"></param>
    /// <returns></returns>
    public IDbTransaction Begin(IsolationLevel level = IsolationLevel.ReadCommitted)
    {
        var transaction = _appDbContext.Database.BeginTransaction(level);
        return transaction.GetDbTransaction();
    }

    /// <summary>
    /// Commit the transaction 
    /// </summary>
    /// <param name="transaction"></param>
    public void Commit(IDbTransaction transaction)
    {
        try
        {
            transaction.Commit();
        }
        catch (Exception ex)
        {
            // processing - if the error happened when the transaction commiting, rollback
            transaction.Rollback();
        }
    }

    /// <summary>
    /// 基礎類目倉庫
    /// </summary>
    public ICategoryRepository CategoryRepository
    {
        get
        {
            if (_categoryRepository == null)
            {
                _categoryRepository = new CategoryRepository(_appDbContext);
            }
            return _categoryRepository;
        }
    }


    #region 資源釋放
    
    private bool _disposed;

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _appDbContext.Dispose();
            }
        }
        _disposed = true;
    }
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    #endregion
    
}