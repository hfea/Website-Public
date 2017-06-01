using HFEA.Data.Contracts.Readers;
using HFEA.Data.Contracts.Writers;
using HFEA.Web.ViewModel.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.DataWriters
{
    public class PageRatingApiSubmitter : IPageRatingUpdater
    {
        private readonly IPageRatingReader reader;
        private readonly IPageRatingWriter writer;
        public PageRatingApiSubmitter(IPageRatingReader dbReader, IPageRatingWriter dbWriter)
        {
            if (dbReader == null) throw new NullReferenceException("db reader is null");
            if (dbWriter == null) throw new NullReferenceException("db writer is null");

            this.reader = dbReader;
            this.writer = dbWriter;
        }

        public bool AddUpdatePageRating(int pageId, int rating, string identifier)
        {
            bool result = false;
            var found = this.reader.GetPageRatingObject(pageId, identifier);

            if (found != null)
            {
                result = writer.UpdateRecord(found.Id, rating);
            }
            else
            {
                result = writer.AddNewRecord(pageId, rating, identifier);
            }

            return result;
        }
    }
}
