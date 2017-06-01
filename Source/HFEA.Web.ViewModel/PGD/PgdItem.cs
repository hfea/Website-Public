using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.PGD
{
    public class PgdItem
    {        
        public int Id { get; set; }
        public string OMOIMM { get; set; }
        public string Name { get; set; }
        public PgdConstants.Status Status { get; set; }

        public string DetailsUrl { get; set; }
    }
}
