using System.Security.Cryptography;

namespace Ecommerce.Domain.Base;

public abstract class EntityBase<TId> : IEquatable<EntityBase<TId>> where TId : notnull
{
    /// <summary>
    /// 標示
    /// </summary>
    public abstract TId Id { get; }
    
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

/// <summary>
/// 當entity的標示是由兩個 properties 所決定時，比如說空間上的一點，是由x和y所決定
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
public abstract class EntityBase<T1, T2> : IEquatable<EntityBase<T1,T2>> 
    where T1 : notnull 
    where  T2 : notnull
{
    /// <summary>
    /// 第一個標示
    /// </summary>
    public abstract T1 Id1 { get; }

    /// <summary>
    /// 第二個標示
    /// </summary>
    public abstract T2 Id2 { get; }


    public bool Equals(EntityBase<T1, T2>? other)
    {
        return Equals((object?) other);
    }

    public override bool Equals(object? obj)
    {
        return obj is EntityBase<T1, T2> entity && (Id1.Equals(entity.Id1) && Id2.Equals(entity.Id2));
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id1, Id2);
    }

    public static bool operator ==(EntityBase<T1, T2> left, EntityBase<T1, T2> right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(EntityBase<T1, T2> left, EntityBase<T1, T2> right)
    {
        return !Equals(left, right);
    }
}