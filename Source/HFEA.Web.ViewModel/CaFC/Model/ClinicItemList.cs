using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class ClinicItemList 
    {   
        public int Id { get; set; }
        
        public int CentreType { get; set; }
        
        public string CentreName { get; set; }

        public string CentreTypeDescription { get; set; }

        public string CenterTel { get; set; }
        public string CenterTown { get; set; }
        public string CenterProfileUrl { get; set; }
    }
}
