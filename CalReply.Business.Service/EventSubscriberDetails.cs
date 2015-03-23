using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web;


using CalReply.Events.DataContract;

namespace CalReply.Events.Business
{
    public class EventSubscriberDetails
    {
        public EventSubscriberDetails(){}

        public List<CalReplyResponse> GetEventSubscriberDetails()
        {
            var subscriberList = new List<CalReplyResponse>();

            subscriberList.Add(new CalReplyResponse()
            {
                CalenderName = "Chrisley",
                ImageByteArray = System.IO.File.ReadAllBytes(HttpContext.Current.Server.MapPath("/images/Chrisley_USA.png")),
                SubscriberCount = 1001
            });
            subscriberList.Add(new CalReplyResponse()
            {
                CalenderName = "GraceLand",
                ImageByteArray = System.IO.File.ReadAllBytes(HttpContext.Current.Server.MapPath("/images/GraceLand_USA.png")),
                SubscriberCount = 2025
            });
            subscriberList.Add(new CalReplyResponse()
            {
                CalenderName = "Rush",
                ImageByteArray = System.IO.File.ReadAllBytes(HttpContext.Current.Server.MapPath("/images/Rush_USA.png")),
                SubscriberCount = 3056
            });
            subscriberList.Add(new CalReplyResponse()
            {
                CalenderName = "Covert",
                ImageByteArray = System.IO.File.ReadAllBytes(HttpContext.Current.Server.MapPath("/images/Covert_USA.png")),
                SubscriberCount =7076
            });
            subscriberList.Add(new CalReplyResponse()
            {
                CalenderName = "DIG",
                ImageByteArray = System.IO.File.ReadAllBytes(HttpContext.Current.Server.MapPath("/images/DIG_USA.png")),
                SubscriberCount = 9012
            });


            return subscriberList;
        }

    }
}
