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
            var result = first + second;
            return Ok(result.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("sub/{firstNumber}/{secondNumber}")]
    public IActionResult GetSubtraction(string firstNumber, string secondNumber)
    {
        if (decimal.TryParse(firstNumber, out decimal first) && decimal.TryParse (secondNumber, out decimal second))
        {
            var result = first - second;
            return Ok(result.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("mul/{firstNumber}/{secondNumber}")]
    public IActionResult GetMultiplication(string firstNumber, string secondNumber)
    {
        if(decimal.TryParse(firstNumber, out decimal first) && decimal.TryParse(secondNumber, out decimal second))
        {
            var result = first * second;
            return Ok(result.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("div/{firstNumber}/{secondNumber}")]
    public IActionResult GetDivision(string firstNumber, string secondNumber)
    {
        if(decimal.TryParse(firstNumber, out decimal first) && decimal.TryParse(secondNumber, out decimal second))
        {
            var result = first / second;
            return Ok(result.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("med/{firstNumber}/{secondNumber}")]
    public IActionResult GetMedia(string firstNumber, string secondNumber)
    {
        if(decimal.TryParse(firstNumber, out decimal first) && decimal.TryParse(secondNumber, out decimal second))
        {
            var result = (first + second)/2;
            return Ok(result.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("square-root/{number}")]
    public IActionResult GetSquareRoot(string number)
    {
        if(double.TryParse(number, out double num))
        {
            var result = Math.Sqrt(num);
            return Ok(result.ToString());
        }
        return BadRequest("Invalid Input");
    }
}