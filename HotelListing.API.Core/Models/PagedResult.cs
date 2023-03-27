namespace HotelListing.API.Core.Models
{
    public class PagedResult<T>
    {
        public int TotalCount { get; set; }
        public int PageIndex { get; set; }
        public int RecordsPerPage { get; set; }
        public List<T> Items { get; set; }

    }
}
