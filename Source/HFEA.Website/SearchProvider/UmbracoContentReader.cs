using HFEA.BL.Contracts.Search;
using HFEA.Core.Extensions;
using HFEA.Web.ViewModel.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using umbraco.interfaces;
using umbraco.NodeFactory;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Models.EntityBase;
using Umbraco.Web;

namespace HFEA.Web.SearchProvider
{
    public class UmbracoContentReader : IUmbracoContentReader
    {
        private const string Separator = ",";
        private const string TagsRegex = @"\d+(?=[\s|,|\]])";
        private const string TitleField = "pageTitle";
        private const string TagsField = "contentTags";
        private const string ProductTagsField = "productTags";
        private const string SummaryField = "pageSummary";
        private const string UpdateDateField = "updateDate";

        private const string MediaFolderType = "Folder";
        private const string MediaFileType = "File";
        private const string MediaHideField = "excludeFromSearch";
        private const string MediaDescriptionField = "fileDescription";

        private readonly List<string> gridFieldList = new List<string>()
        {
            "topGrid",
            "fullWidthGrid",
            "bottomGrid"
        };

        private readonly List<string> allowedFilesTypes = new List<string>()
        {
            "doc", "docx", "pdf", "txt", "xls", "xlsx", "ppt", "pptx"
        };

        private readonly int startPage = Core.Config.Settings.KeyPages.Homepage;

        private readonly List<string> indexContentFieldList = Core.Config.Settings.Search.IndexedSearchFields.AllStringValues;
        private readonly List<string> indexDocTypeList = Core.Config.Settings.Search.IndexedDocTypes.AllStringValues;

        private readonly ITagsApiModelCreator _tagsReader;

        private List<ContentTag> contentTagList;
        private List<ContentTag> productTagList;

        public UmbracoContentReader(ITagsApiModelCreator tagsReader)
        {
            if (tagsReader == null) throw new ArgumentNullException("Content tags reader is null");
            this._tagsReader = tagsReader;
            contentTagList = tagsReader.GetTagList();
        }

        protected List<ContentTag> ContentTagList { get { return this.contentTagList ?? (this.contentTagList = this._tagsReader.GetTagList()); } }
        protected List<ContentTag> ProductTagList { get { return this.productTagList ?? (this.productTagList = this._tagsReader.GetWebsiteProductTagList()); } }

        public List<ISearchIndexItem> GetValidUmbracoNodeData()
        {
            var result = new List<ISearchIndexItem>();

            var startNode = new Node(startPage);
            this.PopulateValidNodesRecursively(startNode, result);
            this.PopulateFileList(result);
            return result;
        }

        public ISearchIndexItem GetValidUmbracoNodeDataById(int id)
        {
            ISearchIndexItem result = null;

            if (id > 0)
            {
                var node = new Node(id);
                if (node != null && !string.IsNullOrEmpty(node.NodeTypeAlias) && this.indexDocTypeList.Contains(node.NodeTypeAlias))
                {
                    result = this.MapNodeToSearchItem(node);
                }
                else
                {
                    var media = ApplicationContext.Current.Services.MediaService.GetById(id);
                    if (media != null)
                    {
                        result = this.MapMediaToSearchItem(media);
                    }
                }
            }

            return result;
        }

        private string GetValidTagsFromJsonIdArray(string json, List<ContentTag> allValidTags)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(json))
            {
                var matches = Regex.Matches(json, TagsRegex);
                if (matches.Count > 0)
                {
                    List<int> tagsList = new List<int>();
                    foreach (Match match in matches)
                    {
                        int id;
                        if (int.TryParse(match.Value, out id) && allValidTags.Any(x => x.Id == id))
                        {
                            tagsList.Add(allValidTags.FirstOrDefault(x => x.Id == id).Id);
                        }
                    }

                    result = string.Join(Separator, tagsList);
                }
            }

