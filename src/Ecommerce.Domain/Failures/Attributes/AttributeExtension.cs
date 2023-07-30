using System.Reflection;

namespace Ecommerce.Domain.Failures.Attributes;

public static class AttributeExtension
{
    public static string GetCode(this Enum @enum)
    {
        var attribute = GetAttribute<CodeAttribute>(@enum);
        return attribute.Code;
    }

    public static string GetMessage(this Enum @enum)
    {
        var attribute = GetAttribute<MessageAttribute>(@enum);
        return attribute.Message;
    }

    
    //private static T GetAttribute<T>(Enum @enum) where T : System.Attribute
    //{
    //    var field = @enum.GetType().GetField(@enum.ToString());
    //    if (field is null)
    //        return null;
    //
    //    var attribute = field.GetCustomAttribute(typeof(T), false) as T;
    //    return attribute;
    //}
    
    private static T GetAttribute<T>(Enum @enum) where T : Attribute
    {
        // description - 
        var field = @enum.GetType().GetField(@enum.ToString());
        // description - 
        var attribute = field?.GetCustomAttribute(typeof(T), false) as T;
        // description - 
        if (attribute == null) throw new ArgumentNullException($"There is no ${nameof(T)} attribute for enum ${@enum.ToString()}");
        // output - 
        return attribute;
    }
}