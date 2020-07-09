using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.message.faq.edit
    /// </summary>
    public class AliexpressMessageFaqEditRequest : BaseTopRequest<Top.Api.Response.AliexpressMessageFaqEditResponse>
    {
        /// <summary>
        /// 入参参考如下
        /// </summary>
        public string ParamMessageFaqSubjectDto { get; set; }

        public AeopMessageFaqSubjectDtoDomain ParamMessageFaqSubjectDto_ { set { this.ParamMessageFaqSubjectDto = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.message.faq.edit";
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
/// AeopMessageFaqContentDomain Data Structure.
/// </summary>
[Serializable]

public class AeopMessageFaqContentDomain : TopObject
{
	        /// <summary>
	        /// faq回答
	        /// </summary>
	        [XmlElement("faq_answer")]
	        public string FaqAnswer { get; set; }
	
	        /// <summary>
	        /// faq题目
	        /// </summary>
	        [XmlElement("faq_question")]
	        public string FaqQuestion { get; set; }
	
	        /// <summary>
	        /// 语言：目前支持5种语言：en_US，es_ES，fr_FR，pt_BR，ru_RU
	        /// </summary>
	        [XmlElement("language")]
	        public string Language { get; set; }
}

	/// <summary>
/// AeopMessageFaqSubjectDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopMessageFaqSubjectDtoDomain : TopObject
{
	        /// <summary>
	        /// 类目id
	        /// </summary>
	        [XmlElement("category_code")]
	        public string CategoryCode { get; set; }
	
	        /// <summary>
	        /// 类目名称（包含父类目）
	        /// </summary>
	        [XmlElement("category_name")]
	        public string CategoryName { get; set; }
	
	        /// <summary>
	        /// 问题内容
	        /// </summary>
	        [XmlArray("contents")]
	        [XmlArrayItem("aeop_message_faq_content")]
	        public List<AeopMessageFaqContentDomain> Contents { get; set; }
	
	        /// <summary>
	        /// 类型：common 通用、category 类目
	        /// </summary>
	        [XmlElement("faq_type")]
	        public string FaqType { get; set; }
	
	        /// <summary>
	        /// 问题id
	        /// </summary>
	        [XmlElement("id")]
	        public Nullable<long> Id { get; set; }
	
	        /// <summary>
	        /// 排序号，倒序
	        /// </summary>
	        [XmlElement("sort_num")]
	        public Nullable<long> SortNum { get; set; }
	
	        /// <summary>
	        /// faq标题
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
}

        #endregion
    }
}
