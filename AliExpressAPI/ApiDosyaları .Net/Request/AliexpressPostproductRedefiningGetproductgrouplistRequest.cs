using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.getproductgrouplist
    /// </summary>
    public class AliexpressPostproductRedefiningGetproductgrouplistRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningGetproductgrouplistResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.getproductgrouplist";
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
