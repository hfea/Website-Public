﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.COP
{
    public class COPFile
    {
        public string Url { get; set; }

        public string Title { get; set; }

        public int? FileSize { get; set; }

        public int? FileType { get; set; }
    }
}
