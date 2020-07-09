using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressOfferRedefiningDeletebundleResponse.
    /// </summary>
    public class AliexpressOfferRedefiningDeletebundleResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopOfferBundleDeleteResultDomain Result { get; set; }

	/// <summary>
/// AeopOfferBundleDeleteResultDomain Data Structure.
/// </summary>
[Serializable]

public class AeopOfferBundleDeleteResultDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误消息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 返回时间
	        /// </summary>
	        [XmlElement("time_stamp")]
	        public string TimeStamp { get; set; }
}

    }
}
