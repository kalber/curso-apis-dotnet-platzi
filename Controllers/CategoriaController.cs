using Microsoft.AspNetCore.Mvc;
using WebAPI1.Services;
using WebAPI1.Models;

namespace WebAPI1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriaController : ControllerBase
{
  ICategoriaService categoriaService;

  public CategoriaController(ICategoriaService categoriaService)
  {
    this.categoriaService = categoriaService;
  }

  [HttpGet]
  public IActionResult Get()
  {
    return Ok(categoriaService.Get());
  }

  [HttpPost]
  public IActionResult Post([FromBody]Categoria categoria)
  {
    categoriaService.Save(categoria);
    return Ok();
  }

  [HttpPut("{id}")]
  public IActionResult Put(Guid id, [FromBody]Categoria categoria)
  {
    categoriaService.Update(id, categoria);
    return Ok();
  }

  [HttpDelete("{id}")]
  public IActionResult Delete(Guid id)
  {
    categoriaService.Delete(id);
    return Ok();
  }
}