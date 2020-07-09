using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.redefining.qureywlbdomesticlogisticscompany
    /// </summary>
    public class AliexpressLogisticsRedefiningQureywlbdomesticlogisticscompanyRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsRedefiningQureywlbdomesticlogisticscompanyResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.redefining.qureywlbdomesticlogisticscompany";
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
