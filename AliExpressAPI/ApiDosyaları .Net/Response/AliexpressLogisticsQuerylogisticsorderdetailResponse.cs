using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsQuerylogisticsorderdetailResponse.
    /// </summary>
    public class AliexpressLogisticsQuerylogisticsorderdetailResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopLogisticsOrderDetailQueryResultDomain Result { get; set; }

	/// <summary>
/// MoneyDomain Data Structure.
/// </summary>
[Serializable]

public class MoneyDomain : TopObject
{
	        /// <summary>
	        /// amount
	        /// </summary>
	        [XmlElement("amount")]
	        public string Amount { get; set; }
	
	        /// <summary>
	        /// cent
	        /// </summary>
	        [XmlElement("cent")]
	        public long Cent { get; set; }
	
	        /// <summary>
	        /// currencyCode
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
}

	/// <summary>
/// LogisticsServiceDtoDomain Data Structure.
/// </summary>
[Serializable]

public class LogisticsServiceDtoDomain : TopObject
{
	        /// <summary>
	        /// 物流服务编码
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 资源编码
	        /// </summary>
	        [XmlElement("resource_code")]
	        public string ResourceCode { get; set; }
}

	/// <summary>
/// AeopLogisticsOrderDetailDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopLogisticsOrderDetailDtoDomain : TopObject
{
	        /// <summary>
	        /// batchId
	        /// </summary>
	        [XmlElement("batch_id")]
	        public string BatchId { get; set; }
	
	        /// <summary>
	        /// 渠道编码
	        /// </summary>
	        [XmlElement("channel_code")]
	        public string ChannelCode { get; set; }
	
	        /// <summary>
	        /// gmtCreate
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 国际运单号
	        /// </summary>
	        [XmlElement("international_logistics_num")]
	        public string InternationalLogisticsNum { get; set; }
	
	        /// <summary>
	        /// 物流服务编码
	        /// </summary>
	        [XmlElement("international_logistics_type")]
	        public string InternationalLogisticsType { get; set; }
	
	        /// <summary>
	        /// 运费
	        /// </summary>
	        [XmlElement("logistics_fee")]
	        public MoneyDomain LogisticsFee { get; set; }
	
	        /// <summary>
	        /// 多币种运费list
	        /// </summary>
	        [XmlArray("logistics_fee_list")]
	        [XmlArrayItem("money")]
	        public List<MoneyDomain> LogisticsFeeList { get; set; }
	
	        /// <summary>
	        /// 物流订单号
	        /// </summary>
	        [XmlElement("logistics_order_id")]
	        public long LogisticsOrderId { get; set; }
	
	        /// <summary>
	        /// 物流服务列表
	        /// </summary>
	        [XmlArray("logistics_service_list")]
	        [XmlArrayItem("logistics_service_dto")]
	        public List<LogisticsServiceDtoDomain> LogisticsServiceList { get; set; }
	
	        /// <summary>
	        /// 物流订单状态
	        /// </summary>
	        [XmlElement("logistics_status")]
	        public string LogisticsStatus { get; set; }
	
	        /// <summary>
	        /// outOrderCode(Lpnumber)
	        /// </summary>
	        [XmlElement("out_order_code")]
	        public string OutOrderCode { get; set; }
	
	        /// <summary>
	        /// 解决方案code
	        /// </summary>
	        [XmlElement("solution_code")]
	        public string SolutionCode { get; set; }
	
	        /// <summary>
	        /// tradeOrderId
	        /// </summary>
	        [XmlElement("trade_order_id")]
	        public long TradeOrderId { get; set; }
}

	/// <summary>
/// AeopLogisticsOrderDetailQueryResultDomain Data Structure.
/// </summary>
[Serializable]

public class AeopLogisticsOrderDetailQueryResultDomain : TopObject
{
	        /// <summary>
	        /// 当前页
	        /// </summary>
	        [XmlElement("current_page")]
	        public long CurrentPage { get; set; }
	
	        /// <summary>
	        /// 错误描述
	        /// </summary>
	        [XmlElement("error_desc")]
	        public string ErrorDesc { get; set; }
	
	        /// <summary>
	        /// result
	        /// </summary>
	        [XmlArray("result_list")]
	        [XmlArrayItem("aeop_logistics_order_detail_dto")]
	        public List<AeopLogisticsOrderDetailDtoDomain> ResultList { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// totalPage
	        /// </summary>
	        [XmlElement("total_page")]
	        public long TotalPage { get; set; }
}

    }
}
