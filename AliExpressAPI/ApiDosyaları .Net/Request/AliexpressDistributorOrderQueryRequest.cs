using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.distributor.order.query
    /// </summary>
    public class AliexpressDistributorOrderQueryRequest : BaseTopRequest<Top.Api.Response.AliexpressDistributorOrderQueryResponse>
    {
        /// <summary>
        /// API请求入参
        /// </summary>
        public string QueryRequest { get; set; }

        public DistributeOrderQueryRequestDomain QueryRequest_ { set { this.QueryRequest = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.distributor.order.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("query_request", this.QueryRequest);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("query_request", this.QueryRequest);
        }

	/// <summary>
/// DistributeOrderQueryRequestDomain Data Structure.
/// </summary>
[Serializable]

public class DistributeOrderQueryRequestDomain : TopObject
{
	        /// <summary>
	        /// 分销订单号
	        /// </summary>
	        [XmlElement("distribute_order_id")]
	        public Nullable<long> DistributeOrderId { get; set; }
	
	        /// <summary>
	        /// 分销订单更新开始时间, 格式: yyyy-MM-dd HH:mm:ss, 如2020-06-10 00:00:00 倘若时间维度未精确到时分秒，故该时间条件筛选不许生效。此入参时间为美国太平洋时间.   若传入交易订单号或分销订单号, 此参数可不传.
	        /// </summary>
	        [XmlElement("modified_time_begin")]
	        public string ModifiedTimeBegin { get; set; }
	
	        /// <summary>
	        /// 分销订单更新结束时间, 格式: yyyy-MM-dd HH:mm:ss, 如2020-06-10 00:00:00 倘若时间维度未精确到时分秒，故该时间条件筛选不许生效。此入参时间为美国太平洋时间.  若传入交易订单号或分销订单号, 此参数可不传.
	        /// </summary>
	        [XmlElement("modified_time_end")]
	        public string ModifiedTimeEnd { get; set; }
	
	        /// <summary>
	        /// 页码, 默认1
	        /// </summary>
	        [XmlElement("page")]
	        public Nullable<long> Page { get; set; }
	
	        /// <summary>
	        /// 分页大小，最大长度50，如果不传或者小于等于0，默认10
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 销售市场, 必填
	        /// </summary>
	        [XmlElement("sale_market")]
	        public string SaleMarket { get; set; }
	
	        /// <summary>
	        /// 销售主单号
	        /// </summary>
	        [XmlElement("sale_order_id")]
	        public Nullable<long> SaleOrderId { get; set; }
}

        #endregion
    }
}
