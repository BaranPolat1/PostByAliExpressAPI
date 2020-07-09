using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.offer.redefining.querybundle
    /// </summary>
    public class AliexpressOfferRedefiningQuerybundleRequest : BaseTopRequest<Top.Api.Response.AliexpressOfferRedefiningQuerybundleResponse>
    {
        /// <summary>
        /// 查询入参
        /// </summary>
        public string ParamAeopOfferBundleQueryCondition { get; set; }

        public AeopOfferBundleQueryConditionDomain ParamAeopOfferBundleQueryCondition_ { set { this.ParamAeopOfferBundleQueryCondition = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.offer.redefining.querybundle";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param_aeop_offer_bundle_query_condition", this.ParamAeopOfferBundleQueryCondition);
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
/// AeopOfferBundleQueryConditionDomain Data Structure.
/// </summary>
[Serializable]

public class AeopOfferBundleQueryConditionDomain : TopObject
{
	        /// <summary>
	        /// 当前页码
	        /// </summary>
	        [XmlElement("current_page")]
	        public Nullable<long> CurrentPage { get; set; }
	
	        /// <summary>
	        /// 搭配主商品ID,必填
	        /// </summary>
	        [XmlElement("item_id")]
	        public Nullable<long> ItemId { get; set; }
	
	        /// <summary>
	        /// 搭配主商品标题
	        /// </summary>
	        [XmlElement("item_subject")]
	        public string ItemSubject { get; set; }
	
	        /// <summary>
	        /// 每页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
}

        #endregion
    }
}
