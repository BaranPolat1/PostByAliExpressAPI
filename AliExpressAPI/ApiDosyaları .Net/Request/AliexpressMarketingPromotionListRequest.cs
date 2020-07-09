using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.marketing.promotion.list
    /// </summary>
    public class AliexpressMarketingPromotionListRequest : BaseTopRequest<Top.Api.Response.AliexpressMarketingPromotionListResponse>
    {
        /// <summary>
        /// 查询参数
        /// </summary>
        public string MarketingPromotionQuery { get; set; }

        public AeopMarketingPromotionQueryDomain MarketingPromotionQuery_ { set { this.MarketingPromotionQuery = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.marketing.promotion.list";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("marketing_promotion_query", this.MarketingPromotionQuery);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// AeopMarketingPromotionQueryDomain Data Structure.
/// </summary>
[Serializable]

public class AeopMarketingPromotionQueryDomain : TopObject
{
	        /// <summary>
	        /// 页码
	        /// </summary>
	        [XmlElement("current_page")]
	        public Nullable<long> CurrentPage { get; set; }
	
	        /// <summary>
	        /// 页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 活动类型：店铺活动的限时限量折扣LimitedDiscount, 店铺自主满就减FixedDiscount,店铺自主全店铺打折StoreDiscount,店铺优惠券StoreCoupon,定向店铺优惠券DirectStoreCoupon,金币兑换店铺优惠券CoinsExchangeStoreCoupon,秒抢店铺优惠券GrabStoreCoupon,聚人气店铺优惠券PolyPopularityStoreCoupon, 购物券活动类型ShoppingCoupon,店铺自主满包邮FreeShipping，平台活动的限时限量折扣ProEngine,平台活动的全网大促销GPoint,平台活动的限时限量秒杀GAGA,平台活动的新品推介NewProduct,平台活动的团购GroupBuy
	        /// </summary>
	        [XmlElement("prom_type")]
	        public string PromType { get; set; }
	
	        /// <summary>
	        /// 发布中releasing, 发布已结束releasEnd, 冻结中\当前时间在 发布开始时间RELEASE_START_DATE减去24小时到发布开始时间RELEASE_START_DATE之间 frozen,新创建，当前时间在发布开始时间RELEASE_START_DATE减去24小时前的活动 created;招商未开始attractNotStart,招商中attracting,招商已结束attractEnd
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
}

        #endregion
    }
}
