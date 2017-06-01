using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class TimeSeries
    {
        private const string Separator = ",";

        public string XAxisLabelListString
        {
            get
            {
                if (this.XAxisLabelList != null)
                {
                    return string.Join(Separator, this.XAxisLabelList);
                }

                return string.Empty;
            }
        }

        public string PregnancyRatesDataString
        {
            get
            {
                if (this.PregnancyRatesDataList != null)
                {
                    return string.Join(Separator, this.PregnancyRatesDataList);
                }

                return null;
            }
        }

        public string MultiRatesDataString
        {
            get
            {
                if (this.MultiRatesDataList != null)
                {
                    return string.Join(Separator, this.MultiRatesDataList);
                }

                return null;
            }
        }

        public List<string> XAxisLabelList { get; set; }

        public List<int> PregnancyRatesDataList { get; set; }

        public List<int> MultiRatesDataList { get; set; }
    }
}
