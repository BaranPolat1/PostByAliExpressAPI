using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.editmutilpleskustocks
    /// </summary>
    public class AliexpressPostproductRedefiningEditmutilpleskustocksRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningEditmutilpleskustocksResponse>
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// SKU的库存信息(一个或着多个),格式{"id":number1,"id":number2}   (number 为要编辑的可售库存数量)
        /// </summary>
        public string SkuStocks { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.editmutilpleskustocks";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("product_id", this.ProductId);
            parameters.Add("sku_stocks", this.SkuStocks);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
