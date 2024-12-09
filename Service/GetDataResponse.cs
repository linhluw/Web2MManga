using Newtonsoft.Json;
using System.Net;
using Web2mmanga.Common;
using Web2mmanga.Common.Api;
using Web2mmanga.ViewModels.Requests;
using Web2mmanga.ViewModels.Response;

namespace Web2mmanga.Service
{
    public class GetDataResponse
    {
        /// <summary>
        /// Danh sách sản phẩm
        /// </summary>
        /// <param name="rq"></param>
        /// <returns></returns>
        public static async Task<PaginatedItem<ProductSearchResponse>> ProductSearchResponse(ProductSearchRequest rq)
        {
            var respone = new PaginatedItem<ProductSearchResponse>(0, 0, new List<ProductSearchResponse>());
            try
            {
                var url = string.Format(APIAddress.Host + APIAddress.ProductSearch);

                var res = await CallAPI.PostAsync(url, rq);

                if (res.StatusCode == (int)HttpStatusCode.OK && res.Data != null)
                {
                    respone = JsonConvert.DeserializeObject<PaginatedItem<ProductSearchResponse>>(res.Data.ToString());
                }
            }
            catch (Exception ex)
            {
                respone = null;
            }
            return respone;
        }
    }
}
