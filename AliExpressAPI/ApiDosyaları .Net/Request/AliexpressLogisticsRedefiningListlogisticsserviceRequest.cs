using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.redefining.listlogisticsservice
    /// </summary>
    public class AliexpressLogisticsRedefiningListlogisticsserviceRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsRedefiningListlogisticsserviceResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.redefining.listlogisticsservice";
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
