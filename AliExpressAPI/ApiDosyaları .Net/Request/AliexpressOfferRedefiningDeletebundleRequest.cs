using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.offer.redefining.deletebundle
    /// </summary>
    public class AliexpressOfferRedefiningDeletebundleRequest : BaseTopRequest<Top.Api.Response.AliexpressOfferRedefiningDeletebundleResponse>
    {
        /// <summary>
        /// 搭配ID
        /// </summary>
        public Nullable<long> BundleId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.offer.redefining.deletebundle";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("bundle_id", this.BundleId);
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
