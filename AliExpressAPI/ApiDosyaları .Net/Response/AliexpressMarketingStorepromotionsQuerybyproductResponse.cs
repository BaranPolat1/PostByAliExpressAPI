using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMarketingStorepromotionsQuerybyproductResponse.
    /// </summary>
    public class AliexpressMarketingStorepromotionsQuerybyproductResponse : TopResponse
    {
        /// <summary>
        /// 活动list
        /// </summary>
        [XmlArray("promotion_list")]
        [XmlArrayItem("promotion_simple_info_dto")]
        public List<PromotionSimpleInfoDtoDomain> PromotionList { get; set; }

	/// <summary>
/// PromotionSimpleInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class PromotionSimpleInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// 活动结束时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public string EndTime { get; set; }
	
	        /// <summary>
	        /// 活动ID
	        /// </summary>
	        [XmlElement("promotion_id")]
	        public long PromotionId { get; set; }
	
	        /// <summary>
	        /// 活动名称
	        /// </summary>
	        [XmlElement("promotion_name")]
	        public string PromotionName { get; set; }
	
	        /// <summary>
	        /// 活动开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public string StartTime { get; set; }
	
	        /// <summary>
	        /// 活动状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
}

    }
}
