using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// CainiaoGlobalHandoverSavedraftResponse.
    /// </summary>
    public class CainiaoGlobalHandoverSavedraftResponse : TopResponse
    {
        /// <summary>
        /// 请求结果
        /// </summary>
        [XmlElement("result")]
        public HsfResultDomain Result { get; set; }

	/// <summary>
/// OpenHandoverDraftSaveResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenHandoverDraftSaveResponseDomain : TopObject
{
	        /// <summary>
	        /// 交接物id，即大包id
	        /// </summary>
	        [XmlElement("handover_content_id")]
	        public long HandoverContentId { get; set; }
	
	        /// <summary>
	        /// 交接批次号，即交接单id
	        /// </summary>
	        [XmlElement("handover_order_id")]
	        public long HandoverOrderId { get; set; }
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
	        public OpenHandoverDraftSaveResponseDomain Data { get; set; }
	
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
