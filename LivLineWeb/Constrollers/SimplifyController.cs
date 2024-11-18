using LivLineWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivLineWeb.Controllers;

[ApiController]
[Route("[controller]")]
public class SimplifyController : ControllerBase
{
    private readonly SimplificationService _simplificationService;

    public SimplifyController(SimplificationService simplificationService)
    {
        _simplificationService = simplificationService;
    }

    [HttpGet]
    public string Get(string input)
    {
        return _simplificationService.Simplify(input);
    }
}