using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Constants
{
    public class ReferenceData
    {
        public enum DocumentLinkType
        {
            [Description("Website")]
            Website = 0,
            [Description("Portal")]
            Portal,
            [Description("Pdf")]
            Pdf
        }

        public enum DonorGameteWaitingTimesEthnicGroupsEnum
        {
            White = 0,
            Mixed,
            Asian,
            Black,
            OtherEthnicGroups
        }

        /// <summary>
        /// Values must match HFEA.Web.ViewModel.Constants.ReferenceData.CopFormatType
        /// also match
        /// HFEA.CP.Web.ViewModel.Constants.ReferenceData.CopFormatType        
        /// </summary>
        public enum ReferenceLinkType
        { /// DON'T change without changing both solutions as above comment says
            Unknown = 0,
            CodeOfPractice,
            Act,
            LicenceCondition,
            Direction,
            Guidance,
            Interpretation,
            ReferenceChairLetter,
            ReferenceCEOLetter,
            ReferenceOther,
            HeaderGroup,
            Principle,
            ReferenceCOP,
            MandatoryGroup,
            Regulation,
        }
    }
}
