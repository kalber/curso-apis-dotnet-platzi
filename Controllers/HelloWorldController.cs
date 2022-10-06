using Microsoft.AspNetCore.Mvc;

using WebAPI1.Services;

namespace WebAPI1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
  IHelloWorldService helloWorldService;

  public HelloWorldController(IHelloWorldService helloWorldService)
  {
    this.helloWorldService = helloWorldService;
  }

  [HttpGet()]
  public IActionResult Get()
  {
    return Ok(helloWorldService.GetHelloWorld());
  }
}