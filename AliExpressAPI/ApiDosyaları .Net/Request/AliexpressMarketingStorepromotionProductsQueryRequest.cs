using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.marketing.storepromotion.products.query
    /// </summary>
    public class AliexpressMarketingStorepromotionProductsQueryRequest : BaseTopRequest<Top.Api.Response.AliexpressMarketingStorepromotionProductsQueryResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string PromotionProductQueryDto { get; set; }

        public PromotionProductQueryDtoDomain PromotionProductQueryDto_ { set { this.PromotionProductQueryDto = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.marketing.storepromotion.products.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("promotion_product_query_dto", this.PromotionProductQueryDto);
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
/// PromotionProductQueryDtoDomain Data Structure.
/// </summary>
[Serializable]

public class PromotionProductQueryDtoDomain : TopObject
{
	        /// <summary>
	        /// 页码,从1开始
	        /// </summary>
	        [XmlElement("page_no")]
	        public Nullable<long> PageNo { get; set; }
	
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
}

        #endregion
    }
}
