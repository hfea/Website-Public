using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.Contracts.Mapper
{
    public interface IMapper
    {
        T Map<T>(int nodeId) where T : class, IBaseCmsContent;
    }
}
