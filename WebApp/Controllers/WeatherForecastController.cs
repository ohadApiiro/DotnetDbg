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
 
    // [AuthorizeAttribute("")]
    // [HttpPost("api2")]
    // public void Api2()
    // {
    // }
}