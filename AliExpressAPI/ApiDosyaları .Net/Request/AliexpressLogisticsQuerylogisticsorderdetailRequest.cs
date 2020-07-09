using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.querylogisticsorderdetail
    /// </summary>
    public class AliexpressLogisticsQuerylogisticsorderdetailRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsQuerylogisticsorderdetailResponse>
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 国内运单号
        /// </summary>
        public string DomesticLogisticsNum { get; set; }

        /// <summary>
        /// 起始创建时间
        /// </summary>
        public string GmtCreateEndStr { get; set; }

        /// <summary>
        /// 截止创建时间
        /// </summary>
        public string GmtCreateStartStr { get; set; }

        /// <summary>
        /// 国际运单号
        /// </summary>
        public string InternationalLogisticsNum { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        public Nullable<long> TradeOrderId { get; set; }

        /// <summary>
        /// 物流服务编码
        /// </summary>
        public string WarehouseCarrierService { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.querylogisticsorderdetail";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("domestic_logistics_num", this.DomesticLogisticsNum);
            parameters.Add("gmt_create_end_str", this.GmtCreateEndStr);
            parameters.Add("gmt_create_start_str", this.GmtCreateStartStr);
            parameters.Add("international_logistics_num", this.InternationalLogisticsNum);
            parameters.Add("logistics_status", this.LogisticsStatus);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("trade_order_id", this.TradeOrderId);
            parameters.Add("warehouse_carrier_service", this.WarehouseCarrierService);
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
