using Nancy;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["friend-letter.html"];
      Get["/travel-photos"] = _ => View["travel-photos.html"];

    }
  }
}
