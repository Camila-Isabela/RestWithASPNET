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
    public IActionResult GetAddition(string firstNumber, string secondNumber)
    {
        if(decimal.TryParse(firstNumber, out decimal first) && decimal.TryParse(secondNumber, out decimal second))
        {
            var sum = first + second;
            return Ok(sum.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("sub/{firstNumber}/{secondNumber}")]
    public IActionResult GetSubtraction(string firstNumber, string secondNumber)
    {
        if (decimal.TryParse(firstNumber, out decimal first) && decimal.TryParse (secondNumber, out decimal second))
        {
            var sub = first - second;
            return Ok(sub.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("mul/{firstNumber}/{secondNumber}")]
    public IActionResult GetMultiplication(string firstNumber, string secondNumber)
    {
        if(decimal.TryParse(firstNumber, out decimal first) && decimal.TryParse(secondNumber, out decimal second))
        {
            var mul = first * second;
            return Ok(mul.ToString());
        }
        return BadRequest("Invalid Input");
    }

}