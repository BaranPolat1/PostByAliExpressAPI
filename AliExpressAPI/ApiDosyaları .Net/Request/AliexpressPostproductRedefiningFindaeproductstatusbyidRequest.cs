using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.findaeproductstatusbyid
    /// </summary>
    public class AliexpressPostproductRedefiningFindaeproductstatusbyidRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningFindaeproductstatusbyidResponse>
    {
        /// <summary>
        /// 商品ID,每次只能输入一个
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.findaeproductstatusbyid";
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
        }

        #endregion
    }
}
