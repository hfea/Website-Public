using HFEA.BL.Contracts;
using HFEA.BL.Contracts.EmailTypes;
using HFEA.BL.Contracts.Mapper;
using HFEA.Core.Constants;
using HFEA.Web.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using umbraco.BusinessLogic;
using Umbraco.Core;
using Umbraco.Core.Security;
using Umbraco.Core.Services;
using Umbraco.Web;
using Umbraco.Web.WebApi;

namespace HFEA.Web.Controllers
{
    public class UmbExtendApiController : UmbracoApiController
    {
        private static UserService userService = ApplicationContext.Current.Services.UserService as UserService;
        private static UmbracoHelper umbracoHelper = new UmbracoHelper(UmbracoContext.Current);

        private readonly ChangesDisapprovalEmail _email;
        private readonly IEmailSender sender;

        public UmbExtendApiController(IEmailSender emailSender, IMapper contentMapper)
        {
            this.sender = emailSender;
            this._email = new ChangesDisapprovalEmail(contentMapper);
        }

        [System.Web.Http.HttpGet]
        public List<CMSUser> GetUsers(string pageNode)
        {
            //Get Audit history of the updated page       
            var list = Log.Instance.GetAuditLogItems(Convert.ToInt32(pageNode));

            //Get the last published time of the updated page
            DateTime lastPublishedTime = list.Where(x => x.LogType == LogTypes.Publish).OrderByDescending(x => x.Timestamp).FirstOrDefault().Timestamp;

            var allSendToPublishItems = list.Where(x => (x.Timestamp.CompareTo(lastPublishedTime)) > 0 && x.LogType == LogTypes.SendToPublish).OrderByDescending(x => x.Timestamp);

            var allUsers = allSendToPublishItems.Select(x => x.UserId).Distinct();

            List<CMSUser> myList = new List<CMSUser>();
            foreach (int userId in allUsers)
            {
                var user = userService.GetById(userId);
                if (user != null)
                {
                    myList.Add(new CMSUser(user.Id, user.Name, user.Email));
                }
            }

            return myList;
        }

        public void SendEmail(string comment, string pageNodeId, string receiverId)
        {
            var ticket = new System.Web.HttpContextWrapper(HttpContext.Current).GetUmbracoAuthTicket();

            if (ticket != null)
            {
                var userApprover = userService.GetByUsername(ticket.Name);
                var userReceiver = userService.GetById(Convert.ToInt32(receiverId));

                if (UmbracoConstants.ContentChangeApproverUserTypes.Contains(userApprover.UserType.Alias))
                {
                    Dictionary<string, string> replacements = new Dictionary<string, string>();
                    replacements.Add(EmailerConstants.Reject_Email_Recipient_Name, userReceiver.Name);
                    replacements.Add(EmailerConstants.Reject_Email_Page_Name, umbracoHelper.TypedContent(Convert.ToInt32(pageNodeId)).Name);
                    replacements.Add(EmailerConstants.Reject_Email_Comment, comment);
                    replacements.Add(EmailerConstants.Reject_Email_Approver_Name, userApprover.Name);

                    string baseUrl = Request.RequestUri.Scheme + "://" + Request.RequestUri.Authority;
                    replacements.Add(EmailerConstants.Reject_Email_Page_Url, baseUrl + UmbracoConstants.ContentEditUrl + pageNodeId);

                    this.sender.Send(this._email.GetEmailObject(replacements, userReceiver.Email, userApprover.Email));                    
                }
            }

        }
    }
}