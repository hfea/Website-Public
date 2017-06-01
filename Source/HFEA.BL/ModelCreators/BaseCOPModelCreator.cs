using HFEA.Connector.Contracts.Clients.COP;
using HFEA.Connector.Contracts.COP;
using HFEA.Web.ViewModel.COP;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HFEA.BL.ModelCreators
{
    public class BaseCOPModelCreator
    {   
        public BaseCOPModelCreator(ICOPReaderClient client, ICOPUrlResolver linkResolver)
        {
            if (client == null) throw new ArgumentNullException("COP reader client cannot be null");
            if (linkResolver == null) throw new ArgumentNullException("Link resolver cannot be null");
            this.UrlResolver = linkResolver;
            this.CopDataReader = client;
        }

        protected ICOPReaderClient CopDataReader { get; private set; }
        protected ICOPUrlResolver UrlResolver { get; private set; }

        public COPNavigation GetNavigation(string activeSectionId)
        {
            int id;
            if (int.TryParse(activeSectionId, out id))
            {
                return this.GetNavigation(id);
            }

            return this.GetNavigation();
        }

        public COPNavigation GetNavigation(int activeSectionId)
        {
            COPNavigation result = this.GetNavigation();
            result.ActiveSectionId = activeSectionId;

            if (result?.GroupList != null)
            {
                foreach (var group in result.GroupList)
                {
                    if (group.SectionItemList != null 
                        && group.SectionItemList.Any(x => x.SectionId == activeSectionId))
                    {
                        group.IsActive = true;
                        break;
                    }
                }
            }

            return result;
        }

        public COPNavigation GetNavigation()
        {
            COPNavigation result = new COPNavigation();

            COPItem groupData = this.CopDataReader.GetAllGroups();
            if (groupData != null && groupData.COPGroups != null)
            {
                var groups = new List<Web.ViewModel.COP.COPGroup>();
                foreach (var group in groupData.COPGroups)
                {
                    var gr = new Web.ViewModel.COP.COPGroup()
                    {
                        GroupName = group.GroupName
                    };

                    if (group.COPSections != null && group.COPSections.Any())
                    {
                        var sections = group.COPSections.Select(x => new COPSectionItem()
                        {
                            SectionNumber = x.SectionNumber,
                            SectionName = x.SectionName,
                            SectionUrl = this.UrlResolver.GetSectionLink(x.SectionNumberInt)
                        }).ToList();

                        gr.SectionItemList = sections;
                    }

                    groups.Add(gr);
                }

                result.GroupList = groups;
            }

            return result;
        }
    }
}
