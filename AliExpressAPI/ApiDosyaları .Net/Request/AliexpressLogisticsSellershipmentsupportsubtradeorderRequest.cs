using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.sellershipmentsupportsubtradeorder
    /// </summary>
    public class AliexpressLogisticsSellershipmentsupportsubtradeorderRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsSellershipmentsupportsubtradeorderResponse>
    {
        /// <summary>
        /// 1
        /// </summary>
        public string SubTradeOrderList { get; set; }

        public List<SubtradeorderlistDomain> SubTradeOrderList_ { set { this.SubTradeOrderList = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 主订单ID
        /// </summary>
        public Nullable<long> TradeOrderId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.sellershipmentsupportsubtradeorder";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
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
            RequestValidator.ValidateRequired("sub_trade_order_list", this.SubTradeOrderList);
            RequestValidator.ValidateObjectMaxListSize("sub_trade_order_list", this.SubTradeOrderList, 20);
            RequestValidator.ValidateRequired("trade_order_id", this.TradeOrderId);
        }

	/// <summary>
/// ShipmentlistDomain Data Structure.
/// </summary>
[Serializable]

public class ShipmentlistDomain : TopObject
{
	        /// <summary>
	        /// logistics_no
	        /// </summary>
	        [XmlElement("logistics_no")]
	        public string LogisticsNo { get; set; }
	
	        /// <summary>
	        /// service_name
	        /// </summary>
	        [XmlElement("service_name")]
	        public string ServiceName { get; set; }
	
	        /// <summary>
	        /// tracking_web_site
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
	        /// part / all
	        /// </summary>
	        [XmlElement("send_type")]
	        public string SendType { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlArray("shipment_list")]
	        [XmlArrayItem("shipmentlist")]
	        public List<ShipmentlistDomain> ShipmentList { get; set; }
	
	        /// <summary>
	        /// 子订单序号，从1开始
	        /// </summary>
	        [XmlElement("sub_trade_order_index")]
	        public Nullable<long> SubTradeOrderIndex { get; set; }
}

        #endregion
    }
}
