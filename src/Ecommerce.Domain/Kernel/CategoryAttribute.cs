using Ecommerce.Domain.Base;

namespace Ecommerce.Domain.Kernel;

/// <summary>
/// 基礎類目屬性
/// </summary>
public class CategoryAttribute : EntityBase<string>
{
    /// <summary>
    /// 區域標示 
    /// </summary>
    public override string Id => Name;

    /// <summary>
    /// 名稱
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 類目屬性群組名稱
    /// </summary>
    public string Group { get; set; }
}