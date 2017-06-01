using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel
{
    public class NotificationMessage
    {
        public NotificationMessage(string message, NotificationMessageType type)
        {
            this.Text = message;
            this.MessageType = type;
        }

        public NotificationMessageType MessageType { get; set; }

        public string Text { get; set; }
    }
}
