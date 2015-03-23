using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalReply.Events.DataContract
{
    public class CalReplyResponse
    {
        public int SubscriberCount { get; set; }
        public string CalenderName { get; set; }
        public byte[] ImageByteArray { get; set; }
    }
}
