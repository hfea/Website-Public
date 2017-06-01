using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC
{
    public interface IClinicFeedbackReader
    {
        ClinicFeedbackViewModel  GetClinicFeedbackQuestions();
        string GetClinicName(int ClinicId);
    }
}
