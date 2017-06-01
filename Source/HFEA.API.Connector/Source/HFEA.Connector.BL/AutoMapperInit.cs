using AutoMapper;
using HFEA.Connector.Contracts.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Service
{
    public class AutoMapperInit
    {
        public static void Init()
        {
            Mapper.CreateMap<SDK.Model.KnownRole, Security.KnownRole>();
            Mapper.CreateMap<Security.KnownRole, SDK.Model.KnownRole>();

            Mapper.CreateMap<string, OnlineApps.PageMetaType>().ConvertUsing(value =>
            {
                if (Enum.IsDefined(typeof(OnlineApps.PageMetaType), value))
                {
                    return (OnlineApps.PageMetaType)Enum.Parse(typeof(OnlineApps.PageMetaType), value);
                }

                return OnlineApps.PageMetaType.Unknown;
            });

            Mapper.CreateMap<SDK.Model.User, Contracts.Users.User>();
            Mapper.CreateMap<Contracts.Users.User, SDK.Model.User>();

#pragma warning disable 618
            Mapper.CreateMap<SDK.Model.SecurityRole, Contracts.Users.SecurityRole>()
                .ForMember(d => d.Name, opt => opt.MapFrom(src => src.KnownName));

            Mapper.CreateMap<Contracts.Users.SecurityRole, SDK.Model.SecurityRole>()
                .ForMember(d => d.KnownName,
                           opt => opt.MapFrom(src =>
                            src.KnownName == Security.KnownRole.Unknown
                                ? src.Name : src.KnownName));
#pragma warning restore 618
            Mapper.CreateMap<Contracts.Centre.CentrePortal, SDK.Model.CentrePortal>();
            Mapper.CreateMap<Contracts.Centre.Address, SDK.Model.Address>();
            Mapper.CreateMap<Contracts.ClinicProfile.Address, SDK.Model.Address>();
            Mapper.CreateMap<Contracts.Centre.Licence, SDK.Model.Licence>();
            Mapper.CreateMap<Contracts.Centre.Contact, SDK.Model.Contact>();
            Mapper.CreateMap<Contracts.Centre.ImageDetail, SDK.Model.ImageDetail>();
            Mapper.CreateMap<Contracts.Centre.LocationCoordinates, SDK.Model.LocationCoordinates>();
            Mapper.CreateMap<Contracts.Centre.EntityAdditionalInformation, SDK.Model.EntityAdditionalInformation>();
            Mapper.CreateMap<Contracts.Centre.RoleDetail, SDK.Model.RoleDetail>();
            Mapper.CreateMap<Contracts.Centre.UpdateCentreRolePersonContact, SDK.Model.UpdateCentreRolePersonContact>();
            Mapper.CreateMap<Contracts.Centre.InsertCentreRolePersonContact, SDK.Model.InsertCentreRolePersonContact>();
            Mapper.CreateMap<Contracts.Centre.DeactivateCentreRolePersonContact, SDK.Model.DeactivateCentreRolePersonContact>();

            Mapper.CreateMap<SDK.Model.Licence, Contracts.Centre.Licence>();
            Mapper.CreateMap<SDK.Model.RoleDetail, Contracts.Centre.RoleDetail>();

            Mapper.CreateMap<SDK.Model.Application, Contracts.OnlineApps.Application>();
            Mapper.CreateMap<SDK.Model.ApplicationDocumentControl, Contracts.OnlineApps.ApplicationDocumentControl>();
            Mapper.CreateMap<SDK.Model.ApplicationDocumentControlDependency, Contracts.OnlineApps.ApplicationDocumentControlDependency>();
            Mapper.CreateMap<SDK.Model.ApplicationDocumentVersion, Contracts.OnlineApps.ApplicationDocumentVersion>();
            Mapper.CreateMap<SDK.Model.ApplicationDocumentControlValidation, Contracts.OnlineApps.ApplicationDocumentControlValidation>();

            //Mapper.CreateMap<Contracts.OnlineApps.ApplicationDocumentControl, SDK.Model.ApplicationDocumentControl>();
            Mapper.CreateMap<SDK.Model.UserApplication, Contracts.OnlineApps.UserApplication>();
            Mapper.CreateMap<SDK.Model.UserDocument, Contracts.OnlineApps.UserDocument>();
            Mapper.CreateMap<SDK.Model.UserControl, Contracts.OnlineApps.UserControl>();

            Mapper.CreateMap<Contracts.OnlineApps.UserControl, SDK.Model.UserControl>();
        }
    }
}
