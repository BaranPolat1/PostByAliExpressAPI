using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.marketing.limitdiscountpromotion.create
    /// </summary>
    public class AliexpressMarketingLimitdiscountpromotionCreateRequest : BaseTopRequest<Top.Api.Response.AliexpressMarketingLimitdiscountpromotionCreateResponse>
    {
        /// <summary>
        /// 详细参考如下
        /// </summary>
        public string ParamLimitedDiscInputDto { get; set; }

        public AeopLimitedDiscInputDtoDomain ParamLimitedDiscInputDto_ { set { this.ParamLimitedDiscInputDto = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.marketing.limitdiscountpromotion.create";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param_limited_disc_input_dto", this.ParamLimitedDiscInputDto);
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
/// AeopLimitedDiscInputDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopLimitedDiscInputDtoDomain : TopObject
{
	        /// <summary>
	        /// 是否大促活动
	        /// </summary>
	        [XmlElement("has_promo")]
	        public Nullable<bool> HasPromo { get; set; }
	
	        /// <summary>
	        /// 活动结束时间
	        /// </summary>
	        [XmlElement("promotion_end_time")]
	        public string PromotionEndTime { get; set; }
	
	        /// <summary>
	        /// 活动名称
	        /// </summary>
	        [XmlElement("promotion_name")]
	        public string PromotionName { get; set; }
	
	        /// <summary>
	        /// 活动开始时间
	        /// </summary>
	        [XmlElement("promotion_start_time")]
	        public string PromotionStartTime { get; set; }
}

        #endregion
    }
}
