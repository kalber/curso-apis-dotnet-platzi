
using Microsoft.AspNetCore.Mvc;
using WebAPI1.Services;
using WebAPI1.Models;

namespace WebAPI1.Controllers;
[ApiController]
[Route("api/[controller]")]
public class TareaController : ControllerBase
{
  ITareaService tareaService;

  public TareaController(ITareaService tareaService)
  {
    this.tareaService = tareaService;
  }

  [HttpGet]
  public IActionResult Get()
  {
    return Ok(tareaService.Get());
  }

  [HttpPost]
  public IActionResult Post([FromBody]Tarea tarea)
  {
    tareaService.Save(tarea);
    return Ok();
  }

  [HttpPut("{id}")]
  public IActionResult Put(Guid id, [FromBody]Tarea tarea)
  {
    tareaService.Update(id, tarea);
    return Ok();
  }

  [HttpDelete("{id}")]
  public IActionResult Delete(Guid id)
  {
    tareaService.Delete(id);
    return Ok();
  }
}