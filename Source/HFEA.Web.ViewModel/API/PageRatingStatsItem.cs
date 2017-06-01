using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.API
{
    public class PageRatingStatsItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public double Score { get; set; }

        public int Votes { get; set; }

        public string LastVoteDate { get; set; }
    }
}
