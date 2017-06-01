using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ClinicProfile
{
    public class AbsBillingImage
    { 
        
            public int ImageId { get; set; }
           
            public int ImageTypeId { get; set; }
           
            public string ImageTypeDescription { get; set; }
            
            public byte[] Image { get; set; }
        

    }
}
