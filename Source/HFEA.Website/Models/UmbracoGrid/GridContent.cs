using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Models.UmbracoGrid
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Newtonsoft.Json;
    using System.Web;
    using System.Text.RegularExpressions;

    public class GridContent
    {
        public IList<GridSection> Sections { get; set; }

        public class GridSection
        {
            public int Size { get; set; }

            public IList<GridRow> Rows { get; set; }

            public class GridRow
            {
                public string Name { get; set; }

                public IList<GridArea> Areas { get; set; }

                public class GridArea
                {
                    public IList<GridControl> Controls { get; set; }

                    public class GridControl
                    {
                        public object Value { get; set; }

                        public GridEditor Editor { get; set; }

                        public string StringValue
                        {                            
                            get
                            {
                                string result = string.Empty;

                                if (Value != null)
                                {
                                    switch (Editor.Alias)
                                    {
                                        case "headline":
                                            result = Value.ToString();
                                            break;
                                        case "quote":
                                        case "rte":
                                            result = Value.ToString();
                                            result = Regex.Replace(result, "<.*?>", " ");
                                            result = HttpUtility.HtmlDecode(result);
                                            break;
                                        case "infoBlock": // value.header, value.summary
                                        case "contentSpotlight": // value.header, value.summary, value.linkLabel
                                        case "textAndImageSpotlight": // value.header, value.summary
                                        case "headerAndEditorSpotlight": // value.header, value.summary
                                        case "twoColumnRichTextSpotlight": // value.header, value.summary, value.text
                                        case "framedHeaderAndTextSpotlight": // value.header, value.summary
                                            {
                                                SpotlightContentValue val = JsonConvert.DeserializeObject<SpotlightContentValue>(Value.ToString());
                                                result = string.Format("{0} {1} {2}", val.Header, val.Summary, val.Text).Trim();
                                                result = Regex.Replace(result, "<.*?>", " ");
                                                result = HttpUtility.HtmlDecode(result);
                                                break;
                                            }
                                    }
                                }

                                return result;
                            }
                        }

                        public class GridEditor
                        {
                            public string Alias { get; set; }
                        }
                    }
                }
            }
        }
    }
}
