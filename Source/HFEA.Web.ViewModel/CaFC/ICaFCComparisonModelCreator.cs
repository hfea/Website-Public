﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC
{
    public interface ICaFCComparisonModelCreator
    {
        ComparisonViewModel GetData(params int[] clinicIds);
    }
}
