namespace Ecommerce.Domain.Failures.Attributes;


[AttributeUsage(AttributeTargets.Field)]
public class CodeAttribute : Attribute
{
    public string Code { get; set; }

    public CodeAttribute(string code)
    {
        Code = code;
    }
}