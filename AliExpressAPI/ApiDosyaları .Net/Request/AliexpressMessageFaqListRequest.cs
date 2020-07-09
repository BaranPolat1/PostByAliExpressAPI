using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.message.faq.list
    /// </summary>
    public class AliexpressMessageFaqListRequest : BaseTopRequest<Top.Api.Response.AliexpressMessageFaqListResponse>
    {
        /// <summary>
        /// 入参如下
        /// </summary>
        public string ParamMessageFaqQuery { get; set; }

        public AeopMessageFaqQueryDomain ParamMessageFaqQuery_ { set { this.ParamMessageFaqQuery = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.message.faq.list";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param_message_faq_query", this.ParamMessageFaqQuery);
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
/// AeopMessageFaqQueryDomain Data Structure.
/// </summary>
[Serializable]

public class AeopMessageFaqQueryDomain : TopObject
{
	        /// <summary>
	        /// 类目id
	        /// </summary>
	        [XmlElement("category_code")]
	        public string CategoryCode { get; set; }
	
	        /// <summary>
	        /// 类型：common 通用、category 类目
	        /// </summary>
	        [XmlElement("faq_type")]
	        public string FaqType { get; set; }
	
	        /// <summary>
	        /// 语言：目前支持5种语言：en_US，es_ES，fr_FR，pt_BR，ru_RU
	        /// </summary>
	        [XmlElement("language")]
	        public string Language { get; set; }
}

        #endregion
    }
}
