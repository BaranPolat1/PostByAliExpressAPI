using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.photobank.redefining.getphotobankinfo
    /// </summary>
    public class AliexpressPhotobankRedefiningGetphotobankinfoRequest : BaseTopRequest<Top.Api.Response.AliexpressPhotobankRedefiningGetphotobankinfoResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.photobank.redefining.getphotobankinfo";
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
