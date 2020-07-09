using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsRedefiningListlogisticsserviceResponse.
    /// </summary>
    public class AliexpressLogisticsRedefiningListlogisticsserviceResponse : TopResponse
    {
        /// <summary>
        /// error description
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("aeop_logistics_service_result")]
        public List<AeopLogisticsServiceResultDomain> ResultList { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("result_success")]
        public bool ResultSuccess { get; set; }

	/// <summary>
/// AeopLogisticsServiceResultDomain Data Structure.
/// </summary>
[Serializable]

public class AeopLogisticsServiceResultDomain : TopObject
{
	        /// <summary>
	        /// 展示名称
	        /// </summary>
	        [XmlElement("display_name")]
	        public string DisplayName { get; set; }
	
	        /// <summary>
	        /// 物流公司
	        /// </summary>
	        [XmlElement("logistics_company")]
	        public string LogisticsCompany { get; set; }
	
	        /// <summary>
	        /// 最大处理时间
	        /// </summary>
	        [XmlElement("max_process_day")]
	        public long MaxProcessDay { get; set; }
	
	        /// <summary>
	        /// 最小处理时间
	        /// </summary>
	        [XmlElement("min_process_day")]
	        public long MinProcessDay { get; set; }
	
	        /// <summary>
	        /// 推荐显示排序
	        /// </summary>
	        [XmlElement("recommend_order")]
	        public long RecommendOrder { get; set; }
	
	        /// <summary>
	        /// 物流服务key
	        /// </summary>
	        [XmlElement("service_name")]
	        public string ServiceName { get; set; }
	
	        /// <summary>
	        /// 物流追踪号码校验规则，采用正则表达
	        /// </summary>
	        [XmlElement("tracking_no_regex")]
	        public string TrackingNoRegex { get; set; }
}

    }
}
