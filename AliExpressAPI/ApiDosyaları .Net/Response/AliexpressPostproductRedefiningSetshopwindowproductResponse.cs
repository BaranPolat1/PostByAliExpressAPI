using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningSetshopwindowproductResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningSetshopwindowproductResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopProductWindowResponseDomain Result { get; set; }

	/// <summary>
/// AeopProductWindowResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopProductWindowResponseDomain : TopObject
{
	        /// <summary>
	        /// 错误原因
	        /// </summary>
	        [XmlElement("error_cause")]
	        public string ErrorCause { get; set; }
	
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
	        /// 接口调用结果。true/false分别表示成功和失败。
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// 剩余的可用橱窗数。
	        /// </summary>
	        [XmlElement("remaining_window_count")]
	        public long RemainingWindowCount { get; set; }
}

    }
}
