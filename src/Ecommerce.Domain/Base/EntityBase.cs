using System.Security.Cryptography;

namespace Ecommerce.Domain.Base;

public abstract class EntityBase<TId> : IEquatable<EntityBase<TId>> where TId : notnull
{
    /// <summary>
    /// 標示
    /// </summary>
    public virtual TId Id { get; }
    
    public override bool Equals(object? obj)
    {
        return obj is EntityBase<TId> entity && Id.Equals(entity.Id);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
    
    public bool Equals(EntityBase<TId>? other)
    {
        return Equals((object?) other);
    }
    
    public static bool operator ==(EntityBase<TId> left, EntityBase<TId> right)
    {
        return Equals(left, right);
    }
    
    public static bool operator !=(EntityBase<TId> left, EntityBase<TId> right)
    {
        return !Equals(left, right);
    }
}
