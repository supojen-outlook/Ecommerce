namespace Ecommerce.Domain.Base;

public abstract class ValueObjectBase : IEquatable<ValueObjectBase>
{
    public abstract IEnumerable<object> GetEqualityComponents();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((ValueObjectBase) obj);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator ==(ValueObjectBase left, ValueObjectBase right)
    {
        return Equals(left, right);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(ValueObjectBase left, ValueObjectBase right)
    {
        return !Equals(left, right);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return GetEqualityComponents().Select(x => x?.GetHashCode() ?? 0).Aggregate((x, y) => x ^ y);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool Equals(ValueObjectBase? other)
    {
        return Equals((object?)other);
    }
}

