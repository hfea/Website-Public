using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Data.Contracts.DerivedModels
{
    public class PageRatingStatistics
    {
        public int PageId { get; set; }

        public string Title { get; set; }
        
        public double AverageScore { get; set; }

        public int VoteCount { get; set; }

        public DateTime LastSubmissionDate { get; set; }
    }
}
