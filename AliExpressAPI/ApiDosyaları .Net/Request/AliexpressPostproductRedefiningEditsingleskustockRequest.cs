using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.editsingleskustock
    /// </summary>
    public class AliexpressPostproductRedefiningEditsingleskustockRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningEditsingleskustockResponse>
    {
        /// <summary>
        /// SKU的库存值
        /// </summary>
        public Nullable<long> IpmSkuStock { get; set; }

        /// <summary>
        /// 需修改编辑的商品ID
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// 需修改编辑的商品单个SKUID。SKU ID可以通过api.findAeProductById接口中的aeopAeproductSKUs获取单个产品信息中"id"进行获取。
        /// </summary>
        public string SkuId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.editsingleskustock";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ipm_sku_stock", this.IpmSkuStock);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("sku_id", this.SkuId);
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
