using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressOfferRedefiningCreatebundleResponse.
    /// </summary>
    public class AliexpressOfferRedefiningCreatebundleResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopOfferBundleSaveResultDomain Result { get; set; }

	/// <summary>
/// AeopOfferBundleSaveResultDomain Data Structure.
/// </summary>
[Serializable]

public class AeopOfferBundleSaveResultDomain : TopObject
{
	        /// <summary>
	        /// 搭配ID
	        /// </summary>
	        [XmlElement("bundle_id")]
	        public long BundleId { get; set; }
	
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// timeStamp
	        /// </summary>
	        [XmlElement("time_stamp")]
	        public string TimeStamp { get; set; }
}

    }
}
