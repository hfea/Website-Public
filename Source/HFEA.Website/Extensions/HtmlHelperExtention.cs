using HFEA.Web.Constants;
using HFEA.Web.ViewModel;
using HFEA.Web.ViewModel.CaFC.Model;
using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace HFEA.Web.Extensions
{
    public static class HtmlHelperExtention
    {
        private const string UserMessagePartial = "UserMessage";
        public static MvcHtmlString HfeaNotificationMessageIfAny(this HtmlHelper htmlHelper, string ViewDataKey, NotificationMessageType type)
        {
            MvcHtmlString result = null;

            if (htmlHelper.ViewData[ViewDataKey] != null)
            {
                var message = new NotificationMessage(
                    htmlHelper.ViewData[ViewDataKey].ToString(),
                    type);
                result = htmlHelper.Partial(UserMessagePartial, message);
            }

            return result ?? new MvcHtmlString(string.Empty);
        }

        public static MvcHtmlString HfeaUserMessage(this HtmlHelper htmlHelper, string message, NotificationMessageType type)
        {
            MvcHtmlString result = null;

            if (!string.IsNullOrEmpty(message))
            {
                var notification = new NotificationMessage(message, type);
                result = htmlHelper.Partial(UserMessagePartial, notification);
            }

            return result ?? new MvcHtmlString(string.Empty);
        }
    }
}
