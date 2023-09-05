using Ecommerce.Domain.Failures;
using OneOf;
using MediatR;

namespace Ecommerce.Application.Commands;

public class AddChildCategoryCommand : IRequest<OneOf<Failure,bool>>
{
    /// <summary>
    /// 根基礎類目名稱
    /// </summary>
    public string RootCategoryName { get; set; }
    
    /// <summary>
    /// 基礎類目名稱
    /// </summary>
    public string[] Names { get; set; }
}