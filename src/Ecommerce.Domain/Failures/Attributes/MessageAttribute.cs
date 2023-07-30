namespace Ecommerce.Domain.Failures.Attributes;

[AttributeUsage(AttributeTargets.Field)]
public class MessageAttribute : Attribute
{
    public string Message { get; set; }

    public MessageAttribute(string message)
    {
        Message = message;
    }
}