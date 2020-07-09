using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.message.faqwelcome.get
    /// </summary>
    public class AliexpressMessageFaqwelcomeGetRequest : BaseTopRequest<Top.Api.Response.AliexpressMessageFaqwelcomeGetResponse>
    {
        /// <summary>
        /// 入参对象
        /// </summary>
        public string ParamMessageFaqWelcomeDto { get; set; }

        public AeopMessageFaqWelcomeDtoDomain ParamMessageFaqWelcomeDto_ { set { this.ParamMessageFaqWelcomeDto = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.message.faqwelcome.get";
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
	        /// 语言：目前支持5种语言：en_US，es_ES，fr_FR，pt_BR，ru_RU
	        /// </summary>
	        [XmlElement("language")]
	        public string Language { get; set; }
}

        #endregion
    }
}
