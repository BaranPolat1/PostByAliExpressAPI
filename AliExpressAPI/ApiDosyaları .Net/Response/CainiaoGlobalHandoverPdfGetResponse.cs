using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// CainiaoGlobalHandoverPdfGetResponse.
    /// </summary>
    public class CainiaoGlobalHandoverPdfGetResponse : TopResponse
    {
        /// <summary>
        /// 请求结果
        /// </summary>
        [XmlElement("result")]
        public HsfResultDomain Result { get; set; }

	/// <summary>
/// HsfResultDomain Data Structure.
/// </summary>
[Serializable]

public class HsfResultDomain : TopObject
{
	        /// <summary>
	        /// 通过国际订单号获取的body内容用base64转码后生成运单标签的pdf字节流。
	        /// </summary>
	        [XmlElement("data")]
	        public string Data { get; set; }
	
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
