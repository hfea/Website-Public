using Examine;
using HFEA.BL.Contracts.Constants;
using HFEA.BL.Contracts.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.SearchProvider
{
    public class Mapper
    {
        private const string IdSeparator = "|";

        internal const string NodeId = "__NodeId";
        internal const string Id = "id";
        internal const string Title = "title";
        internal const string Body = "body";
        internal const string Summary = "summary";
        internal const string Tags = "tags";
        internal const string ProductTags = "productTags";
        internal const string SourceType = "sourceType";
        internal const string PublishDate = "publishDate";

        internal const string DateFormat = "s";

        public static Dictionary<string, string> SearchResultItemToDictionary(ISearchIndexItem data)
        {
            return
                new Dictionary<string, string>()
                {                   
                    { Id, data.Id.ToString() },
                    { Title, data.Title != null ? data.Title : string.Empty },
                    { Body, data.Body != null ? data.Body : string.Empty },
                    { Summary, data.Summary != null ? data.Summary : string.Empty },                    
                    { Tags, data.Tags },
                    { ProductTags, data.ProductTags },
                    { SourceType, ConvertSourceTypeToIdString(data.SourceType) },
                    { PublishDate, data.PublishDate.ToString(DateFormat) }
                };
        }

        public static ISearchResultItem ExamineResultToSearchResultItem(SearchResult searchResult)
        {
            var dic = searchResult.Fields;

            Func<string, string> getDicValueOrEmpty = (key) =>
            {
                if (dic.ContainsKey(key))
                {
                    return dic[key];
                }

                return string.Empty;
            };

            int parsedId;
            int.TryParse(getDicValueOrEmpty(Id), out parsedId);

            int nodeId;
            int.TryParse(getDicValueOrEmpty(NodeId), out nodeId);

            var result = new SearchResultItem()
            {
                NodeId = nodeId,
                Score = searchResult.Score,
                Id = parsedId,
                Title = getDicValueOrEmpty(Title),
                Summary = getDicValueOrEmpty(Summary),
                Body = getDicValueOrEmpty(Body),
                ProductTags = GetIdList(getDicValueOrEmpty(ProductTags)),
                Tags = GetIdList(getDicValueOrEmpty(Tags)),
                SourceType = ConvertIdStringToSourceType(getDicValueOrEmpty(SourceType)),
                PublishDate = getDicValueOrEmpty(PublishDate).ToDateFromIsoString()
            };

            return result;
        }

        public static string ConvertSourceTypeToIdString(Contracts.Constants.Search.SearchSource source)
        {
            return ((int)source).ToString();
        }

        public static Search.SearchSource ConvertIdStringToSourceType(string value)
        {
            Search.SearchSource result = Contracts.Constants.Search.SearchSource.Unknown;

            int id;
            if (int.TryParse(value, out id) && Enum.IsDefined(typeof(Contracts.Constants.Search.SearchSource), id))
            {
                result = (Search.SearchSource)id;
            }

            return result;
        }

        private static List<int> GetIdList(string tagsIdString)
        {
            List<int> result = null;

            if (!string.IsNullOrEmpty(tagsIdString))
            {
                result = tagsIdString.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.ToNullableInt())
                    .Where(x => x != null)
                    .Select(x => x.Value)
                    .ToList();
            }

            return result;
        }
    }
}
