namespace Ecommerce.Domain.Services;

/// <summary>
/// This is a helper for generating an identity
/// </summary>
public interface IIdentityService
{
    /// <summary>
    /// Get an long integer as an identity 
    /// </summary>
    /// <returns></returns>
    long GetIdentity();
}