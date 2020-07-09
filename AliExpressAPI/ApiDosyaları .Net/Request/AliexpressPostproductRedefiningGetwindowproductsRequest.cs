using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.getwindowproducts
    /// </summary>
    public class AliexpressPostproductRedefiningGetwindowproductsRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningGetwindowproductsResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.getwindowproducts";
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
