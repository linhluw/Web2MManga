namespace Web2mmanga.Common
{
    public class PaginatedItem<TResponse>
    {
        public PaginatedItem(long totalItems, long totalPages, IReadOnlyList<TResponse> items)
        {
            TotalItems = totalItems;
            TotalPages = totalPages;
            Items = items;
        }

        public long TotalItems { get; }

        public long TotalPages { get; }

        public IReadOnlyList<TResponse> Items { get; }
    }
}
