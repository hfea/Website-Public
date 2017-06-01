using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.BL.Contracts.Mapper;
namespace HFEA.BL.Contracts.Mapper
{
   public class BaseCmsContent : IBaseCmsContent
    {
        public int ID { get; set;}

        public string Name { get; set; }

        public string Url { get; set; }
    }
}
