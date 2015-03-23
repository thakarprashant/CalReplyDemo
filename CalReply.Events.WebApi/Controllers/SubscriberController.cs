using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CalReply.Events.DataContract;
using CalReply.Events.Business;

namespace CalReply.Events.WebApi.Controllers
{
    public class SubscriberController : ApiController
    {
        public HttpResponseMessage Get()
        {
            var subscriberList = new EventSubscriberDetails();
            return Request.CreateResponse<List<CalReplyResponse>>(HttpStatusCode.OK, subscriberList.GetEventSubscriberDetails());
        }


        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }
    }
}
