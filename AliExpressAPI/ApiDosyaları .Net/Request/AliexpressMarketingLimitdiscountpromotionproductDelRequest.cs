using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.marketing.limitdiscountpromotionproduct.del
    /// </summary>
    public class AliexpressMarketingLimitdiscountpromotionproductDelRequest : BaseTopRequest<Top.Api.Response.AliexpressMarketingLimitdiscountpromotionproductDelResponse>
    {
        /// <summary>
        /// 系统自动生成
        /// </summary>
        public string ParamAeopLimitedDiscProductIdDTO { get; set; }

        public AeopLimitedDiscProductIdDtoDomain ParamAeopLimitedDiscProductIdDTO_ { set { this.ParamAeopLimitedDiscProductIdDTO = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.marketing.limitdiscountpromotionproduct.del";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param_aeop_limited_disc_product_id_d_t_o", this.ParamAeopLimitedDiscProductIdDTO);
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
/// AeopLimitedDiscProductIdDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopLimitedDiscProductIdDtoDomain : TopObject
{
	        /// <summary>
	        /// 要删除的商品id集合
	        /// </summary>
	        [XmlArray("product_id_list")]
	        [XmlArrayItem("number")]
	        public List<string> ProductIdList { get; set; }
	
	        /// <summary>
	        /// 活动id
	        /// </summary>
	        [XmlElement("promotion_id")]
	        public Nullable<long> PromotionId { get; set; }
}

        #endregion
    }
}
