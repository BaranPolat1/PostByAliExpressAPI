using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.message.faqwelcome.del
    /// </summary>
    public class AliexpressMessageFaqwelcomeDelRequest : BaseTopRequest<Top.Api.Response.AliexpressMessageFaqwelcomeDelResponse>
    {
        /// <summary>
        /// 无
        /// </summary>
        public string ParamMessageFaqWelcomeDto { get; set; }

        public AeopMessageFaqWelcomeDtoDomain ParamMessageFaqWelcomeDto_ { set { this.ParamMessageFaqWelcomeDto = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.message.faqwelcome.del";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param_message_faq_welcome_dto", this.ParamMessageFaqWelcomeDto);
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
/// AeopMessageFaqWelcomeDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopMessageFaqWelcomeDtoDomain : TopObject
{
	        /// <summary>
	        /// 为了解决对象问题的参数，无实际意义
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
}

        #endregion
    }
}
