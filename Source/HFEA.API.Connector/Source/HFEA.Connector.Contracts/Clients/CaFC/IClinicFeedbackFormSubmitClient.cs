using HFEA.Connector.Contracts.CaFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.CaFC
{
    public interface IClinicFeedbackFormSubmitClient
    {
        bool SetClinicFeedbackAnswers(ClinicFeedback FeedBackAnswers);
    }
}
