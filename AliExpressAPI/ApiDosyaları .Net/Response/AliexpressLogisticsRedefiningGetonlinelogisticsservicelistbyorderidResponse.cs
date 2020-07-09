using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsRedefiningGetonlinelogisticsservicelistbyorderidResponse.
    /// </summary>
    public class AliexpressLogisticsRedefiningGetonlinelogisticsservicelistbyorderidResponse : TopResponse
    {
        /// <summary>
        /// error description
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// is success
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// result list
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("result")]
        public List<ResultDomain> ResultList { get; set; }

	/// <summary>
/// OtherfeesDomain Data Structure.
/// </summary>
[Serializable]

public class OtherfeesDomain : TopObject
{
	        /// <summary>
	        /// amount
	        /// </summary>
	        [XmlElement("amount")]
	        public long Amount { get; set; }
	
	        /// <summary>
	        /// 费用项code
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// curreny
	        /// </summary>
	        [XmlElement("curreny")]
	        public string Curreny { get; set; }
	
	        /// <summary>
	        /// 费用名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// LogisticServiceDomain Data Structure.
/// </summary>
[Serializable]

public class LogisticServiceDomain : TopObject
{
	        /// <summary>
	        /// 物流服务Code
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 物流服务名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 可用物流服务列表
	        /// </summary>
	        [XmlArray("available_logistic_service_list")]
	        [XmlArrayItem("logistic_service")]
	        public List<LogisticServiceDomain> AvailableLogisticServiceList { get; set; }
	
	        /// <summary>
	        /// 交货地址
	        /// </summary>
	        [XmlElement("delivery_address")]
	        public string DeliveryAddress { get; set; }
	
	        /// <summary>
	        /// 是否国际快递线路
	        /// </summary>
	        [XmlElement("express_logistics_service")]
	        public bool ExpressLogisticsService { get; set; }
	
	        /// <summary>
	        /// 物流方案ID
	        /// </summary>
	        [XmlElement("logistics_service_id")]
	        public string LogisticsServiceId { get; set; }
	
	        /// <summary>
	        /// 物流方案名称
	        /// </summary>
	        [XmlElement("logistics_service_name")]
	        public string LogisticsServiceName { get; set; }
	
	        /// <summary>
	        /// 运输时效
	        /// </summary>
	        [XmlElement("logistics_timeliness")]
	        public string LogisticsTimeliness { get; set; }
	
	        /// <summary>
	        /// 其它费用项
	        /// </summary>
	        [XmlArray("other_fees")]
	        [XmlArrayItem("otherfees")]
	        public List<OtherfeesDomain> OtherFees { get; set; }
	
	        /// <summary>
	        /// 推荐指数
	        /// </summary>
	        [XmlElement("recommend_index")]
	        public long RecommendIndex { get; set; }
	
	        /// <summary>
	        /// 试算结果
	        /// </summary>
	        [XmlElement("trial_result")]
	        public string TrialResult { get; set; }
	
	        /// <summary>
	        /// 仓库中文名称
	        /// </summary>
	        [XmlElement("warehouse_name")]
	        public string WarehouseName { get; set; }
}

    }
}
