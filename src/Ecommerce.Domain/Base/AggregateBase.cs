using System.Diagnostics.CodeAnalysis;

namespace Ecommerce.Domain.Base;

public abstract class AggregateBase<TId> : EntityBase<TId> where TId : notnull
{ }
