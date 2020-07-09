using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsQuerysellershipmentinfoResponse.
    /// </summary>
    public class AliexpressLogisticsQuerysellershipmentinfoResponse : TopResponse
    {
        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// errorCode
        /// </summary>
        [XmlElement("result_error_code")]
        public string ResultErrorCode { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("result_success")]
        public bool ResultSuccess { get; set; }

        /// <summary>
        /// subTradeOrderList
        /// </summary>
        [XmlArray("sub_trade_order_list")]
        [XmlArrayItem("aeop_seller_shipment_sub_trade_order_dto")]
        public List<AeopSellerShipmentSubTradeOrderDtoDomain> SubTradeOrderList { get; set; }

        /// <summary>
        /// tradeOrderId
        /// </summary>
        [XmlElement("trade_order_id")]
        public long TradeOrderId { get; set; }

	/// <summary>
/// AeopShipmentDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopShipmentDtoDomain : TopObject
{
	        /// <summary>
	        /// errorCode
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// logisticsNo
	        /// </summary>
	        [XmlElement("logistics_no")]
	        public string LogisticsNo { get; set; }
	
	        /// <summary>
	        /// serviceName
	        /// </summary>
	        [XmlElement("service_name")]
	        public string ServiceName { get; set; }
	
	        /// <summary>
	        /// trackingWebSite
	        /// </summary>
	        [XmlElement("tracking_web_site")]
	        public string TrackingWebSite { get; set; }
}

	/// <summary>
/// AeopSellerShipmentSubTradeOrderDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopSellerShipmentSubTradeOrderDtoDomain : TopObject
{
	        /// <summary>
	        /// errorCode
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// sendType
	        /// </summary>
	        [XmlElement("send_type")]
	        public string SendType { get; set; }
	
	        /// <summary>
	        /// shipmentList
	        /// </summary>
	        [XmlArray("shipment_list")]
	        [XmlArrayItem("aeop_shipment_dto")]
	        public List<AeopShipmentDtoDomain> ShipmentList { get; set; }
	
	        /// <summary>
	        /// subTradeOrderIndex
	        /// </summary>
	        [XmlElement("sub_trade_order_index")]
	        public long SubTradeOrderIndex { get; set; }
}

    }
}
