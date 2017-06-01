using System.Collections.Generic;
namespace HFEA.Connector.Contracts.CaFC
{
    public class LicenceRoles
    {
        public int licenceTypeId { get; set; }
        public string licenceType { get; set; }
        public string projectName { get; set; }
        public string personName { get; set; }
        public string foreName { get; set; }
        public string familyName { get; set; }
        public int roleTypeId { get; set; }
        public string roleType { get; set; }
    }
}
