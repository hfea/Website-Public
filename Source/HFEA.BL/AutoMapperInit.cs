using AutoMapper;
using HFEA.Connector.Contracts.CaFC;
using HFEA.Web.ViewModel.CaFC.Model;
using HFEA.Web.ViewModel.COP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL
{
    public class AutoMapperInit
    {
        public static void Init()
        {
            Mapper.CreateMap<Connector.Contracts.CaFC.WaitingTimes, Web.ViewModel.CaFC.Model.WaitingTimes>();
            Mapper.CreateMap<Connector.Contracts.CaFC.UserRating, Web.ViewModel.CaFC.Model.UserRating>();
            Mapper.CreateMap<Connector.Contracts.CaFC.PatientExperiences, PatientRatingInfo>();
            
            Mapper.CreateMap<Connector.Contracts.CaFC.LicenceRoles, Web.ViewModel.CaFC.Model.LicenseRoles>();
        }
    }
}
