using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI1.Models;

public class Tarea
{
  public Guid TareaId { get; set; }
  public Guid CategoriaId { get; set; }
  public string Titulo { get; set; }
  public string Descripcion { get; set; }
  public Prioridad PrioridadTarea { get; set; }
  public DateTime FechaCreacion { get; set; }
  public virtual Categoria Categoria { get; set; }
  public string Resumen { get; set; }

  #pragma warning disable CS8618
  public Tarea() {}
}

public enum Prioridad
{
  Baja,
  Media,
  Alta
}