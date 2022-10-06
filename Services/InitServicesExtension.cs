

namespace WebAPI1.Services;

public static class InitServicesExtension
{
  public static IServiceCollection UseMyServices(this IServiceCollection services)
  {
    services.AddScoped<ICategoriaService, CategoriaService>();
    services.AddScoped<ITareaService, TareaService>();
    return services;
  }
}