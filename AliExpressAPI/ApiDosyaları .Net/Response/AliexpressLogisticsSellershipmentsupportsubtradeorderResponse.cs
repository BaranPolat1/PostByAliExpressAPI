using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsSellershipmentsupportsubtradeorderResponse.
    /// </summary>
    public class AliexpressLogisticsSellershipmentsupportsubtradeorderResponse : TopResponse
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
        /// subTradeOrderList
        /// </summary>
        [XmlArray("sub_trade_order_list")]
        [XmlArrayItem("subtradeorderlist")]
        public List<SubtradeorderlistDomain> SubTradeOrderList { get; set; }

        /// <summary>
        /// Transaction order number
        /// </summary>
        [XmlElement("trade_order_id")]
        public long TradeOrderId { get; set; }

	/// <summary>
/// ShipmentlistDomain Data Structure.
/// </summary>
[Serializable]

public class ShipmentlistDomain : TopObject
{
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
/// SubtradeorderlistDomain Data Structure.
/// </summary>
[Serializable]

public class SubtradeorderlistDomain : TopObject
{
	        /// <summary>
	        /// part/all
	        /// </summary>
	        [XmlElement("send_type")]
	        public string SendType { get; set; }
	
	        /// <summary>
	        /// shipmentList
	        /// </summary>
	        [XmlArray("shipment_list")]
	        [XmlArrayItem("shipmentlist")]
	        public List<ShipmentlistDomain> ShipmentList { get; set; }
	
	        /// <summary>
	        /// subTradeOrderIndex
	        /// </summary>
	        [XmlElement("sub_trade_order_index")]
	        public long SubTradeOrderIndex { get; set; }
}

    }
}
