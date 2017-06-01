using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace HFEA.BL.Contracts
{
    public interface IEmailSender
    {
        bool Send(Email email);
    }
}
