using HFEA.Connector.Contracts.OnlineApps;
using HFEA.Connector.Service.Client.OnlineApps;
using HFEA.Connector.Test.AccessControl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Test
{
    [TestClass]
    // This class doesn't contain unit tests. It is a utility/helper which saves JSON from authenticated API calls 
    // to file system
    public class DataHelper : SDKTestBase
    {
        //[TestMethod]        
        public void GetOnlineAppPage()
        {
            string path = @"c:\Development\JsonData";
            string filename = "onlineAppsPage-13939.json";

            var reader = new OnlineAppsReaderClient(this.TokenResolver, this.Logger);
            Func<ApplicationDocumentControl> client = () => reader.GetNextPage(13939, Guid.NewGuid()).Result; // TODO correct ID. It was: // 182).Result;

            var res = client();

            this.CallApiAndSaveOnce(client, path, filename);
        }

        //[TestMethod]        
        public void GetOnlineAppData()
        {
            string path = @"c:\Development\JsonData";
            string filename = "onlineAppData.json";

            var reader = new OnlineAppsReaderClient(this.TokenResolver, this.Logger);
            Func<UserApplication> client = () => reader.GetUserApplicationByAppId(42).Result;

            this.CallApiAndSaveOnce(client, path, filename);
        }

        //[TestMethod]
        public void GetPageValidationData()
        {
            string path = @"c:\Development\JsonData";
            string filename = "PageValidationData-13939.json";

            var reader = new OnlineAppsReaderClient(this.TokenResolver, this.Logger);
            Func<List<ApplicationDocumentControlValidation>> client = () => reader.GetPageValidation(13939).Result;

            this.CallApiAndSaveOnce(client, path, filename);
        }

        //[TestMethod]
        public void GetAllControlTypes()
        {
            string path = @"c:\Development\JsonData";
            string filename = "onlineAppControls.json";

            Func<List<ApplicationDocumentControl>> client = () => {
                List<ApplicationDocumentControl> allPages = new List<ApplicationDocumentControl>();

                var controls = 
                        this.FlattenBy(this.GetAllPagesList(), x => x.ChildApplicationDocumentControls)
                        .ToList();

                var distinct = controls
                    .GroupBy(x => x.ControlTypeID, 
                            (key, c) => 
                                 c.OrderByDescending(m => m.ChildApplicationDocumentControls.Count())                                 
                                 .First())
                    .OrderBy(x => x.ControlTypeID)
                    .ToList();

                return distinct;
            };

            this.CallApiAndSaveOnce(client, path, filename);
        }

        //[TestMethod]
        public void GetAllControlsWithDependencies()
        {
            string path = @"c:\Development\JsonData";
            string filename = "onlineAppControlsWithDependencies.json";
            

            Func<List<ApplicationDocumentControl>> client = () => {
                List<ApplicationDocumentControl> allPages = new List<ApplicationDocumentControl>();

                var controls =
                        this.FlattenBy(this.GetAllPagesList(), x => x.ChildApplicationDocumentControls)
                            .Where(x => x.ApplicationDocumentControlDependencies != null && x.ApplicationDocumentControlDependencies.Any())
                            .ToList();
                
                return controls;
            };

            this.CallApiAndSaveOnce(client, path, filename);
        }

        //[TestMethod]
        public void GetPagesWithControlsDependencies()
        {
            string path = @"c:\Development\JsonData";
            string filename = "pagesWithControlsDependencies.json";


            Func<List<ApplicationDocumentControl>> client = () => {
                List<ApplicationDocumentControl> allPages = new List<ApplicationDocumentControl>();

                List<Contracts.Constants.OnlineApps.DependencyType> validIds = new List<Contracts.Constants.OnlineApps.DependencyType>()
                    { Contracts.Constants.OnlineApps.DependencyType.Enable, Contracts.Constants.OnlineApps.DependencyType.ToggleEnable };

                var pages = this.GetAllPagesList();
                                
                var result = pages.Where(cur => 
                    cur.ApplicationDocumentControlDependencies.Any(ff => validIds.Contains(ff.DependencyTypeID)) 
                    || this.ContainsInHierarchy<ApplicationDocumentControl>(
                            cur.ChildApplicationDocumentControls,
                            x => x.ChildApplicationDocumentControls,
                            z =>  z.ApplicationDocumentControlDependencies
                        .Any(m=> validIds.Contains(m.DependencyTypeID))))
                    .ToList();

                return result;
            };

            this.CallApiAndSaveOnce(client, path, filename);
        }


        private IEnumerable<T> FlattenBy<T>(IEnumerable<T> e, Func<T, IEnumerable<T>> f)
        {
            return e.SelectMany(c => FlattenBy(f(c), f)).Concat(e);
        }

        public bool ContainsInHierarchy<T>(IEnumerable<T> e, Func<T, IEnumerable<T>> f, Func<T, bool> condition)
        {
            var collection = FlattenBy(e, f);
            return collection.Any(condition);
        }

        private void CallApiAndSaveOnce<T>(Func<T> getData, string path, string filename) where T : new()
        {
            string fullPath = Path.Combine(path, filename);

            if (Directory.Exists(path) && !File.Exists(fullPath))
            {
                this.SaveAsJson(getData(), path, filename);
            }
        }

        private void SaveAsJson<T>(T obj, string path, string filename) where T : new()
        {
            var serialized = JsonConvert.SerializeObject(obj);          

            if (!string.IsNullOrEmpty(serialized) && Directory.Exists(path))
            {
                string fullPath = Path.Combine(path, filename);
                File.WriteAllText(fullPath, serialized);
            }
            else
            {
                throw new ArgumentOutOfRangeException("couldn't save json. some parameters are incorrect");
            }
        }

        private List<ApplicationDocumentControl> GetAllPagesList()
        {
            var reader = new OnlineAppsReaderClient(this.TokenResolver, this.Logger);
            var appIds = new int[] { 2, 18, 42, 45 };

            List<ApplicationDocumentControl> allPages = new List<ApplicationDocumentControl>();

            foreach (int appId in appIds)
            {
                var app = reader.GetUserApplicationByAppId(appId).Result;
                Guid docId = app.UserDocuments.First().UserDocumentID;

                ApplicationDocumentControl curPage = reader.GetFirstPage(docId).Result;
                allPages.Add(curPage);

                bool tryGetNext = true;
                while (tryGetNext)
                {
                    ApplicationDocumentControl newPage = reader.GetNextPage(curPage.ApplicationDocumentControlID, docId).Result;
                    if (curPage.ApplicationDocumentControlID == newPage.ApplicationDocumentControlID)
                    {
                        tryGetNext = false;
                    }
                    else
                    {
                        allPages.Add(newPage);
                    }

                    curPage = newPage;
                }
            }

            return allPages;
        }
    }
}
