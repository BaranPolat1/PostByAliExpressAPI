using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.onlineaeproduct
    /// </summary>
    public class AliexpressPostproductRedefiningOnlineaeproductRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningOnlineaeproductResponse>
    {
        /// <summary>
        /// 需要上架的产品id列表。可输入多个，之前用半角分号分割。
        /// </summary>
        public string ProductIds { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.onlineaeproduct";
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
