using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.marketing.storepromotions.list
    /// </summary>
    public class AliexpressMarketingStorepromotionsListRequest : BaseTopRequest<Top.Api.Response.AliexpressMarketingStorepromotionsListResponse>
    {
        /// <summary>
        /// 查询参数
        /// </summary>
        public string PromotionQueryDto { get; set; }

        public PromotionQueryDtoDomain PromotionQueryDto_ { set { this.PromotionQueryDto = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.marketing.storepromotions.list";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("promotion_query_dto", this.PromotionQueryDto);
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
/// PromotionQueryDtoDomain Data Structure.
/// </summary>
[Serializable]

public class PromotionQueryDtoDomain : TopObject
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
	        /// 活动ID
	        /// </summary>
	        [XmlElement("promotion_id")]
	        public Nullable<long> PromotionId { get; set; }
	
	        /// <summary>
	        /// 活动名称
	        /// </summary>
	        [XmlElement("promotion_name")]
	        public string PromotionName { get; set; }
	
	        /// <summary>
	        /// 活动类型：单品折扣:ProductDiscount;搭配套餐:BundleDeals;拼团:GroupBuy;满件折:OrderQuantityDiscount;满立减:OrderPriceDiscount;满包邮:FreeShipping;
	        /// </summary>
	        [XmlElement("promotion_type")]
	        public string PromotionType { get; set; }
	
	        /// <summary>
	        /// 活动状态：未开始:NotStarted;进行中:Ongoing;已暂停:Invalid;已结束:Finished;
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
}

        #endregion
    }
}
