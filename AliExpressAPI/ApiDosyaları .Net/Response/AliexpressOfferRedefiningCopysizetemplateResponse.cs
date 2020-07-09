using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressOfferRedefiningCopysizetemplateResponse.
    /// </summary>
    public class AliexpressOfferRedefiningCopysizetemplateResponse : TopResponse
    {
        /// <summary>
        /// 操作响应
        /// </summary>
        [XmlElement("result")]
        public AeProductCopyTemplateResponseDomain Result { get; set; }

	/// <summary>
/// AeProductCopyTemplateResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeProductCopyTemplateResponseDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 响应错误信息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// 复制后产生的尺码模版ID
	        /// </summary>
	        [XmlElement("size_template_id")]
	        public long SizeTemplateId { get; set; }
	
	        /// <summary>
	        /// 响应时间
	        /// </summary>
	        [XmlElement("time_stamp")]
	        public string TimeStamp { get; set; }
}

    }
}
