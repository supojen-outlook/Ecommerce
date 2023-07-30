using Ecommerce.Domain.Base;
using Ecommerce.Domain.Failures.Attributes;

namespace Ecommerce.Domain.Failures;

public class Failure : ValueObjectBase
{
    /// <summary>
    /// 異常狀態編碼
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// 提示訊息
    /// </summary>
    public string Message { get; set; }

    internal Failure() { }
    
    internal Failure(Enum @enum)
    {
        Code = @enum.GetCode();
        Message = @enum.GetMessage();
    }

    /// <summary>
    /// Static Constructor -> 建立 Failure from enum
    /// </summary>
    /// <param name="enum"></param>
    /// <returns></returns>
    public static Failure New(Enum @enum)
    {
        return new Failure(@enum);
    }

    /// <summary>
    /// static Constructor -> 建立 Failure from exception
    /// </summary>
    /// <param name="ex"></param>
    /// <returns></returns>
    public static Failure Exception(Exception ex)
    {
        return new Failure()
        {
            Code = ex.GetType().Name,
            Message = ex.Message
        };
    }
    
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
        yield return Message;
    }
}
