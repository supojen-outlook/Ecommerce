using Ecommerce.Domain.Failures;
using Microsoft.AspNetCore.Mvc;
using OneOf;

namespace Ecommerce.Presentation.Controllers;

public static class ControllerExtension
{
    public static string AccessToken(this ControllerBase controller)
    {
        var token = controller.Request.Headers["Authorization"].ToString().Split(" ")[1];
        return token;
    }
    
    public static IActionResult Handle<T>(this ControllerBase controller, OneOf<Failure, T> response)
    {
        return response.Match(
            failure => controller.Problem(
                statusCode: 400,
                title: failure.Code,
                detail: failure.Message),
            data => controller.Ok(data));
    }
}