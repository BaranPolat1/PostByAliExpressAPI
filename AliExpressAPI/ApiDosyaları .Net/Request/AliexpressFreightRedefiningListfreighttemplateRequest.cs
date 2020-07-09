using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.freight.redefining.listfreighttemplate
    /// </summary>
    public class AliexpressFreightRedefiningListfreighttemplateRequest : BaseTopRequest<Top.Api.Response.AliexpressFreightRedefiningListfreighttemplateResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.freight.redefining.listfreighttemplate";
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
