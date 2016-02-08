using Nancy;
using Letter.Objects;
namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables
        {
          Recipient = "Manny",
          Sender = "Andy"
        };
        return View["friend-letter.html", myLetterVariables];
      };
      Get["/travel-photos"] = _ => View["travel-photos.html"];
    }
  }
}
