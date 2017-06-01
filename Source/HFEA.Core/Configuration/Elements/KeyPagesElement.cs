using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Core.Configuration.Elements
{
    public class KeyPagesElement : ConfigurationElement
    {
        [ConfigurationProperty("clinicProfile")]
        public int ClinicProfile
        {
            get { return int.Parse(this["clinicProfile"].ToString()); }
        }

        [ConfigurationProperty("compareClinics")]
        public int CompareClinics
        {
            get { return int.Parse(this["compareClinics"].ToString()); }
        }
        
        [ConfigurationProperty("homepage")]
        public int Homepage
        {
            get { return int.Parse(this["homepage"].ToString()); }
        }

        [ConfigurationProperty("changesDisapprovalEmail")]
        public int ChangesDisapprovalEmail
        {
            get
            {
                return int.Parse(this["changesDisapprovalEmail"].ToString());
            }
        }

        [ConfigurationProperty("commentSubmissionEmail")]
        public int CommentSubmissionEmail
        {
            get
            {
                return int.Parse(this["commentSubmissionEmail"].ToString());
            }
        }

        [ConfigurationProperty("codeOfPractice")]
        public int CodeOfPractice
        {
            get
            {
                return int.Parse(this["codeOfPractice"].ToString());
            }
        } 

        [ConfigurationProperty("footerSettings")]
        public int FooterSettings
        {
            get { return int.Parse(this["footerSettings"].ToString()); }
        }

        [ConfigurationProperty("search")]
        public int Search
        {
            get { return int.Parse(this["search"].ToString()); }
        }

        [ConfigurationProperty("clinicProfileFeedback")]
        public int ClinicProfileFeedback
        {
            get { return int.Parse(this["clinicProfileFeedback"].ToString()); }
        }
        [ConfigurationProperty("allCentres")]
        public int AllCentres
        {
            get { return int.Parse(this["allCentres"].ToString()); }
        }
        [ConfigurationProperty("clinicResults")]
        public int ClinicResults
        {
            get { return int.Parse(this["clinicResults"].ToString()); }
        }

        [ConfigurationProperty("settings")]
        public int Settings
        {
            get { return int.Parse(this["settings"].ToString()); }
        }
    }
}