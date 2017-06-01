using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ClinicProfile
{
    public class Licence
    {
        public string Stage { get; set; }
        public string TsrType { get; set; }
        public int Id { get; set; }
        public int CentreId { get; set; }
        public int LicenceTypeId { get; set; }
        public string LicenceType { get; set; }
        public int LicenceNo { get; set; }
        public string LicenceNoFormatted { get; set; }
        public string Issue { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public int StageId { get; set; }
        public int TsrTypeId { get; set; }
        public string Version { get; set; }
        public string OfferResponseDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public List<Role> Roles { get; set; }
    }
}
