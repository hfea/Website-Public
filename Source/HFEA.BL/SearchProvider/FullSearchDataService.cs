using Examine;
using Examine.LuceneEngine;
using Examine.Providers;
using HFEA.BL.Contracts.Search;
using HFEA.Connector.Global;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HFEA.BL.SearchProvider
{
    public class FullSearchDataService : ISimpleDataService
    {
        private BaseIndexProvider indexer;

        private IHfeaLogger log;
        private IFullSearchDataSourceProvider dataSourceProvider;
        private IHfeaSearcher searcher;

        public FullSearchDataService()
        {
        }

        protected BaseIndexProvider Indexer
        {
            get
            {
                return this.indexer ?? (this.indexer = ExamineManager.Instance.IndexProviderCollection[Core.Config.Settings.Search.SearchProvider.Indexer]);
            }
        }

        protected bool IsSearchServiceInitialized
        {
            get
            {
                return this.dataSourceProvider != null && this.log != null && this.Indexer != null;
            }
        }

        protected bool IsSearcherValid
        {
            get
            {
                return this.searcher != null;
            }
        }

        /// <summary>
        /// Removes an entry in the search index that is related to the post provided by the parameter.
        /// </summary>
        public void DeleteIndex(CompositeId id)
        {
            this.SetSearcher();
            this.SetIndexerAndLogger();
            int foundNodeId;
            if (this.IsSearchServiceInitialized
                && this.IsSearcherValid
                && id.IsValid
                && this.searcher.FindUpdateNodeIdOrGetNewId(id, out foundNodeId))
            {
                try
                {
                    this.Indexer.DeleteFromIndex(foundNodeId.ToString());
                }
                catch (Exception ex)
                {
                    this.log.Error("Cannot delete index for node " + id, ex);
                }
            }
        }

        /// <summary>
        /// Updates an entry in the search index
        /// </summary>
        public void UpdateIndex(CompositeId id)
        {
            this.SetSearcher();
            this.SetIndexerAndLogger();
            if (this.IsSearchServiceInitialized 
                && this.IsSearcherValid
                && id.IsValid)
            {
                var reader = this.dataSourceProvider
                    .AllDataSources.FirstOrDefault(x => x.SourceType == id.Source);
                
                if (reader != null)
                {            
                    var mapped = reader.GetItemById(id.ItemId);
                    if (mapped != null)
                    {
                        string type = Mapper.ConvertSourceTypeToIdString(id.Source);

                        int foundNodeId;
                        this.searcher.FindUpdateNodeIdOrGetNewId(id, out foundNodeId);
                        var examineNode = this.MapToSimpleDataSet(mapped, foundNodeId)
                                .RowData
                                .ToExamineXml(foundNodeId, type);

                        try
                        {
                            this.Indexer.ReIndexNode(examineNode, type);
                        }
                        catch (Exception ex)
                        {
                            this.log.Error(string.Format("Cannot add or update index for node {0}", id), ex);
                        }
                    }
                }
            }                    
        }
        
        /// <summary>
        /// Rebuilds index completely
        /// </summary>        
        public IEnumerable<SimpleDataSet> GetAllData(string indexType)
        {
            
            this.SetIndexerAndLogger();
            
            int cnt = 1;
            var result = new List<SimpleDataSet>();
            if (this.IsSearchServiceInitialized)
            {
                this.log.Info("Index is being rebuilt");
                foreach (var dataSource in this.dataSourceProvider.AllDataSources)
                {
                    try
                    {
                        if (dataSource != null && dataSource.HasData)
                        {
                            this.log.Info("Indexing data from source " + dataSource.SourceType.ToString());
                            foreach (ISearchIndexItem item in dataSource.AllItemsList)
                            {
                                try
                                {
                                    var mapped = this.MapToSimpleDataSet(item, cnt);
                                    result.Add(mapped);
                                    cnt++;
                                }
                                catch (Exception ex)
                                {
                                    this.log.Error("Search indexing exception", ex);
                                }
                            }

                            this.log.Info("Finished indexing data from source " + dataSource.SourceType.ToString());
                            this.log.Info("Items in index " + cnt.ToString());
                        }
                        else
                        {
                            this.log.Warning(string.Format("Datasource {0} has no data", dataSource != null ? dataSource.SourceType.ToString() : string.Empty));
                        }
                    }
                    catch (Exception ex)
                    {
                        this.log.Error("Search datasource error", ex);
                    }
                }

                this.log.Info("Index rebuild process is complete");
            }

            return result;
        }

        private SimpleDataSet MapToSimpleDataSet(ISearchIndexItem doc, int index)
        {
            return
                new SimpleDataSet()
                {
                    NodeDefinition = new IndexedNode()
                    {
                        NodeId = index,
                        Type = Constants.CustomDataString
                    },

                    RowData = Mapper.SearchResultItemToDictionary(doc)
                };
        }

        private void SetIndexerAndLogger()
        {
            if (ServiceLocator.IsLocationProviderSet && this.dataSourceProvider == null && this.log == null)
            {
                this.dataSourceProvider = ServiceLocator.Current.GetInstance<IFullSearchDataSourceProvider>();
                this.log = ServiceLocator.Current.GetInstance<IHfeaLogger>();
            }
        }

        private void SetSearcher()
        {
            if (ServiceLocator.IsLocationProviderSet && this.searcher == null)
            {
                this.searcher = ServiceLocator.Current.GetInstance<IHfeaSearcher>();
            }
        }


        //private string StripHtml(string input)
        //{
        //    if (!string.IsNullOrEmpty(input))
        //    {
        //        input = Regex.Replace(input, @"<[^>]+>|&nbsp;", " ");

        //        if (!string.IsNullOrEmpty(input))
        //        {
        //            return Regex.Replace(input, @"\s{2,}", " ").Trim();
        //        }
        //    }

        //    return string.Empty;
        //}
    }
}
