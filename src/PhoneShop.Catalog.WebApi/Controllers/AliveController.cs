using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PhoneShop.Catalog.WebApi.Controllers;

[Route("[controller]")]
[ApiController]
public class AliveController : ControllerBase
{
    private readonly IConfiguration _configuration;
    public AliveController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            ConnectionStringsMongoDb = _configuration.GetConnectionString("MongoDb"),
            EnvironmentName = System.Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")
        });
    }
}
