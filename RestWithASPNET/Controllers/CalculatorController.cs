using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET.Controllers;
[ApiController]
[Route("[controller]")]
public class CalculatorController :ControllerBase
{
    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    [HttpGet("sum/{firstNumber}/{secondNumber}")]
    public IActionResult Get(string firstNumber, string secondnumber)
    {
        return BadRequest("Invalid Input");
    }
}