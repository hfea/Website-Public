using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.COP
{
    public class COPNavigationViewModel
    {
        public bool HasNavigationData
        {
            get
            {
                return this.Navigation != null && this.Navigation.GroupList != null && this.Navigation.GroupList.Any();
            }
        }

        public COPNavigation Navigation { get; set; }
    }
}
