using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPhotobankRedefiningQueryphotobankimagebypathsResponse.
    /// </summary>
    public class AliexpressPhotobankRedefiningQueryphotobankimagebypathsResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopPhotoBankImageResponseDomain Result { get; set; }

	/// <summary>
/// AeopPhotoBankImageResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopPhotoBankImageResponseDomain : TopObject
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
	        /// 图片信息列表。
	        /// </summary>
	        [XmlElement("images")]
	        public string Images { get; set; }
}

    }
}
