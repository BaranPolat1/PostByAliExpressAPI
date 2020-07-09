using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.getwlmailingaddresssnapshotdto
    /// </summary>
    public class AliexpressLogisticsGetwlmailingaddresssnapshotdtoRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsGetwlmailingaddresssnapshotdtoResponse>
    {
        /// <summary>
        /// trade order id
        /// </summary>
        public Nullable<long> TradeOrderId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.getwlmailingaddresssnapshotdto";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("trade_order_id", this.TradeOrderId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("trade_order_id", this.TradeOrderId);
        }

        #endregion
    }
}
