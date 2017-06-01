using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.Contracts
{
    public class Email
    {
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public string CcAddress { get; set; }
        public string BccAddress { get; set; }
        public string Subject { get; set; }
        public string BodyHTML { get; set; }
        public string BodyText { get; set; }
    }
}
