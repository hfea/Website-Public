using HFEA.Connector.Contracts.Clients.ReferenceData;
using HFEA.Core.Extensions;
using HFEA.Web.ViewModel.Constants;
using HFEA.Web.ViewModel.PGD;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HFEA.BL.ModelCreators
{
    public class PgdListingModelCreator : IPgdListingModelCreator
    {
        private readonly IReferenceDataReader apiReader;
        private readonly IPgdConditionsCmsReader cmsReader;

        public PgdListingModelCreator(IReferenceDataReader refDataReader, IPgdConditionsCmsReader cmsDataReader)
        {
            if (refDataReader == null) throw new ArgumentNullException("reference data reader is null");
            if (cmsDataReader == null) throw new ArgumentNullException("cms data reader is null");

            this.apiReader = refDataReader;
            this.cmsReader = cmsDataReader;
        }
        
        public PgdListingViewModel GetData(int currentPageId, PgdSearchFilters searchParameters)
        {
            PgdListingViewModel result = new PgdListingViewModel()
            {
                SearchFilters = searchParameters
            };
            
            if (searchParameters != null)
            {
                List<PgdItem> list = new List<PgdItem>();
                if (searchParameters.Status == PgdConstants.Status.Unknown
                    || searchParameters.Status == PgdConstants.Status.Approved)
                {
                    var apiData = this.apiReader.GetPgdConditionsData();
                    if (!apiData.IsNullOrEmpty())
                    {
                        list = apiData
                            .Where(x =>
                                (string.IsNullOrEmpty(searchParameters.OMOIMM) || x.Description.ContainsIgnoreCase(searchParameters.OMOIMM))
                                && (string.IsNullOrEmpty(searchParameters.Condition) || x.Name.ContainsIgnoreCase(searchParameters.Condition)))
                            .Select(x => new PgdItem()
                            {
                                Id = x.Id,
                                Name = x.Name,
                                OMOIMM = x.Description,
                                Status = PgdConstants.Status.Approved
                            })
                            .ToList();
                    }
                }

                if (searchParameters.Status == PgdConstants.Status.Unknown
                    || searchParameters.Status == PgdConstants.Status.AwaitingApproval)
                {
                    var cmsData = this.cmsReader.GetAllConditionByListingPageId(currentPageId);
                    if (!cmsData.IsNullOrEmpty())
                    {
                        var lst = cmsData.Where(x =>
                                (string.IsNullOrEmpty(searchParameters.OMOIMM) || x.OMOIMM.ContainsIgnoreCase(searchParameters.OMOIMM))
                                && (string.IsNullOrEmpty(searchParameters.Condition) || x.Name.ContainsIgnoreCase(searchParameters.Condition)));
                        list.AddRange(lst);                            
                    }
                }    
                
                result.ItemList = list
                    .OrderBy(x => x.Name)
                    .ToPagedList(searchParameters.Page, searchParameters.PageSize);
            }

            return result;
        }
    }
}
