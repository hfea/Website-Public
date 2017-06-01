using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HFEA.Connector.Contracts.Centre
{
    public class Licence
    {
        //
        // Summary:
        //     End Date
        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }
        //
        // Summary:
        //     License Id
        [JsonProperty("id")]
        public int Id { get; set; }
        //
        // Summary:
        //     Licence Holder
        [JsonProperty("licenceHolder")]
        public string LicenceHolder { get; set; }
        //
        // Summary:
        //     Licence Number Formatted
        [JsonProperty("licenceNoFormatted")]
        public string LicenceNoFormatted { get; set; }
        //
        // Summary:
        //     Licence Type
        [JsonProperty("licenceType")]
        public string LicenceType { get; set; }
        //
        // Summary:
        //     Licence Type ID
        [JsonProperty("licenceTypeID")]
        public int LicenceTypeID { get; set; }
        //
        // Summary:
        //     Person Responsible
        [JsonProperty("personResponsible")]
        public string PersonResponsible { get; set; }
        //
        // Summary:
        //     Role Details
        [JsonProperty("roles")]
        public List<RoleDetail> Roles { get; set; }
        //
        // Summary:
        //     Start Date
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }
        //
        // Summary:
        //     Licenced treatments performed at the centre
        [JsonProperty("treatments")]
        public List<string> Treatments { get; set; }
    }
}
