using WebAPI1.Models;
using WebAPI1;

namespace WebAPI1.Services;
public class TareaService : ITareaService
{
  TareasContext context;

  public TareaService(TareasContext context)
  {
    this.context = context;
  }

  public IEnumerable<Tarea> Get()
  {
    return context.Tareas;
  }

  public async Task Save(Tarea tarea)
  {
    context.Add(tarea);
    await context.SaveChangesAsync();
  }

  public async Task Update(Guid id, Tarea tarea)
  {
    var tareaActual = context.Tareas.Find(id);

    if (tareaActual != null)
    {
      tareaActual.CategoriaId = tarea.CategoriaId;
      tareaActual.Descripcion = tarea.Descripcion;
      tareaActual.FechaCreacion = tarea.FechaCreacion;
      tareaActual.PrioridadTarea = tarea.PrioridadTarea;
      tareaActual.Resumen = tarea.Resumen;
      tareaActual.Titulo = tarea.Titulo;
      
      await context.SaveChangesAsync();
    }
  }

  public async Task Delete(Guid id)
  {
    var tareaActual = context.Tareas.Find(id);

    if (tareaActual != null)
    {
      context.Tareas.Remove(tareaActual);
      
      await context.SaveChangesAsync();
    }
  }
}

public interface ITareaService
{
  IEnumerable<Tarea> Get();
  Task Save(Tarea tarea);
  Task Update(Guid id, Tarea tarea);
  Task Delete(Guid id);
}