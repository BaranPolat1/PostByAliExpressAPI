using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.claimtaobaoproductsapi
    /// </summary>
    public class AliexpressPostproductRedefiningClaimtaobaoproductsapiRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningClaimtaobaoproductsapiResponse>
    {
        /// <summary>
        /// 淘宝或者天猫产品的detail url，url需做代码转译。
        /// </summary>
        public string Url { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.claimtaobaoproductsapi";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("url", this.Url);
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
