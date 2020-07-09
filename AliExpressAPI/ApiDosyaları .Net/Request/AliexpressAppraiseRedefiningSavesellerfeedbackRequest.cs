using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.appraise.redefining.savesellerfeedback
    /// </summary>
    public class AliexpressAppraiseRedefiningSavesellerfeedbackRequest : BaseTopRequest<Top.Api.Response.AliexpressAppraiseRedefiningSavesellerfeedbackResponse>
    {
        /// <summary>
        /// 留评内容对象
        /// </summary>
        public string Param1 { get; set; }

        public EvaluationFeedbackDtoDomain Param1_ { set { this.Param1 = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.appraise.redefining.savesellerfeedback";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param1", this.Param1);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("param1", this.Param1);
        }

	/// <summary>
/// EvaluationFeedbackDtoDomain Data Structure.
/// </summary>
[Serializable]

public class EvaluationFeedbackDtoDomain : TopObject
{
	        /// <summary>
	        /// 无效参数，匿名留评(默认为false)
	        /// </summary>
	        [XmlElement("anonymous")]
	        public Nullable<bool> Anonymous { get; set; }
	
	        /// <summary>
	        /// 买家登录会员ID，可不填，系统会根据订单获取买家id
	        /// </summary>
	        [XmlElement("buyer_ali_id")]
	        public Nullable<long> BuyerAliId { get; set; }
	
	        /// <summary>
	        /// 评价内容
	        /// </summary>
	        [XmlElement("feedback_content")]
	        public string FeedbackContent { get; set; }
	
	        /// <summary>
	        /// 无效参数，图片地址
	        /// </summary>
	        [XmlArray("image_urls")]
	        [XmlArrayItem("json")]
	        public List<string> ImageUrls { get; set; }
	
	        /// <summary>
	        /// 主订单ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public Nullable<long> OrderId { get; set; }
	
	        /// <summary>
	        /// 评价星级，1-5
	        /// </summary>
	        [XmlElement("score")]
	        public Nullable<long> Score { get; set; }
	
	        /// <summary>
	        /// 卖家登录会员ID
	        /// </summary>
	        [XmlElement("seller_ali_id")]
	        public Nullable<long> SellerAliId { get; set; }
}

        #endregion
    }
}
