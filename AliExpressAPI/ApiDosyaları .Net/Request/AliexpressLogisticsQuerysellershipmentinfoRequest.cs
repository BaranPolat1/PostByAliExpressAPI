using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.querysellershipmentinfo
    /// </summary>
    public class AliexpressLogisticsQuerysellershipmentinfoRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsQuerysellershipmentinfoResponse>
    {
        /// <summary>
        /// Logistics id
        /// </summary>
        public string LogisticsNo { get; set; }

        /// <summary>
        /// Logistics service name
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Number of suborder in that order
        /// </summary>
        public Nullable<long> SubTradeOrderIndex { get; set; }

        /// <summary>
        /// Trade order id
        /// </summary>
        public Nullable<long> TradeOrderId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.querysellershipmentinfo";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("logistics_no", this.LogisticsNo);
            parameters.Add("service_name", this.ServiceName);
            parameters.Add("sub_trade_order_index", this.SubTradeOrderIndex);
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
