using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.offlineaeproduct
    /// </summary>
    public class AliexpressPostproductRedefiningOfflineaeproductRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningOfflineaeproductResponse>
    {
        /// <summary>
        /// 需要下架的产品id。多个产品ID用英文分号隔开。
        /// </summary>
        public string ProductIds { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.offlineaeproduct";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("product_ids", this.ProductIds);
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
