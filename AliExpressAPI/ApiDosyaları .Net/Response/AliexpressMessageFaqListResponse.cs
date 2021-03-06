using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMessageFaqListResponse.
    /// </summary>
    public class AliexpressMessageFaqListResponse : TopResponse
    {
        /// <summary>
        /// 详细参考如下
        /// </summary>
        [XmlArray("target_list")]
        [XmlArrayItem("aeop_message_faq_subject_dto")]
        public List<AeopMessageFaqSubjectDtoDomain> TargetList { get; set; }

        /// <summary>
        /// timeStamp
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }

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
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 最后修改时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 内容id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
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
	        [XmlElement("category_id")]
	        public string CategoryId { get; set; }
	
	        /// <summary>
	        /// 类目名称（包含父类目）
	        /// </summary>
	        [XmlElement("category_name")]
	        public string CategoryName { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("content_language")]
	        public long ContentLanguage { get; set; }
	
	        /// <summary>
	        /// faq内容
	        /// </summary>
	        [XmlArray("contents_list")]
	        [XmlArrayItem("aeop_message_faq_content")]
	        public List<AeopMessageFaqContentDomain> ContentsList { get; set; }
	
	        /// <summary>
	        /// 类型：common 通用、category 类目
	        /// </summary>
	        [XmlElement("faq_type")]
	        public string FaqType { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 最后修改时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 问题id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 卖家主帐号登录id
	        /// </summary>
	        [XmlElement("seller_admin_login_id")]
	        public string SellerAdminLoginId { get; set; }
	
	        /// <summary>
	        /// 排序号，倒序
	        /// </summary>
	        [XmlElement("sort_num")]
	        public long SortNum { get; set; }
	
	        /// <summary>
	        /// 状态: 已发布 online,未发布 offline
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// faq标题
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
}

    }
}
