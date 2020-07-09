using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.trade.seller.order.refusecancel
    /// </summary>
    public class AliexpressTradeSellerOrderRefusecancelRequest : BaseTopRequest<Top.Api.Response.AliexpressTradeSellerOrderRefusecancelResponse>
    {
        /// <summary>
        /// 入参如下
        /// </summary>
        public string ParamOrderCancelRequest { get; set; }

        public AeopOrderCancelRequestDomain ParamOrderCancelRequest_ { set { this.ParamOrderCancelRequest = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.trade.seller.order.refusecancel";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param_order_cancel_request", this.ParamOrderCancelRequest);
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
/// AeopOrderCancelRequestDomain Data Structure.
/// </summary>
[Serializable]

public class AeopOrderCancelRequestDomain : TopObject
{
	        /// <summary>
	        /// 买家登录帐号
	        /// </summary>
	        [XmlElement("buyer_login_id")]
	        public string BuyerLoginId { get; set; }
	
	        /// <summary>
	        /// 拒绝原因
	        /// </summary>
	        [XmlElement("memo")]
	        public string Memo { get; set; }
	
	        /// <summary>
	        /// 订单id
	        /// </summary>
	        [XmlElement("order_id")]
	        public Nullable<long> OrderId { get; set; }
}

        #endregion
    }
}
