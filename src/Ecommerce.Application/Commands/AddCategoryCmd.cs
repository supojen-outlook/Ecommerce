using Ecommerce.Application.Interfaces.Database;
using Ecommerce.Domain.Failures;
using Ecommerce.Domain.Kernel;
using Ecommerce.Domain.Kernel.Creation;
using OneOf;
using MediatR;

namespace Ecommerce.Application.Commands;

public class AddCategoryCmd : IRequest<OneOf<Failure,Category>>
{
    public string Name { get; set; }
}

public class AddCategoryHandler : IRequestHandler<AddCategoryCmd, OneOf<Failure, Category>>
{
    private readonly IUnitOfWork _unitOfWork;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="unitOfWork"></param>
    public AddCategoryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<OneOf<Failure, Category>> Handle(AddCategoryCmd request, CancellationToken cancellationToken)
    {
        // description - 
        var builder = new CategoryBuilder();
        builder.SetName(request.Name);
        var result = builder.Build();

        if (result.IsT0)
            return result.AsT0;

        var category = result.AsT1;
        using (var transaction = _unitOfWork.Begin())
        {
            await _unitOfWork.CategoryRepository.AddAsync(category);
            _unitOfWork.Commit(transaction);
        }
        return category;

    }
    
}