using Ecommerce.Domain.Failures.Attributes;

namespace Ecommerce.Domain.Failures;

/// <summary>
/// 有關於基礎類目的錯誤
/// </summary>
public enum AttributeCode
{
    [Code("Attribute.DuplicatedName")]
    [Message("類目數性名稱重複了")]
    DuplicatedName,
}
