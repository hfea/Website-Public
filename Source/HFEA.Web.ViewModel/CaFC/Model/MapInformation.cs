using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class MapInformation
    {
        public string Lat { get; set; }

        public string Long { get; set; }

        public string PinTitle { get; set; }

        public string PinText { get; set; }

        public int Id { get; set; }

        public string ProfileUrl { get; set; }

        public List<MapPinLinkItem> LinkList { get; set; }
    }
}
