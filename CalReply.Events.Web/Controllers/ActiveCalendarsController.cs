using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using CalReply.Events.DataContract;
using CalReply.Events.Web.ViewModels;
using System.Net;

namespace CalReply.Events.Web.Controllers
{
    public class ActiveCalendarsController : Controller
    {
        protected string dashboardUrlBase = "http://localhost:37033/api/Subscriber";

        // GET: ActiveCalendars
        public ActionResult Index()
        {
            var model = new ActiveCalendarIndexViewModel();
            using (var client = new WebClient())
            {
                var jsonresult = JsonConvert.DeserializeObject<List<CalReplyResponse>>(client.DownloadString(dashboardUrlBase));
                foreach (var item in jsonresult)
                {
                    model.ActiveCalendars.Add(new CalReplyResponse()
                    {
                        CalenderName = item.CalenderName,
                        SubscriberCount = item.SubscriberCount,
                        ImageByteArray = item.ImageByteArray
                    });
                }
            }
            return View(model);
        }
        
    }
}