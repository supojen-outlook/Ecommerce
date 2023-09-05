using Ecommerce.Application.Commands;
using Ecommerce.Presentation.Contract.Kernel;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;

namespace Ecommerce.Presentation.Controllers;

/// <summary>
/// 
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="mapper"></param>
    public CategoryController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    /// <summary>
    /// 新增基礎類目
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    [OpenApiTag("基礎類目 - 相關")]
    public async Task<IActionResult> AddCategoryAsync([FromBody] AddCategoryReq request)
    {
        var command = _mapper.Map<AddCategoryCommand>(request);
        var response = await _mediator.Send(command);
        return this.Handle(response);
    }
}