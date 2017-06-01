using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class OpenTimeItem
    {
        public bool IsOpened { get; set; }

        public DayOfWeek FromDay { get; set; }

        public DayOfWeek ToDay { get; set; }

        public string OpenTime { get; set; }

        public string CloseTime { get; set; }
    }
}
