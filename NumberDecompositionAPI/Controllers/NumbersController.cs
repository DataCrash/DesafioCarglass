using Microsoft.AspNetCore.Mvc;

namespace NumberDecompositionAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NumbersController : ControllerBase
{
    [HttpGet("divisors/{number}")]
    public IActionResult GetDivisors(int number)
    {
        if (number <= 0) return BadRequest("O número deve ser maior que zero.");

        var divisors = GetAllDivisors(number);
        var primeDivisors = GetPrimeDivisors(divisors);

        return Ok(new
        {
            Number = number,
            Divisors = divisors,
            PrimeDivisors = primeDivisors
        });
    }

    private static List<int> GetAllDivisors(int number)
    {
        var divisors = new List<int>();
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) divisors.Add(i);
        }
        return divisors;
    }

    private List<int> GetPrimeDivisors(List<int> divisors) => divisors.Where(IsPrime).ToList();

    private bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}