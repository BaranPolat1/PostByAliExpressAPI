using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.offer.product.query
    /// </summary>
    public class AliexpressOfferProductQueryRequest : BaseTopRequest<Top.Api.Response.AliexpressOfferProductQueryResponse>
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.offer.product.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("product_id", this.ProductId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("product_id", this.ProductId);
        }

        #endregion
    }
}
