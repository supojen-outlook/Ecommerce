using System.Diagnostics.CodeAnalysis;

namespace Ecommerce.Domain.Base;

public abstract class AggregateBase<TId> : EntityBase<TId> where TId : notnull
{ }

public abstract class AggregateBase<T1,T2> : EntityBase<T1,T2> 
where T1 : notnull 
where T2 : notnull
{}
