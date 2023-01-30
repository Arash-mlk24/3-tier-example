using Microsoft.AspNetCore.Mvc;
using ThreeTierApplication.Application;
using ThreeTierApplication.Model.Dtos;

namespace ThreeTierApplication.Controllers;

[ApiController]
[Route("[controller]")]
public class HumanController : ControllerBase
{
    private readonly IHumanUseCase _humanUseCase;

    public HumanController(IHumanUseCase humanUseCase)
    {
        _humanUseCase = humanUseCase;
    }

    [HttpGet("")]
    public async Task<ActionResult<List<HumanDto>>> Get(CancellationToken cancellationToken)
    {
        var humans = await _humanUseCase.GetHumans(cancellationToken);
        return Ok(humans);
    }
}