using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.editsingleskuprice
    /// </summary>
    public class AliexpressPostproductRedefiningEditsingleskupriceRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningEditsingleskupriceResponse>
    {
        /// <summary>
        /// 需修改编辑的商品ID
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// 需修改编辑的商品单个SKUID。SKU ID可以通过api.findAeProductById接口中的aeopAeproductSKUs获取单个产品信息中"id"进行获取。 没有SKU属性的商品SKUID回传“<none>”
        /// </summary>
        public string SkuId { get; set; }

        /// <summary>
        /// 修改编辑后的商品价格
        /// </summary>
        public string SkuPrice { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.editsingleskuprice";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("product_id", this.ProductId);
            parameters.Add("sku_id", this.SkuId);
            parameters.Add("sku_price", this.SkuPrice);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("product_id", this.ProductId);
            RequestValidator.ValidateRequired("sku_id", this.SkuId);
            RequestValidator.ValidateRequired("sku_price", this.SkuPrice);
        }

        #endregion
    }
}
