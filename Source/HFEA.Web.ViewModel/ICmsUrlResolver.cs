using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel
{
    public interface ICmsUrlResolver
    {
        string GetCmsUrlByContentId(int contentId);
    }
}
