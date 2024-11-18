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

    [HttpPost]
    public IActionResult SimplifyText([FromBody] string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return BadRequest("Input text cannot be empty.");
        }

        var simplifiedText = _simplificationService.Simplify(input);
        return Ok(new { original = input, simplified = simplifiedText });
    }
}