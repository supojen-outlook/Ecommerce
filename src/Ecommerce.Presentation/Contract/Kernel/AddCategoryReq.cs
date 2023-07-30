namespace Ecommerce.Presentation.Contract.Kernel;

/// <summary>
/// 新增基礎類目
/// </summary>
public record AddCategoryReq
{
    /// <summary>
    /// 類目名稱
    /// </summary>
    /// <example>電器產品</example>
    public string Name { get; set; }
}