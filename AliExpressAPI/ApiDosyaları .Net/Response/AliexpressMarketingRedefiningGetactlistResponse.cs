using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMarketingRedefiningGetactlistResponse.
    /// </summary>
    public class AliexpressMarketingRedefiningGetactlistResponse : TopResponse
    {
        /// <summary>
        /// 卖家Coupon活动列表
        /// </summary>
        [XmlElement("result")]
        public SellerCouponActivityListDomain Result { get; set; }

	/// <summary>
/// SellerCouponActivityDomain Data Structure.
/// </summary>
[Serializable]

public class SellerCouponActivityDomain : TopObject
{
	        /// <summary>
	        /// coupon活动结束时间
	        /// </summary>
	        [XmlElement("acquire_end_date")]
	        public string AcquireEndDate { get; set; }
	
	        /// <summary>
	        /// coupon活动开始时间
	        /// </summary>
	        [XmlElement("acquire_start_date")]
	        public string AcquireStartDate { get; set; }
	
	        /// <summary>
	        /// coupon使用限制描述，json表示满多少减多少金额。(denomination：coupon面额(单位：美分); hasUseCondtion：是否有使用条件(y/n); minOrderAmount：coupon使用最小订单金额(单位：美分))
	        /// </summary>
	        [XmlElement("activity_desc")]
	        public string ActivityDesc { get; set; }
	
	        /// <summary>
	        /// 活动名称
	        /// </summary>
	        [XmlElement("activity_name")]
	        public string ActivityName { get; set; }
	
	        /// <summary>
	        /// 消费结束时间
	        /// </summary>
	        [XmlElement("consume_end_date")]
	        public string ConsumeEndDate { get; set; }
	
	        /// <summary>
	        /// 消费开始时间
	        /// </summary>
	        [XmlElement("consume_start_date")]
	        public string ConsumeStartDate { get; set; }
	
	        /// <summary>
	        /// coupon有效期，单位:秒
	        /// </summary>
	        [XmlElement("consume_valid_time")]
	        public long ConsumeValidTime { get; set; }
	
	        /// <summary>
	        /// coupon面额，单位:美分
	        /// </summary>
	        [XmlElement("denomination")]
	        public long Denomination { get; set; }
	
	        /// <summary>
	        /// 扩展属性
	        /// </summary>
	        [XmlElement("ext_attrs")]
	        public string ExtAttrs { get; set; }
	
	        /// <summary>
	        /// 是否有使用条件
	        /// </summary>
	        [XmlElement("has_use_condtion")]
	        public bool HasUseCondtion { get; set; }
	
	        /// <summary>
	        /// coupon活动ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 订单使用最小金额，单位:美分
	        /// </summary>
	        [XmlElement("min_order_amount")]
	        public long MinOrderAmount { get; set; }
	
	        /// <summary>
	        /// 每买家限领张数
	        /// </summary>
	        [XmlElement("num_per_buyer")]
	        public long NumPerBuyer { get; set; }
	
	        /// <summary>
	        /// 定向类型
	        /// </summary>
	        [XmlElement("range_type")]
	        public long RangeType { get; set; }
	
	        /// <summary>
	        /// 已发行数量
	        /// </summary>
	        [XmlElement("released_num")]
	        public long ReleasedNum { get; set; }
	
	        /// <summary>
	        /// 卖家主帐号seq
	        /// </summary>
	        [XmlElement("seller_admin_id")]
	        public long SellerAdminId { get; set; }
	
	        /// <summary>
	        /// 活动状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 总共发行数量
	        /// </summary>
	        [XmlElement("total_release_num")]
	        public long TotalReleaseNum { get; set; }
	
	        /// <summary>
	        /// 活动类型
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
}

	/// <summary>
/// SellerCouponActivityListDomain Data Structure.
/// </summary>
[Serializable]

public class SellerCouponActivityListDomain : TopObject
{
	        /// <summary>
	        /// 活动列表
	        /// </summary>
	        [XmlArray("activity_list")]
	        [XmlArrayItem("seller_coupon_activity")]
	        public List<SellerCouponActivityDomain> ActivityList { get; set; }
	
	        /// <summary>
	        /// 当前页面
	        /// </summary>
	        [XmlElement("current_page")]
	        public long CurrentPage { get; set; }
	
	        /// <summary>
	        /// 每页展示记录数
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// 活动总数
	        /// </summary>
	        [XmlElement("total_item")]
	        public long TotalItem { get; set; }
	
	        /// <summary>
	        /// 总页面
	        /// </summary>
	        [XmlElement("total_page")]
	        public long TotalPage { get; set; }
}

    }
}
