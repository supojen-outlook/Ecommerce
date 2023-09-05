using Ecommerce.Domain.Failures;
using MediatR;
using OneOf;

namespace Ecommerce.Application.Commands;

/// <summary>
/// Add some comment here
/// </summary>
public class AddAttributeCmd : IRequest<OneOf<Failure>>
{
    /// <summary>
    /// 類目編碼
    /// </summary>
    public long Code { get; set; }

    /// <summary>
    /// 屬性名稱
    /// </summary>
    public string Name { get; set; }
}