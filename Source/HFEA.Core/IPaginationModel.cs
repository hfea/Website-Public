namespace HFEA.Core
{
    public interface IPaginationModel
    {
        bool IsValid { get; }
        int Page { get; }
        int PageSize { get; }
        int TotalPages { get; }
        int TotalRecords { get; }
    }
}