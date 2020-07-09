using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.offer.product.skuprices.edit
    /// </summary>
    public class AliexpressOfferProductSkupricesEditRequest : BaseTopRequest<Top.Api.Response.AliexpressOfferProductSkupricesEditResponse>
    {
        /// <summary>
        /// 商品id
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// 商品sku与价格映射表。 SKU的价格信息(一个或着多个),格式{"skuid1":price1,"skuid2":price2}； 其中skuid可以通过api.findAeProductById接口中的aeopAeproductSKUs列表中各个sku对象中id字段值进行获取, 没有sku属性的商品其id回传“”值
        /// </summary>
        public string SkuIdPriceMap { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.offer.product.skuprices.edit";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("product_id", this.ProductId);
            parameters.Add("sku_id_price_map", this.SkuIdPriceMap);
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
