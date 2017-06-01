using HFEA.Connector.Contracts.CaFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.CaFC
{
    public interface ICaFCSearch
    {
        string GetAllClinicListJSON();

        List<Clinic> GetAllClinicList();

        List<Clinic> GetAllClinicList(int sort);

        List<SearchClinic> GetAllSearchClinicList();

        List<SearchClinic> GetAllSearchClinicList(int sort);

        SearchResults GetClinicList();

        SearchResults GetClinicList(string place, int? distance, char firstChar, List<int> options, int pageSize, int page, int sort);

        SearchFilters GetSearchTerms();
    }
}
