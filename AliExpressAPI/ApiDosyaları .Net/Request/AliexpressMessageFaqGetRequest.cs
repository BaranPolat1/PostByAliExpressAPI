using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.message.faq.get
    /// </summary>
    public class AliexpressMessageFaqGetRequest : BaseTopRequest<Top.Api.Response.AliexpressMessageFaqGetResponse>
    {
        /// <summary>
        /// 入参如下
        /// </summary>
        public string ParamMessageFaqQuery { get; set; }

        public AeopMessageFaqQueryDomain ParamMessageFaqQuery_ { set { this.ParamMessageFaqQuery = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.message.faq.get";
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
	        /// 问题id
	        /// </summary>
	        [XmlElement("faq_id")]
	        public Nullable<long> FaqId { get; set; }
}

        #endregion
    }
}
