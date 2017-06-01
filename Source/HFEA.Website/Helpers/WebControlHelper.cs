using HFEA.Web.ViewModel.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HFEA.Web.Helpers
{
    public class WebControlHelper
    {
        public static List<SelectListItem> GetYearsFilterData(int beginYear, int endYear, int? selectedYear)
        {
            var data = new List<SelectListItem>()
            {
                new SelectListItem() { Text = "All", Value = "", Selected = selectedYear == null }
            };

            if (beginYear > 2000 && endYear <= DateTime.UtcNow.Year && beginYear <= endYear)
            {
                int cnt = beginYear;
                while (cnt <= endYear)
                {
                    data.Add(new SelectListItem() { Text = cnt.ToString(), Value = cnt.ToString(), Selected = selectedYear != null && cnt == selectedYear });
                    cnt++;
                }
            }

            return data;
        }

        public static List<SelectListItem> GetSearchDateFilterData(List<SelectFilterGroup> rawData, string selectedDate)
        {
            List<SelectListItem> data = null;

            if (rawData != null && rawData.Any())
            {
                data = new List<SelectListItem>()
                {
                    new SelectListItem() { Text = "Filter by (all dates)", Value = "", Selected = string.IsNullOrWhiteSpace(selectedDate) }
                };

                foreach (var gr in rawData)
                {
                    var group = new SelectListGroup() { Name = gr.GroupTitle };
                    foreach (var item in gr.FilterItemList)
                    {
                        data.Add(new SelectListItem() { Text = item.Text, Value = item.Value, Group = group, Selected = item.Value == selectedDate });
                    }
                }
            }

            return data;
        }
    }
}
