namespace HFEA.BL.Contracts.Search
{ 
    public class CompositeId
    {
        public bool IsValid { get { return this.ItemId > 0 && this.Source != Constants.Search.SearchSource.Unknown; } }
        public Constants.Search.SearchSource Source { get; set; }
        public int ItemId { get; set; }
    }
}
