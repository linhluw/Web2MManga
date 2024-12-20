﻿namespace Web2mmanga.ViewModels.Response
{
    public class ProductSearchResponse
    {
        /// <summary>
        /// ID sản phẩm
        /// </summary>
        public string PK_ProductId { get; set; } = string.Empty;

        /// <summary>
        /// Tên sản phẩm
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Url sản phẩm
        /// </summary>
        public string TagName { get; set; } = string.Empty;

        /// <summary>
        /// Ảnh sản phẩm
        /// </summary>
        public string Images { get; set; } = string.Empty;

        /// <summary>
        /// Số lượng
        /// </summary>
        public int Quantity { get; set; } = 0;

        /// <summary>
        /// Giá sản phẩm
        /// </summary>
        public int Price { get; set; } = 0;

        /// <summary>
        /// Chiết khấu % giá
        /// </summary>
        public int Discount { get; set; } = 0;

        /// <summary>
        /// Giá bản
        /// </summary>
        public int Payments { get; set; } = 0;

        /// <summary>
        /// ID nhà xuất bản
        /// </summary>
        public string PublishedName { get; set; } = string.Empty;

        /// <summary>
        /// ID danh mục sản phẩm
        /// </summary>
        public string CategoryName { get; set; } = string.Empty;

        /// <summary>
        /// Ngày phát hành
        /// </summary>
        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Đã bán hết
        /// </summary>
        public bool IsSoldAll { get; set; } = false;

        /// <summary>
        /// Kiểu Type: HOT, TOP, NORMAL
        /// </summary>
        public int IsType { get; set; } = 0;

        /// <summary>
        /// Phiên bản Lim
        /// </summary>
        public bool IsLimited { get; set; } = false;
    }

    public enum EnumIsType
    {
        Normal = 0,
        Hot = 1,
        Top = 2
    }
}
