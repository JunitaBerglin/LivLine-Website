using Microsoft.AspNetCore.Mvc;
using LivLineWeb.Services;

namespace LivLineWeb.Controllers
{
    public class SimplifyController : ControllerBase
    {
        private readonly ISimplificationService _simplificationService;

        public SimplifyController(ISimplificationService simplificationService)
        {
            _simplificationService = simplificationService;
        }

        [HttpPost]
        public IActionResult SimplifyText([FromBody] dynamic body)
        {
            string input = body?.text ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                return BadRequest("Input cannot be null or whitespace.");
            }

            try
            {
                var simplifiedText = _simplificationService.Simplify(input);
                return Ok(new { simplified = simplifiedText });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }

}
