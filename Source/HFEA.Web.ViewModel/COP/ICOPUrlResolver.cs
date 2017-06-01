using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.COP
{
    public interface ICOPUrlResolver
    {
        string GetSectionLink(int sectionId);
    }
}
