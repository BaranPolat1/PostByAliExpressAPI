using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsCreatewarehouseorderResponse.
    /// </summary>
    public class AliexpressLogisticsCreatewarehouseorderResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopWlCreateWarehouseOrderResultDtoDomain Result { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("result_success")]
        public bool ResultSuccess { get; set; }

	/// <summary>
/// AeopWlCreateWarehouseOrderResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopWlCreateWarehouseOrderResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 创建时错误码(1表示无错误)
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 创建时错误信息
	        /// </summary>
	        [XmlElement("error_desc")]
	        public string ErrorDesc { get; set; }
	
	        /// <summary>
	        /// 国际运单号
	        /// </summary>
	        [XmlElement("intl_tracking_no")]
	        public string IntlTrackingNo { get; set; }
	
	        /// <summary>
	        /// 外部订单号
	        /// </summary>
	        [XmlElement("out_order_id")]
	        public long OutOrderId { get; set; }
	
	        /// <summary>
	        /// 创建订单是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// 订单来源
	        /// </summary>
	        [XmlElement("trade_order_from")]
	        public string TradeOrderFrom { get; set; }
	
	        /// <summary>
	        /// 交易订单号
	        /// </summary>
	        [XmlElement("trade_order_id")]
	        public long TradeOrderId { get; set; }
	
	        /// <summary>
	        /// 物流订单号
	        /// </summary>
	        [XmlElement("warehouse_order_id")]
	        public long WarehouseOrderId { get; set; }
}

    }
}
