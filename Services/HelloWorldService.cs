
namespace WebAPI1.Services;
public class HelloWorldService : IHelloWorldService
{
  public string GetHelloWorld()
  {
    return "Hello World!";
  }
}

public interface IHelloWorldService
{
  string GetHelloWorld();
}