using HFEA.Connector.Contracts.Clients.COP;
using HFEA.Connector.Contracts.COP;
using HFEA.Web.ViewModel.Constants;
using HFEA.Web.ViewModel.COP;
using System.Collections.Generic;
using System.Linq;

namespace HFEA.BL.ModelCreators
{
    public class COPModelCreator : BaseCOPModelCreator, ICOPModelCreator
    {
        private COPViewModel viewModel;
        
        public COPModelCreator(ICOPReaderClient client, ICOPUrlResolver linkResolver) : base(client, linkResolver)
        {
        }

        public COPViewModel GetViewModel()
        {
            return this.GetViewModel(string.Empty);
        }

        public COPViewModel GetViewModel(string activeSectionId)
        {
            if (this.viewModel == null)
            {
                var res = new COPViewModel();

                int activeSection;
                if (int.TryParse(activeSectionId, out activeSection))
                {
                    res.ActiveSection = this.GetSectionData(activeSection);
                    res.Navigation = this.GetNavigation(activeSection);
                }

                this.viewModel = res;
            }

            return this.viewModel;
        }

        private COPSectionItem GetSectionData(int sectionId)
        {
            COPSectionItem result = null;
            COPItem sectionData = this.CopDataReader.GetSection(sectionId);
            if (sectionData != null && sectionData.COPSections != null && sectionData.COPSections.Any())
            {
                var section = sectionData.COPSections.First();
                result = new COPSectionItem()
                {
                    SectionName = section.SectionName,
                    SectionNumber = section.SectionNumber,
                    ActList = this.GetContentRecursively(section.COPActs),
                    LicenceConditionList = this.GetContentRecursively(section.COPLicenceConditions),
                    GuidanceList = this.GetContentRecursively(section.COPVersionDatas),
                    DirectonsList = this.GetContentFlat(section.COPDirections),
                    COPReferences = this.GetContentFlat(section.COPReferences),
                    FileList = this.GetFileList(sectionData),
                    VersionNo = section.VersionNo
                };
            }

            return result;
        }

        private List<Web.ViewModel.COP.COPFile> GetFileList(COPItem sectionData)
        {
            List<Web.ViewModel.COP.COPFile> result = null;

            result = new List<Web.ViewModel.COP.COPFile>();
            if (sectionData.COPDocument != null && !string.IsNullOrEmpty(sectionData.COPDocument.Url))
            {
                result.Add(this.MapCOPFileObject(sectionData.COPDocument));
            }

            if (sectionData.COPSections != null && sectionData.COPSections.Any(x => x.COPDocument != null))
            {
                var mappedDocs = sectionData.COPSections
                    .Where(x => x.COPDocument != null && !string.IsNullOrEmpty(x.COPDocument.Url))
                    .Select(x => this.MapCOPFileObject(x.COPDocument));

                result.AddRange(mappedDocs);
            }

            return result;
        }

        private Web.ViewModel.COP.COPFile MapCOPFileObject(Connector.Contracts.COP.COPFile data)
        {
            Web.ViewModel.COP.COPFile result = null;

            if (data != null && !string.IsNullOrEmpty(data.Url))
            {
                result = new Web.ViewModel.COP.COPFile()
                {
                    Url = data.Url,
                    Title = data.Title,
                    FileSize = data.FileSize.GetValueOrDefault(),
                    FileType = data.FileType.GetValueOrDefault()
                };
            }

            return result;
        }

        private List<COPContentItem> GetContentRecursively(List<COPContent> contentDataList)
        {
            List<COPContentItem> result = new List<COPContentItem>();
            if (contentDataList != null)
            {
                foreach (var content in contentDataList)
                {
                    var contentItem = this.MapContentItem(content);
                    contentItem.ItemList = this.GetContentRecursively(content.COPVersionDatas);
                    contentItem.NotesList = this.GetContentFlat(content.COPReferences);
                    
                    result.Add(contentItem);
                }
            }

            return result;
        }

        private List<COPContentItem> GetContentFlat(List<COPContent> contentDataList)
        {
            List<COPContentItem> result = null;

            if (contentDataList != null)
            {
                result = contentDataList
                    .Select(x => this.MapContentItem(x))
                    .ToList();
            }

            return result;
        }

        private COPContentItem MapContentItem(COPContent content)
        {
            COPContentItem result = null;

            if (content != null)
            {
                ReferenceData.CopFormatType format = this.GetFormatType(content.FormatType);
                result = new COPContentItem()
                {
                    SectionNumber = content.SectionNumber,
                    Description = content.Description,
                    FormatType = format,
                    Url = this.GetUrlByReferenceType(content.Url, content.SectionNumber, format)
                };
            }

            return result;
        }

        private ReferenceData.CopFormatType GetFormatType(string value)
        {
            ReferenceData.CopFormatType result = value.ToEnumValue<ReferenceData.CopFormatType>();

            return result;
        }

        private string GetUrlByReferenceType(string urlParameter, string sectionId, ReferenceData.CopFormatType linkType)
        {
            string result = string.Empty;

            switch (linkType)
            {
                case ReferenceData.CopFormatType.ReferenceCOP:
                    // link to COP section
                    if (!string.IsNullOrEmpty(sectionId))
                    {
                        result = this.UrlResolver.GetSectionLink(sectionId.ToNullableInt().GetValueOrDefault());
                    }
                    break;
                case ReferenceData.CopFormatType.LicenceCondition:
                    // link to licence condition on the same page 
                    if (!string.IsNullOrEmpty(sectionId))
                    {
                        result = string.Format("#{0}", sectionId);
                    }
                    break;
                default:
                    result = urlParameter;
                    break;
            }

            return result;
        }
    }
}
