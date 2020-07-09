using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.redefining.getfieldinfoforprint
    /// </summary>
    public class AliexpressLogisticsRedefiningGetfieldinfoforprintRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsRedefiningGetfieldinfoforprintResponse>
    {
        /// <summary>
        /// Logistics Order Number
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// International logistics number
        /// </summary>
        public string InternationalLogisticsId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.redefining.getfieldinfoforprint";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("international_logistics_id", this.InternationalLogisticsId);
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
