﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.COP
{
    public class COPGroup
    {
        public string GroupName { get; set; }
        public List<COPSection> COPSections { get; set; }
    }
}
