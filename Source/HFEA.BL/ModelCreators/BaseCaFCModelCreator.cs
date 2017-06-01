using HFEA.Connector.Contracts.CaFC;
using HFEA.Web.ViewModel.CaFC.Model;
using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.ModelCreators
{
    public class BaseCaFCModelCreator
    {
        private Dictionary<string, CaFCConstants.ComparableToAverage> StatsCompareDictionary = new Dictionary<string, CaFCConstants.ComparableToAverage>()
        {
            { "Consistent with" , CaFCConstants.ComparableToAverage.Consistent },
            { "Above", CaFCConstants.ComparableToAverage.Above },
            { "Below", CaFCConstants.ComparableToAverage.Below }
        };
        
        protected StatisticsItem GetStatisticsItem(int nationalRate, int clinicRate, int minInterval, int maxInterval, string compareToAvg, int count, string caveat)
        {
            var result = new StatisticsItem()
            {
                Count = count,
                ClinicRate = clinicRate,
                NationalAverage = nationalRate,
                CompareToAverageString = compareToAvg,
                ReliabilityRangeMin = minInterval,
                ReliabilityRangeMax = maxInterval,
                CaveatText = caveat
            };

            if (result.ClinicRate == 0 && result.NationalAverage == 0 && (result.ReliabilityRangeMin == 0 && result.ReliabilityRangeMax == 0))
            {
                result.HideStatItem = true;
            }

            if (!string.IsNullOrEmpty(compareToAvg) && this.StatsCompareDictionary.ContainsKey(compareToAvg))
            {
                result.CompareToAverage = this.StatsCompareDictionary[compareToAvg];
            }

            return result;
        }

        protected List<string> GetAddressLines(MainAddress address)
        {
            if (address != null)
            {
                var addressList = new List<string>()
                    {
                        address.SubDwelling,
                        string.Format("{0} {1}", address.NumberName, address.Street).Trim(),
                        address.Locality,
                        address.Town,
                        address.County,
                        address.Postcode
                    };

                return addressList.Where(x => !string.IsNullOrEmpty(x)).ToList();
            }

            return null;
        }

        protected List<SatelliteClinicInfo> GetAssociatedClinicInfoList(IEnumerable<Link> linkList)
        {
            List<SatelliteClinicInfo> result = null;

            if (linkList != null && linkList.Any())
            {
                result = linkList.Select(x => new SatelliteClinicInfo()
                {
                    CentreName = x.LinkCentreName,
                    AddressLinesList = this.GetAddressLines(x.LinkCentreAddress),
                    CentrePhoneList = this.GetListOfLinesOrNull(x.LinkCentrePhone)
                }).ToList();
            }

            return result;
        }

        protected List<string> GetListOfLinesOrNull(string input)
        {
            List<string> result = null;

            if (!string.IsNullOrEmpty(input))
            {
                result = input
                    .Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            return result;
        }

        protected List<OpenTimeItem> GetOpeningTimesList(List<OpeningTime> dayList)
        {
            List<OpenTimeItem> result = new List<OpenTimeItem>();

            if (dayList != null)
            {
                var monday = dayList.FirstOrDefault(x => x.Day == DayOfWeek.Monday);
                bool isSameMondayToFriday = monday != null
                    && dayList.Where(x => x.Day > DayOfWeek.Monday && x.Day <= DayOfWeek.Friday)
                           .All(x => x.IsOpened == monday.IsOpened
                                    && x.OpenTime == monday.OpenTime
                                    && x.CloseTime == monday.CloseTime);

                if (isSameMondayToFriday)
                {
                    dayList = dayList
                        .Where(x => x.Day == DayOfWeek.Monday || x.Day == DayOfWeek.Saturday || x.Day == DayOfWeek.Sunday)
                        .ToList();
                }


                foreach (OpeningTime day in dayList)
                {
                    result.Add(new OpenTimeItem()
                    {
                        IsOpened = day.IsOpened,
                        OpenTime = day.OpenTime,
                        CloseTime = day.CloseTime,
                        FromDay = day.Day,
                        ToDay = isSameMondayToFriday && day.Day == DayOfWeek.Monday
                                    ? DayOfWeek.Friday
                                    : day.Day
                    });
                }

                // Sort list Monday to Sunday
                result = result
                    .OrderBy(x => x.FromDay == DayOfWeek.Sunday)
                    .ThenBy(x => x.FromDay)
                    .ToList();
            }

            return result;
        }
    }
}
