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
    public IActionResult Get(string firstNumber, string secondNumber)
    {
        if(decimal.TryParse(firstNumber, out decimal first) && decimal.TryParse(secondNumber, out decimal second))
        {
            var sum = first + second;
            return Ok(sum.ToString());
        }
        return BadRequest("Invalid Input");
    }

}