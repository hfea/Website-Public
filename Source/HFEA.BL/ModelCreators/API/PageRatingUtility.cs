using HFEA.BL.Contracts.Mapper;
using HFEA.Data.Contracts.Readers;
using HFEA.Web.ViewModel.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Core;
using HFEA.Data.Contracts.DerivedModels;
using HFEA.Data.Contracts.Writers;

namespace HFEA.BL.ModelCreators.API
{
    public class PageRatingUtility : IPageRatingUtility
    {
        private readonly IPageRatingReader dataReader;
        private readonly IMapper mapper;
        private readonly IPageRatingWriter dataWriter;

        public PageRatingUtility(IPageRatingReader ratingDataReader, IMapper contentMapper, IPageRatingWriter ratingDataWriter)
        {
            if (ratingDataReader == null) throw new ArgumentNullException("rating data reader is null");
            if (contentMapper == null) throw new ArgumentNullException("content mapper is null");
            if (ratingDataWriter == null) throw new ArgumentNullException("rating data writer is null");
                        
            this.dataReader = ratingDataReader;
            this.mapper = contentMapper;
            this.dataWriter = ratingDataWriter;
        }

        public PageRatingApiViewModel GetRatingsData(int page, int pageSize, bool mostPopularFirst)
        {
            PageRatingApiViewModel result = null;

            var rawData = this.dataReader.GetAllPageStatistics(mostPopularFirst);
            if (rawData != null && rawData.Any())
            {
                var paginatedRawData = new PagedList<PageRatingStatistics>(rawData, page, pageSize, true);

                List<PageRatingStatsItem> mappedList = new List<PageRatingStatsItem>();               

                foreach(var item in paginatedRawData)
                {
                    var mapped = this.mapper.Map<BaseCmsContent>(item.PageId);
                    mappedList.Add(new PageRatingStatsItem()
                    {
                        Id = item.PageId,
                        Title = !string.IsNullOrEmpty(item.Title) ? item.Title : (mapped?.Name ?? "page not found"),
                        LastVoteDate = item.LastSubmissionDate.ToHFEAShortDateString(),
                        Score = Math.Round(item.AverageScore, 2),
                        Url= mapped?.Url,
                        Votes = item.VoteCount
                    });
                }

                result = new PageRatingApiViewModel()
                {
                    Pages = mappedList,
                    PaginationData = new Web.ViewModel.PaginationModel()
                    {
                        Page = paginatedRawData.Page,
                        PageSize = paginatedRawData.PageSize,
                        TotalRecords = paginatedRawData.TotalRecords
                    }
                };
            }

            return result;
        }

        public bool DeletePageRatings(int pageId)
        {
            bool result = false;
            if (pageId > 0)
            {
                result = this.dataWriter.DeletePageRatings(pageId);
            }

            return result;
        }
    }
}