            return result;
        }

        private void PopulateValidNodesRecursively(Node node, List<ISearchIndexItem> list)
        {
            if (node != null && node.Id > 0)
            {
                if (this.indexDocTypeList.Contains(node.NodeTypeAlias))
                {
                    list.Add(this.MapNodeToSearchItem(node));
                }

                var children = node.Children;
                if (children != null && children.Count > 0)
                {
                    foreach (Node child in children)
                    {
                        this.PopulateValidNodesRecursively(child, list);
                    }
                }
            }
        }

        private void PopulateFileList(List<ISearchIndexItem> list)
        {
            var files = this.GetUnfilteredFileList();

            if (files != null)
            {
                foreach (IMedia file in files)
                {
                    var type = file.Properties["umbracoExtension"]?.Value;
                    var isHidden = file.Properties[MediaHideField]?.Value;

                    if (type != null
                        && this.allowedFilesTypes.Any(x =>
                            string.Equals(x, type.ToString(),
                            StringComparison.InvariantCultureIgnoreCase))
                        && (isHidden == null || isHidden.ToString() != "1"))
                    {
                        var item = this.MapMediaToSearchItem(file);

                        list.Add(item);
                    }
                }
            }            
        }

        private List<IMedia> GetUnfilteredFileList()
        {
            var mediaService = ApplicationContext.Current.Services.MediaService;
            var rootMedia = mediaService
                .GetRootMedia()
                .Where(x => x.ContentType.Alias == MediaFileType || x.ContentType.Alias == MediaFolderType)
                .ToList();

            var folders = rootMedia.Where(x => x.ContentType.Alias == MediaFolderType).ToList();

            List<IMedia> files = rootMedia.Where(x => x.ContentType.Alias == MediaFileType).ToList();

            if (!folders.IsNullOrEmpty())
            {
                var descendants = folders
                    .SelectMany(x => mediaService.GetDescendants(x))
                    .Where(x => x.ContentType.Alias == MediaFileType)
                    .ToList();

                files.AddRange(descendants);
            }

            return files;
        }

        private ISearchIndexItem MapMediaToSearchItem(IMedia file)
        {
            var description = file.Properties[MediaDescriptionField]?.Value;
            var contentTags = file.Properties[TagsField]?.Value;
            var productTags = file.Properties[ProductTagsField]?.Value;

            var item = new SearchIndexItem()
            {
                Id = file.Id,
                Title = file.Name,
                Summary = description?.ToString(),
                Body = string.Empty, // TODO PDFs
                SourceType = BL.Contracts.Constants.Search.SearchSource.CMS,
                Tags = this.GetValidTagsFromJsonIdArray(contentTags?.ToString(), this.ContentTagList),
                ProductTags = this.GetValidTagsFromJsonIdArray(productTags?.ToString(), this.ProductTagList),
                PublishDate = file.UpdateDate
            };

            return item;
        }

        private ISearchIndexItem MapNodeToSearchItem(Node node)
        {
            var item = new SearchIndexItem()
            {
                Id = node.Id,
                Title = this.GetPropertyValueOrNull(node, TitleField),
                Summary = this.GetPropertyValueOrNull(node, SummaryField),
                Body = this.GetContentBody(node),
                SourceType = BL.Contracts.Constants.Search.SearchSource.CMS,
                Tags = this.GetValidTagsFromJsonIdArray(this.GetPropertyValueOrNull(node, TagsField), this.ContentTagList),
                ProductTags = this.GetValidTagsFromJsonIdArray(this.GetPropertyValueOrNull(node, ProductTagsField), this.ProductTagList),
                PublishDate = node.UpdateDate
            };

            return item;
        }

        private string GetContentBody(Node node)
        {
            var sb = new StringBuilder();
            foreach (var alias in this.indexContentFieldList)
            {
                var val = this.GetPropertyValueOrNull(node, alias);
                if (val != null)
                {
                    sb.AppendLine(umbraco.library.StripHtml(val));
                }
            }

            return sb.ToString();
        }

        private string GetPropertyValueOrNull(INode node, string property)
        {
            string result = null;
            bool exists;
            IProperty prop;
            if (node != null && (prop = node.GetProperty(property, out exists)) != null && exists)
            {
                if (this.gridFieldList.Contains(prop.Alias))
                {
                    result = this.GetUmbracoGridValue(prop.Value);
                }
                else
                {
                    result = prop.Value;
                }
            }

            return result;
        }

        private string GetUmbracoGridValue(string gridValue)
        {
            string result  = string.Empty;

            if (!string.IsNullOrEmpty(gridValue))
            {
                var value = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.UmbracoGrid.GridContent>(gridValue);

                var contentChunks = value.Sections
                    .SelectMany(x => x.Rows)
                    .SelectMany(x => x.Areas)
                    .SelectMany(x => x.Controls)
                    .Where(x => x.Value != null && !string.IsNullOrEmpty(x.Value.ToString()))
                    .Select(x => x.StringValue);
                
                if (contentChunks != null && contentChunks.Any())
                {
                    result = string.Join(" ", contentChunks);
                }   
            }

            return result;
        }
    }
}
