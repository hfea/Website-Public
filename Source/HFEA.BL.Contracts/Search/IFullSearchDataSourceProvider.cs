using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.Contracts.Search
{
    public interface IFullSearchDataSourceProvider
    {
        List<ISearchDataSource> AllDataSources { get; }
    }
}
