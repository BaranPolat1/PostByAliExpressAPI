using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.redefining.getonlinelogisticsinfo
    /// </summary>
    public class AliexpressLogisticsRedefiningGetonlinelogisticsinfoRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsRedefiningGetonlinelogisticsinfoResponse>
    {
        /// <summary>
        /// domestic tracking number
        /// </summary>
        public string ChinaLogisticsId { get; set; }

        /// <summary>
        /// current page
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// time in YYYY-MM-dd HH:mm:SS
        /// </summary>
        public string GmtCreateEndStr { get; set; }

        /// <summary>
        /// time in YYYY-MM-dd HH:mm:SS
        /// </summary>
        public string GmtCreateStartStr { get; set; }

        /// <summary>
        /// international tracking number
        /// </summary>
        public string InternationalLogisticsId { get; set; }

        /// <summary>
        /// logistics order id
        /// </summary>
        public Nullable<long> LogisticsOrderId { get; set; }

        /// <summary>
        /// status of the logistics order (INIT, WAIT, PICKUP, PICKUP, WAREHOUSE, WAREHOUSE, REROUTE, WAREHOUSE, WAIT, LOGISTICS, OUT, OUT, SEND, SEND, ORDER, ORDER, CLOSED)
        /// </summary>
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// trade order id
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// page size
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// query express order
        /// </summary>
        public Nullable<bool> QueryExpressOrder { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.redefining.getonlinelogisticsinfo";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("china_logistics_id", this.ChinaLogisticsId);
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("gmt_create_end_str", this.GmtCreateEndStr);
            parameters.Add("gmt_create_start_str", this.GmtCreateStartStr);
            parameters.Add("international_logistics_id", this.InternationalLogisticsId);
            parameters.Add("logistics_order_id", this.LogisticsOrderId);
            parameters.Add("logistics_status", this.LogisticsStatus);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("query_express_order", this.QueryExpressOrder);
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
