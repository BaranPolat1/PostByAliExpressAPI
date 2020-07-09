using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// CainiaoGlobalHandoverCloudprintGetResponse.
    /// </summary>
    public class CainiaoGlobalHandoverCloudprintGetResponse : TopResponse
    {
        /// <summary>
        /// 请求结果
        /// </summary>
        [XmlElement("result")]
        public HsfResultDomain Result { get; set; }

	/// <summary>
/// CloudPrintDataGetResponseDomain Data Structure.
/// </summary>
[Serializable]

public class CloudPrintDataGetResponseDomain : TopObject
{
	        /// <summary>
	        /// 面单云打印数据
	        /// </summary>
	        [XmlElement("print_data")]
	        public string PrintData { get; set; }
	
	        /// <summary>
	        /// 面单云打印数据MD5加密串
	        /// </summary>
	        [XmlElement("print_data_md5")]
	        public string PrintDataMd5 { get; set; }
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
	        public CloudPrintDataGetResponseDomain Data { get; set; }
	
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
