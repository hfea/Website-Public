using System.Collections.Generic;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class CentreProfile
    {
        public int Id { get; set; }
        public string CentreName { get; set; }
        public int CentreType { get; set; }
        public string CentreTypeDescription { get; set; }
        public string CentreEmail { get; set; }
        public string CentrePhone { get; set; }
        public string Website { get; set; }
        public string Fax { get; set; }
        public string ProfileImageUrl { get; set; }
        //public MainAddress MainAddress { get; set; }
    }
}
