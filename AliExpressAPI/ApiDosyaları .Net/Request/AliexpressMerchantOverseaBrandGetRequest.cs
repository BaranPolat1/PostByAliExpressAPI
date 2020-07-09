using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.merchant.oversea.brand.get
    /// </summary>
    public class AliexpressMerchantOverseaBrandGetRequest : BaseTopRequest<Top.Api.Response.AliexpressMerchantOverseaBrandGetResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.merchant.oversea.brand.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
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
