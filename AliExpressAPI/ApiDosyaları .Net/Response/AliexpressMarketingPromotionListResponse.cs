using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMarketingPromotionListResponse.
    /// </summary>
    public class AliexpressMarketingPromotionListResponse : TopResponse
    {
        /// <summary>
        /// currentPage
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// pageSize
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// target
        /// </summary>
        [XmlArray("target_list")]
        [XmlArrayItem("aeop_promotion_dto")]
        public List<AeopPromotionDtoDomain> TargetList { get; set; }

        /// <summary>
        /// timeStamp
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

	/// <summary>
/// AeopPromotionDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopPromotionDtoDomain : TopObject
{
	        /// <summary>
	        /// 活动展示场景
	        /// </summary>
	        [XmlElement("apply_scene")]
	        public string ApplyScene { get; set; }
	
	        /// <summary>
	        /// 招商结束时间
	        /// </summary>
	        [XmlElement("attract_end_date")]
	        public string AttractEndDate { get; set; }
	
	        /// <summary>
	        /// 招商开始时间
	        /// </summary>
	        [XmlElement("attract_start_date")]
	        public string AttractStartDate { get; set; }
	
	        /// <summary>
	        /// 创建人登录账号
	        /// </summary>
	        [XmlElement("creator_login_id")]
	        public string CreatorLoginId { get; set; }
	
	        /// <summary>
	        /// 活动信息描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 前台展示活动名称
	        /// </summary>
	        [XmlElement("display_name")]
	        public string DisplayName { get; set; }
	
	        /// <summary>
	        /// 支付时间限制
	        /// </summary>
	        [XmlElement("pay_time_limit")]
	        public long PayTimeLimit { get; set; }
	
	        /// <summary>
	        /// 活动模式 店铺活动store, 平台活动platform
	        /// </summary>
	        [XmlElement("prom_mode")]
	        public string PromMode { get; set; }
	
	        /// <summary>
	        /// 活动库存策略
	        /// </summary>
	        [XmlElement("prom_rule")]
	        public string PromRule { get; set; }
	
	        /// <summary>
	        /// 活动ID
	        /// </summary>
	        [XmlElement("promotion_id")]
	        public long PromotionId { get; set; }
	
	        /// <summary>
	        /// 发布结束时间
	        /// </summary>
	        [XmlElement("release_end_date")]
	        public string ReleaseEndDate { get; set; }
	
	        /// <summary>
	        /// 发布开始时间
	        /// </summary>
	        [XmlElement("release_start_date")]
	        public string ReleaseStartDate { get; set; }
	
	        /// <summary>
	        /// 活动状态 发布中releasing, 发布已结束releasEnd, 冻结中，当前时间在 发布开始时间RELEASE_START_DATE减去24小时到发布开始时间RELEASE_START_DATE之间 frozen,新创建，当前时间在发布开始时间RELEASE_START_DATE减去24小时前的活动 created;
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 库存id
	        /// </summary>
	        [XmlElement("stock_channel_id")]
	        public string StockChannelId { get; set; }
	
	        /// <summary>
	        /// 活动类型：店铺活动的限时限量折扣LimitedDiscount, 店铺自主满就减FixedDiscount,店铺自主全店铺打折StoreDiscount,店铺优惠券StoreCoupon,定向店铺优惠券DirectStoreCoupon,金币兑换店铺优惠券CoinsExchangeStoreCoupon,秒抢店铺优惠券GrabStoreCoupon,聚人气店铺优惠券PolyPopularityStoreCoupon, 购物券活动类型ShoppingCoupon,店铺自主满包邮FreeShipping，平台活动的限时限量折扣ProEngine,平台活动的全网大促销GPoint,平台活动的限时限量秒杀GAGA,平台活动的新品推介NewProduct,平台活动的团购GroupBuy
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

    }
}
