using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.message.faqwelcome.add
    /// </summary>
    public class AliexpressMessageFaqwelcomeAddRequest : BaseTopRequest<Top.Api.Response.AliexpressMessageFaqwelcomeAddResponse>
    {
        /// <summary>
        /// 系统自动生成
        /// </summary>
        public string ParamList { get; set; }

        public List<AeopMessageFaqWelcomeDtoDomain> ParamList_ { set { this.ParamList = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.message.faqwelcome.add";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param_list", this.ParamList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateObjectMaxListSize("param_list", this.ParamList, 20);
        }

	/// <summary>
/// AeopMessageFaqWelcomeDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopMessageFaqWelcomeDtoDomain : TopObject
{
	        /// <summary>
	        /// 正文内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 语言：目前支持5种语言：en_US，es_ES，fr_FR，pt_BR，ru_RU
	        /// </summary>
	        [XmlElement("language")]
	        public string Language { get; set; }
}

        #endregion
    }
}
