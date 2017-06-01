using HFEA.Web.ViewModel.CaFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbraco.interfaces;
using umbraco.NodeFactory;
using Umbraco.Web;
using Umbraco.Web.Routing;

namespace HFEA.Web.Helpers
{
    public class CafcProfileUrlHelper : ICafcProfileUrlHelper
    {       
        private INode clinicProfileNode;
        private INode cafcFeedbackNode;
        private INode statsPageNode;

        internal INode ClinicProfileNode
        {
            get
            {
                if (clinicProfileNode == null)
                {
                    clinicProfileNode = new Node(Core.Config.Settings.KeyPages.ClinicProfile);
                }

                return clinicProfileNode;
            }
        }

        internal INode CafcFeedbackNode
        {
            get
            {
                if (cafcFeedbackNode == null)
                {
                    cafcFeedbackNode = new Node(Core.Config.Settings.KeyPages.ClinicProfileFeedback);
                }

                return cafcFeedbackNode;                
            }
        }

        internal INode CafcStatsPageNode
        {
            get
            {
                if (statsPageNode == null)
                {
                    statsPageNode = ClinicProfileNode.GetFirstChildByDocType(Core.Config.Settings.KeyDocTypes.ClinicStatistics);
                }

                return statsPageNode;
            }
        }

        public string GetPageUrl(int clinicId)
        {
            return GetPageUrl(clinicId.ToString());
        }

        public string GetPageUrl(string urlSegmentReplacement)
        {
            return this.ReplaceClinicProfileUrlSegment(urlSegmentReplacement);
        }

        public string GetFeedBackUrl(int clinicId)
        {
            return this.GetFeedBackUrl(clinicId.ToString());
        }

        public string GetFeedBackUrl(string urlSegmentReplacement)
        {
            string url = this.CafcFeedbackNode?.NiceUrl;
            return this.ReplaceClinicProfileUrlSegment(urlSegmentReplacement, url);
        }

        public string GetStatsPageUrl(int clinicId)
        {    
            return this.GetStatsPageUrl(clinicId.ToString());
        }

        public string GetStatsPageUrl(string urlSegmentReplacement)
        {
            var statsPage = ClinicProfileNode.GetFirstChildByDocType(Core.Config.Settings.KeyDocTypes.ClinicStatistics);
            return this.ReplaceClinicProfileUrlSegment(urlSegmentReplacement, statsPage?.NiceUrl);
        }

        private string ReplaceClinicProfileUrlSegment(string urlSegmentReplacement, string genericPageUrl = null)
        {
            string profilePageUrl = ClinicProfileNode.NiceUrl;
            
            string url = string.IsNullOrEmpty(genericPageUrl)
                ? profilePageUrl
                : genericPageUrl;

            string dif = profilePageUrl.Remove(0, ClinicProfileNode.Parent.NiceUrl.Length);
            if (dif.EndsWith("/"))
            {
                dif = dif.Substring(0, dif.Length - 1);
            }

            url = url.Replace(dif, urlSegmentReplacement);

            return url;
        }
    }
}
