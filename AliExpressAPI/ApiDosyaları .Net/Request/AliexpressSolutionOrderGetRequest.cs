using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.order.get
    /// </summary>
    public class AliexpressSolutionOrderGetRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionOrderGetResponse>
    {
        /// <summary>
        /// param
        /// </summary>
        public string Param0 { get; set; }

        public OrderQueryDomain Param0_ { set { this.Param0 = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.order.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param0", this.Param0);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// OrderQueryDomain Data Structure.
/// </summary>
[Serializable]

public class OrderQueryDomain : TopObject
{
	        /// <summary>
	        /// buyer login id
	        /// </summary>
	        [XmlElement("buyer_login_id")]
	        public string BuyerLoginId { get; set; }
	
	        /// <summary>
	        /// create date end time.It's US pacific time
	        /// </summary>
	        [XmlElement("create_date_end")]
	        public string CreateDateEnd { get; set; }
	
	        /// <summary>
	        /// create date start time.It's US pacific time
	        /// </summary>
	        [XmlElement("create_date_start")]
	        public string CreateDateStart { get; set; }
	
	        /// <summary>
	        /// the current page
	        /// </summary>
	        [XmlElement("current_page")]
	        public Nullable<long> CurrentPage { get; set; }
	
	        /// <summary>
	        /// modified date end time.It's US pacific time
	        /// </summary>
	        [XmlElement("modified_date_end")]
	        public string ModifiedDateEnd { get; set; }
	
	        /// <summary>
	        /// modified date start time.It's US pacific time
	        /// </summary>
	        [XmlElement("modified_date_start")]
	        public string ModifiedDateStart { get; set; }
	
	        /// <summary>
	        /// Order status: PLACE_ORDER_SUCCESS: Waiting for buyer to pay; IN_CANCEL: Buyer request cancellation; WAIT_SELLER_SEND_GOODS: Waiting for your shipment; SELLER_PART_SEND_GOODS: Partial delivery; WAIT_BUYER_ACCEPT_GOODS: Waiting for buyer to receive goods; FUND_PROCESSING: Buyers agree, funds processing; IN_ISSUE : Orders in disputes; IN_FROZEN: Orders in freeze; WAIT_SELLER_EXAMINE_MONEY: Waiting for your confirmation amount; RISK_CONTROL: Orders are in 24 hours of risk control, starting 24 hours after the buyer's online payment is completed. The above status query can be separately queried separately, and the order status information is not included in the order status. (FINISH, closed order status) FINISH: The completed order needs to be queried separately.
	        /// </summary>
	        [XmlElement("order_status")]
	        public string OrderStatus { get; set; }
	
	        /// <summary>
	        /// Query order information in multiple order status. For specific order status, see order_status description.
	        /// </summary>
	        [XmlArray("order_status_list")]
	        [XmlArrayItem("string")]
	        public List<string> OrderStatusList { get; set; }
	
	        /// <summary>
	        /// Number of pages per page
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
}

        #endregion
    }
}
