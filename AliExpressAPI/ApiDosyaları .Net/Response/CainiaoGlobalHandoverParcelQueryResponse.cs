using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// CainiaoGlobalHandoverParcelQueryResponse.
    /// </summary>
    public class CainiaoGlobalHandoverParcelQueryResponse : TopResponse
    {
        /// <summary>
        /// 请求结果
        /// </summary>
        [XmlElement("result")]
        public HsfResultDomain Result { get; set; }

	/// <summary>
/// OpenParcelOrderQueryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenParcelOrderQueryResponseDomain : TopObject
{
	        /// <summary>
	        /// 关联的大包的编码
	        /// </summary>
	        [XmlElement("handover_content_code")]
	        public string HandoverContentCode { get; set; }
	
	        /// <summary>
	        /// 关联的大包ID
	        /// </summary>
	        [XmlElement("handover_content_id")]
	        public long HandoverContentId { get; set; }
	
	        /// <summary>
	        /// 关联的交接单ID
	        /// </summary>
	        [XmlElement("handover_order_id")]
	        public long HandoverOrderId { get; set; }
	
	        /// <summary>
	        /// 交接仓编码，快递揽收场景,大包交接目的地国际分拨
	        /// </summary>
	        [XmlElement("handover_warehouse_code")]
	        public string HandoverWarehouseCode { get; set; }
	
	        /// <summary>
	        /// 交接仓名称，快递揽收场景,大包交接目的地国际分拨
	        /// </summary>
	        [XmlElement("handover_warehouse_name")]
	        public string HandoverWarehouseName { get; set; }
	
	        /// <summary>
	        /// 该小包是否已经组包
	        /// </summary>
	        [XmlElement("has_been_handover")]
	        public bool HasBeenHandover { get; set; }
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
	        public OpenParcelOrderQueryResponseDomain Data { get; set; }
	
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
