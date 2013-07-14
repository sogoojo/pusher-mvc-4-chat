using System;
using System.Configuration;
using System.Web.Mvc;
using PusherRESTDotNet;

namespace Geekbeing.Pusher.LiveChat.Web.Controllers
{
    public class HomeController : Controller
    {
        private static readonly PusherProvider Provider = new PusherProvider
         (
             ConfigurationManager.AppSettings["pusher_app_id"],
             ConfigurationManager.AppSettings["pusher_key"],
             ConfigurationManager.AppSettings["pusher_secret"]
         );

        public ActionResult Index(string chatMessage, string username)
        {
            var now = DateTime.UtcNow;
            var request = new ObjectPusherRequest(
                "chat_channel",
                "message_received",
                new
                {
                    message = chatMessage,
                    user = username,
                    timestamp = now.ToShortDateString() + " " + now.ToShortTimeString()
                });
            Provider.Trigger(request);
            return View();
        }
    }
}
