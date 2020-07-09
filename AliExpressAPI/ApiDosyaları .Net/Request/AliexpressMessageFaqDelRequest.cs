using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.message.faq.del
    /// </summary>
    public class AliexpressMessageFaqDelRequest : BaseTopRequest<Top.Api.Response.AliexpressMessageFaqDelResponse>
    {
        /// <summary>
        /// 参考
        /// </summary>
        public string ParamMessageFaqSubjectDto { get; set; }

        public AeopMessageFaqSubjectDtoDomain ParamMessageFaqSubjectDto_ { set { this.ParamMessageFaqSubjectDto = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.message.faq.del";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param_message_faq_subject_dto", this.ParamMessageFaqSubjectDto);
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
/// AeopMessageFaqSubjectDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopMessageFaqSubjectDtoDomain : TopObject
{
	        /// <summary>
	        /// 问题id
	        /// </summary>
	        [XmlElement("id")]
	        public Nullable<long> Id { get; set; }
}

        #endregion
    }
}
