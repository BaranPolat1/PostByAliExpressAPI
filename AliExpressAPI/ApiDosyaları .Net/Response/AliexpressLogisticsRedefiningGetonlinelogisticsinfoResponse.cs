using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsRedefiningGetonlinelogisticsinfoResponse.
    /// </summary>
    public class AliexpressLogisticsRedefiningGetonlinelogisticsinfoResponse : TopResponse
    {
        /// <summary>
        /// current page
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// error desc
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// is success
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("result")]
        public List<ResultDomain> ResultList { get; set; }

        /// <summary>
        /// total page
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

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
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// channelCode
	        /// </summary>
	        [XmlElement("channel_code")]
	        public string ChannelCode { get; set; }
	
	        /// <summary>
	        /// chinaLogisticsType
	        /// </summary>
	        [XmlElement("china_logistics_type")]
	        public string ChinaLogisticsType { get; set; }
	
	        /// <summary>
	        /// internationalLogisticsType
	        /// </summary>
	        [XmlElement("international_logistics_type")]
	        public string InternationalLogisticsType { get; set; }
	
	        /// <summary>
	        /// internationallogisticsId
	        /// </summary>
	        [XmlElement("internationallogistics_id")]
	        public string InternationallogisticsId { get; set; }
	
	        /// <summary>
	        /// logisticsFee
	        /// </summary>
	        [XmlElement("logistics_fee")]
	        public MoneyDomain LogisticsFee { get; set; }
	
	        /// <summary>
	        /// 多币种运费列表
	        /// </summary>
	        [XmlArray("logistics_fee_list")]
	        [XmlArrayItem("money")]
	        public List<MoneyDomain> LogisticsFeeList { get; set; }
	
	        /// <summary>
	        /// 物流服务列表
	        /// </summary>
	        [XmlArray("logistics_service_list")]
	        [XmlArrayItem("logistics_service_dto")]
	        public List<LogisticsServiceDtoDomain> LogisticsServiceList { get; set; }
	
	        /// <summary>
	        /// logisticsStatus
	        /// </summary>
	        [XmlElement("logistics_status")]
	        public string LogisticsStatus { get; set; }
	
	        /// <summary>
	        /// lpNumber
	        /// </summary>
	        [XmlElement("lp_number")]
	        public string LpNumber { get; set; }
	
	        /// <summary>
	        /// onlineLogisticsId
	        /// </summary>
	        [XmlElement("online_logistics_id")]
	        public long OnlineLogisticsId { get; set; }
	
	        /// <summary>
	        /// orderId
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// 解决方案code
	        /// </summary>
	        [XmlElement("solution_code")]
	        public string SolutionCode { get; set; }
}

    }
}
