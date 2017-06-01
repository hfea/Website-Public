using Examine;
using Examine.LuceneEngine.SearchCriteria;
using Examine.Providers;
using Examine.SearchCriteria;
using HFEA.BL.Contracts.Search;
using HFEA.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HFEA.BL.SearchProvider
{
    public class Searcher : IHfeaSearcher
    {
        private const string IdField = "id";
        private const string TitleField = "title";
        private const string BodyField = "body";
        private const string SummaryField = "summary";
        private const string SourceField = "sourceType";

        private readonly BaseSearchProvider searcher = ExamineManager.Instance.SearchProviderCollection[Core.Config.Settings.Search.SearchProvider.Provider];

        public Searcher() { }

        public List<ISearchResultItem> Search(SearchFilters filters)
        {
            List<ISearchResultItem> result = null;
            ISearchResults searchResults;
            ISearchCriteria searchQuery;

            string searchValue = filters?.SearchKeywords;
            
            if (!string.IsNullOrEmpty(searchValue))
            {
                searchValue = searchValue.ToLower().Trim();

                bool isPhraseSearch = searchValue.StartsWith("\"") && searchValue.EndsWith("\"");

                searchValue.Replace("\"", string.Empty);

                var searchCriteria = this.searcher
                    .CreateSearchCriteria(BooleanOperation.Or)
                    .Field(TitleField, searchValue)    
                    .Or().Field(SummaryField, searchValue)                
                    .Or().Field(BodyField, searchValue);

                //// if query is not explicitly set as phrase search then relax search rules. 
                //// we add an "OR" condition: (+bodyText: "left part of search keywords" +bodyText: LastWordIsWildcard*)
                //// this ensures that all words in the search string will be present in the document. The last word will contain a wildcard
                if (!isPhraseSearch)
                {
                    int wordCount = this.WordCount(searchValue);
                    if (wordCount == 1)
                    {
                        searchCriteria = searchCriteria.Or().Field(BodyField, searchValue.MultipleCharacterWildcard());
                    }
                    else if (wordCount > 1)
                    {
                        // construct Lucene search value. calculate left part phrase, add wildcard to the last word
                        int lastSpace = searchValue.LastIndexOf(" ");

                        IExamineValue lastWord = searchValue.Substring(lastSpace).Trim().MultipleCharacterWildcard();
                        IExamineValue leftPart = searchValue.Substring(0, lastSpace).Boost(0.0f);

                        searchCriteria = searchCriteria.Or().GroupedAnd(new string[] { BodyField, BodyField }, new IExamineValue[] { leftPart, lastWord });
                    }
                }

                // Lucene query compiled
                searchQuery = searchCriteria.Compile();                
            }
            else
            {   // retrieve everything
                searchQuery =  this.searcher.CreateSearchCriteria(BooleanOperation.Or).RawQuery("*:*");
            }

            // text search results retrieved
            searchResults = this.searcher.Search(searchQuery);

            if (searchResults != null)
            {
                result = searchResults
                    .Select(x => Mapper.ExamineResultToSearchResultItem(x))
                    .Where(x =>
                        (filters.ContentTagIds.IsNullOrEmpty() || filters.ContentTagIds.All(r => x.Tags != null && x.Tags.Contains(r)))
                        && (filters.ProductTagIds.IsNullOrEmpty() || filters.ProductTagIds.Any(r => x.ProductTags != null && x.ProductTags.Contains(r)))
                        )
                    .ToList();
            }

            return result;
        }

        public bool FindUpdateNodeIdOrGetNewId(CompositeId id, out int result)
        {
            // Consider optimizing this method            
            result = 0;
            bool isNodeFound = false;

            if (id != null && id.IsValid)
            {
                var searchQuery = this.searcher
                    .CreateSearchCriteria(BooleanOperation.And)
                    .Field(SourceField, ((int)id.Source).ToString())
                    .And().Field(IdField, id.ItemId.ToString());

                var searchResults = this.searcher.Search(searchQuery.Compile());
                if (searchResults != null && searchResults.TotalItemCount > 0)
                {
                    var node = searchResults
                        .Select(x => Mapper.ExamineResultToSearchResultItem(x))
                        .FirstOrDefault();

                    // if node is found then return node ID
                    result = node.NodeId;
                    isNodeFound = true;
                }
                else
                {
                    var allSearchCriteria = this.searcher.CreateSearchCriteria(BooleanOperation.Or).RawQuery("*:*");
                    searchResults = this.searcher.Search(allSearchCriteria);

                    if (searchResults != null && searchResults.TotalItemCount > 0)
                    {
                        var allNodes = searchResults
                            .Select(x => Mapper.ExamineResultToSearchResultItem(x))
                            .ToList();

                        result = allNodes.Max(x => x.NodeId) + 1;
                    }
                    else
                    {
                        result = 1;
                    }
                }
            }            

            return isNodeFound;
        }

        private int WordCount(string phrase)
        {
            if (!string.IsNullOrEmpty(phrase))
            {
                phrase = Regex.Replace(phrase, @"[^a-zA-Z0-9\s]+", "");
                return new Regex("\\w+").Matches(phrase).Count;
            }

            return 0;
        }
    }
}
