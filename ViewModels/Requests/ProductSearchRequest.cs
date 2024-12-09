namespace Web2mmanga.ViewModels.Requests
{
    public class ProductSearchRequest : SimpleCommand
    {
        /// <summary>
        /// ID nhà xuất bản
        /// </summary>
        public string? PublishedId { get; set; }

        /// <summary>
        /// Danh mục sản phẩm
        /// </summary>
        public string? CategoryId { get; set; }

        /// <summary>
        /// Đã bán hết
        /// </summary>
        public bool? IsSoldAll { get; set; }
    }
}
