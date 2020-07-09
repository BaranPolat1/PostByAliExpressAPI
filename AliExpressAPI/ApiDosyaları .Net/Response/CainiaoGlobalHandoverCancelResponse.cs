using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// CainiaoGlobalHandoverCancelResponse.
    /// </summary>
    public class CainiaoGlobalHandoverCancelResponse : TopResponse
    {
        /// <summary>
        /// 请求结果
        /// </summary>
        [XmlElement("result")]
        public HsfResultDomain Result { get; set; }

	/// <summary>
/// OpenHandoverCancelResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenHandoverCancelResponseDomain : TopObject
{
	        /// <summary>
	        /// 取消结果
	        /// </summary>
	        [XmlElement("result")]
	        public bool Result { get; set; }
}

	/// <summary>
/// HsfResultDomain Data Structure.
/// </summary>
[Serializable]

public class HsfResultDomain : TopObject
{
	        /// <summary>
	        /// 响应数据
	        /// </summary>
	        [XmlElement("data")]
	        public OpenHandoverCancelResponseDomain Data { get; set; }
	
	        /// <summary>
	        /// 异常码
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 请求处理是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
