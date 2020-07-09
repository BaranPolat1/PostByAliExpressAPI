using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMarketingStorepromotionsListResponse.
    /// </summary>
    public class AliexpressMarketingStorepromotionsListResponse : TopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 出参集合
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("promotion_simple_info_dto")]
        public List<PromotionSimpleInfoDtoDomain> DataList { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

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
	        /// 活动状态：未开始:NotStarted;进行中:Ongoing;已暂停:Invalid;已结束:Finished;
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
}

    }
}
