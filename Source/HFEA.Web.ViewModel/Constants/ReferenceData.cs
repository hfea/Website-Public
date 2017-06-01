using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.Constants
{
    public class ReferenceData
    {
        /// <summary>
        /// Values must match HFEA.Connector.Contracts.Constants.ReferenceData.ReferenceLinkType
        /// </summary>
        public enum CopFormatType
        {
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
            MandatoryGroup
        }
    }
}
