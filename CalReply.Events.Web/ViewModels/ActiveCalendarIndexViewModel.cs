using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CalReply.Events.DataContract;
namespace CalReply.Events.Web.ViewModels
{
    public class ActiveCalendarIndexViewModel
    {

        public ActiveCalendarIndexViewModel()
        {
            this.ActiveCalendars = new List<CalReplyResponse>();
        }

        public List<CalReplyResponse> ActiveCalendars { get; set; }
    }
}