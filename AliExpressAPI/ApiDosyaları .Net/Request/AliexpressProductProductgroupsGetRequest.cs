using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.product.productgroups.get
    /// </summary>
    public class AliexpressProductProductgroupsGetRequest : BaseTopRequest<Top.Api.Response.AliexpressProductProductgroupsGetResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.product.productgroups.get";
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
