using Nancy;

namespace Sample
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["friend-letter.html"];

    }
  }
}
