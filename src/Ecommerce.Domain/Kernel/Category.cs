using Ecommerce.Domain.Base;

namespace Ecommerce.Domain.Kernel;

public class Category : AggregateBase<string>
{
    /// <summary>
    /// 標示
    /// </summary>
    public override string Id => Name;
    
    /// <summary>
    /// 編碼 - 編碼的生成方式之後在想怎麼做
    /// </summary>
    public long Code { get; internal set; }

    /// <summary>
    /// 類目名稱
    /// </summary>
    public string Name { get; internal set; }
    
    /// <summary>
    /// 子類目
    /// </summary>
    public HashSet<Category> Children { get; internal set; }

    /// <summary>
    /// 父類目
    /// </summary>
    public Category Parent { get; internal set; }
    
    /// <summary>
    /// 類目屬性
    /// </summary>
    public HashSet<CategoryAttribute> Attributes { get; internal set; }

    /// <summary>
    /// 類目底下商品
    /// </summary>
    public HashSet<SPU> SPUs { get; set; }
}