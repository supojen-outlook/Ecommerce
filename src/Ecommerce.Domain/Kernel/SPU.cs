namespace Ecommerce.Domain.Kernel;

public class SPU
{
    /// <summary>
    /// Serial Number
    /// </summary>
    public long Id { get; set; }
    
    /// <summary>
    /// 名稱
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string Description { get; set; }
}