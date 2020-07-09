using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.redefining.sellermodifiedshipmentsupportsubtradeorder
    /// </summary>
    public class AliexpressLogisticsRedefiningSellermodifiedshipmentsupportsubtradeorderRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsRedefiningSellermodifiedshipmentsupportsubtradeorderResponse>
    {
        /// <summary>
        /// Old logistics id
        /// </summary>
        public string OldLogisticsNo { get; set; }

        /// <summary>
        /// Old logistics Service Name
        /// </summary>
        public string OldServiceName { get; set; }

        /// <summary>
        /// subtrade order list
        /// </summary>
        public string SubTradeOrderList { get; set; }

        public List<AeopSellerShipmentSubTradeOrderDtoDomain> SubTradeOrderList_ { set { this.SubTradeOrderList = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// Trade order id
        /// </summary>
        public Nullable<long> TradeOrderId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.redefining.sellermodifiedshipmentsupportsubtradeorder";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("old_logistics_no", this.OldLogisticsNo);
            parameters.Add("old_service_name", this.OldServiceName);
            parameters.Add("sub_trade_order_list", this.SubTradeOrderList);
            parameters.Add("trade_order_id", this.TradeOrderId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("old_logistics_no", this.OldLogisticsNo);
            RequestValidator.ValidateRequired("old_service_name", this.OldServiceName);
            RequestValidator.ValidateRequired("sub_trade_order_list", this.SubTradeOrderList);
            RequestValidator.ValidateObjectMaxListSize("sub_trade_order_list", this.SubTradeOrderList, 20);
            RequestValidator.ValidateRequired("trade_order_id", this.TradeOrderId);
        }

	/// <summary>
/// AeopShipmentDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopShipmentDtoDomain : TopObject
{
	        /// <summary>
	        /// New logistics id
	        /// </summary>
	        [XmlElement("logistics_no")]
	        public string LogisticsNo { get; set; }
	
	        /// <summary>
	        /// logistics service
	        /// </summary>
	        [XmlElement("service_name")]
	        public string ServiceName { get; set; }
	
	        /// <summary>
	        /// tracking site
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
	        /// all/part
	        /// </summary>
	        [XmlElement("send_type")]
	        public string SendType { get; set; }
	
	        /// <summary>
	        /// shipment list
	        /// </summary>
	        [XmlArray("shipment_list")]
	        [XmlArrayItem("aeop_shipment_dto")]
	        public List<AeopShipmentDtoDomain> ShipmentList { get; set; }
	
	        /// <summary>
	        /// sub trade order index
	        /// </summary>
	        [XmlElement("sub_trade_order_index")]
	        public Nullable<long> SubTradeOrderIndex { get; set; }
}

        #endregion
    }
}
