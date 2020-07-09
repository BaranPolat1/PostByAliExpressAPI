using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMessageFaqwelcomeGetResponse.
    /// </summary>
    public class AliexpressMessageFaqwelcomeGetResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopResultDtoDomain Result { get; set; }

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
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 更新时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 语言：目前支持5种语言：en_US，es_ES，fr_FR，pt_BR，ru_RU
	        /// </summary>
	        [XmlElement("language")]
	        public string Language { get; set; }
	
	        /// <summary>
	        /// 卖家主帐号loginId
	        /// </summary>
	        [XmlElement("seller_admin_login_id")]
	        public string SellerAdminLoginId { get; set; }
}

	/// <summary>
/// AeopResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopResultDtoDomain : TopObject
{
	        /// <summary>
	        /// errorCode
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// errorMessage
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// 返回结果
	        /// </summary>
	        [XmlArray("target_list")]
	        [XmlArrayItem("aeop_message_faq_welcome_dto")]
	        public List<AeopMessageFaqWelcomeDtoDomain> TargetList { get; set; }
	
	        /// <summary>
	        /// timeStamp
	        /// </summary>
	        [XmlElement("time_stamp")]
	        public string TimeStamp { get; set; }
}

    }
}
