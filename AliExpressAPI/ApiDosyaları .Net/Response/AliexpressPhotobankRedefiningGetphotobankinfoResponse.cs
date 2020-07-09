using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPhotobankRedefiningGetphotobankinfoResponse.
    /// </summary>
    public class AliexpressPhotobankRedefiningGetphotobankinfoResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopPhotoBankInfoResponseDomain Result { get; set; }

	/// <summary>
/// AeopPhotoBankInfoResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopPhotoBankInfoResponseDomain : TopObject
{
	        /// <summary>
	        /// 图片银行总容量，单位字节。
	        /// </summary>
	        [XmlElement("capicity")]
	        public long Capicity { get; set; }
	
	        /// <summary>
	        /// 错误代码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 图片银行已使用量，单位字节。
	        /// </summary>
	        [XmlElement("useage")]
	        public long Useage { get; set; }
}

    }
}
