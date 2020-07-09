using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.marketing.limitdiscountpromotion.edit
    /// </summary>
    public class AliexpressMarketingLimitdiscountpromotionEditRequest : BaseTopRequest<Top.Api.Response.AliexpressMarketingLimitdiscountpromotionEditResponse>
    {
        /// <summary>
        /// 输入参数
        /// </summary>
        public string ParamLimitedDiscInputDto { get; set; }

        public AeopLimitedDiscInputDtoDomain ParamLimitedDiscInputDto_ { set { this.ParamLimitedDiscInputDto = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.marketing.limitdiscountpromotion.edit";
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
	        /// 活动结束时间
	        /// </summary>
	        [XmlElement("promotion_end_time")]
	        public string PromotionEndTime { get; set; }
	
	        /// <summary>
	        /// 活动id
	        /// </summary>
	        [XmlElement("promotion_id")]
	        public Nullable<long> PromotionId { get; set; }
	
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
