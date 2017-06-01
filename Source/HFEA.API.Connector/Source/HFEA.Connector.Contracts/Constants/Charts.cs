using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Constants
{
    public class Charts
    {
        public enum CusumChartControlType
        {
            Unknown = 0,
            UpperLimitControl,
            UpperAlertControl,
            UBKResetItems,
            LBKResetItems,
            UBKItems,
            LBKItems,
            LowerAlertControl,
            LowerLimitControl,
            XAxis,
            YAxis
        }
    }
}
