using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsRedefiningSellermodifiedshipmentsupportsubtradeorderResponse.
    /// </summary>
    public class AliexpressLogisticsRedefiningSellermodifiedshipmentsupportsubtradeorderResponse : TopResponse
    {
        /// <summary>
        /// errorCode
        /// </summary>
        [XmlElement("code_of_error")]
        public string CodeOfError { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// oldLogisticsNo
        /// </summary>
        [XmlElement("old_logistics_no")]
        public string OldLogisticsNo { get; set; }

        /// <summary>
        /// oldSerivceName
        /// </summary>
        [XmlElement("old_serivce_name")]
        public string OldSerivceName { get; set; }

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
