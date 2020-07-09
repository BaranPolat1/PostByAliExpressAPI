using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPhotobankRedefiningDelunusephotoResponse.
    /// </summary>
    public class AliexpressPhotobankRedefiningDelunusephotoResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopDeleteImageResponseDomain Result { get; set; }

	/// <summary>
/// AeopDeleteImageResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopDeleteImageResponseDomain : TopObject
{
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
	        /// success:调用是否成功, true或者false;
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
}

    }
}
