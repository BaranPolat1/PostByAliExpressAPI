using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.redefining.getprintinfo
    /// </summary>
    public class AliexpressLogisticsRedefiningGetprintinfoRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsRedefiningGetprintinfoResponse>
    {
        /// <summary>
        /// internationalLogisticsId is international logistics waybill ID (Required)
        /// </summary>
        public string InternationalLogisticsId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.redefining.getprintinfo";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("international_logistics_id", this.InternationalLogisticsId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("international_logistics_id", this.InternationalLogisticsId);
        }

        #endregion
    }
}
