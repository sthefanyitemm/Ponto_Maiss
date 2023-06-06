using Microsoft.AspNetCore.Mvc;

namespace PontoMais.Controllers; // classe de controlador da api 

[ApiController]
[Route("[api/v1/controller]")]
public class PontoMaisController : ControllerBase
{
    /*private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<PontoMaisController> _logger;

    public PontoMaisController(ILogger<PontoMaisController> logger)
    {
        _logger = logger;
    }
    */

    [HttpGet(Name = "GetPontoMais")]
    public IEnumerable<PontoMais> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new PontoMais
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
           // TemperatureC = Random.Shared.Next(-20, 55),
           // Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
