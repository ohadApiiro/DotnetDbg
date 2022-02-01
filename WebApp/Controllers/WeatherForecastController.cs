using Microsoft.AspNetCore.Mvc;
using WebApp.Security;

namespace WebApp.Controllers;


[ApiController]

[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [AccessTokenScope("")]
    [HttpPost("api")]
    public void Api()
    {
    }
 
    [BaseAuthorize("")]
    [HttpPost("api2")]
    public void Api2()
    {
    }
    
    [HttpPost("api3")]
    public void ApiNoAuth()
    {
    }
}