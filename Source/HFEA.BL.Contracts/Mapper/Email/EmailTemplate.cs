using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.Contracts.Mapper.Email
{
    public class EmailTemplate : BaseCmsContent
    {
        public string To { get; set; }
        public string From { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string EmailBodyHtml { get; set; }
        public string BodyText { get; set; }
        public string EmailSubject { get; set; }
    }
}
