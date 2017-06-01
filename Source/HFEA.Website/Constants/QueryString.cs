using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Constants
{
    public class QueryString
    {
        public enum QueryParams
        {
            Unknown = 0,
            page,
            replyOn,
            oldfirst,
            term,
            tags,
            search,
            type,
            date,
            alpha,
            clinicId,
            source,
            age,
            treatment,
            year,
            omoimm,
            condition,
            status,
            id
        }

        public enum QueryValues
        {
            Unknown = 0,
            yes,
            no,
            success
        }
    }
}
