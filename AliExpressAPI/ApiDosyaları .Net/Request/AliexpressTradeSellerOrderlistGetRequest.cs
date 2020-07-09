using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.trade.seller.orderlist.get
    /// </summary>
    public class AliexpressTradeSellerOrderlistGetRequest : BaseTopRequest<Top.Api.Response.AliexpressTradeSellerOrderlistGetResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string ParamAeopOrderQuery { get; set; }

        public AeopOrderQueryDomain ParamAeopOrderQuery_ { set { this.ParamAeopOrderQuery = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.trade.seller.orderlist.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param_aeop_order_query", this.ParamAeopOrderQuery);
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
/// AeopOrderQueryDomain Data Structure.
/// </summary>
[Serializable]

public class AeopOrderQueryDomain : TopObject
{
	        /// <summary>
	        /// 买家登录id
	        /// </summary>
	        [XmlElement("buyer_login_id")]
	        public string BuyerLoginId { get; set; }
	
	        /// <summary>
	        /// 订单创建时间结束值，格式: yyyy-mm-dd hh:mm:ss,此时间为美国太平洋时间
	        /// </summary>
	        [XmlElement("create_date_end")]
	        public string CreateDateEnd { get; set; }
	
	        /// <summary>
	        /// 订单创建时间起始值 格式: yyyy-mm-dd hh:mm:ss。此时间为美国太平洋时间
	        /// </summary>
	        [XmlElement("create_date_start")]
	        public string CreateDateStart { get; set; }
	
	        /// <summary>
	        /// 页码
	        /// </summary>
	        [XmlElement("current_page")]
	        public Nullable<long> CurrentPage { get; set; }
	
	        /// <summary>
	        /// 订单修改时间结束值，格式: yyyy-mm-dd hh:mm:ss。此时间为美国太平洋时间
	        /// </summary>
	        [XmlElement("modified_date_end")]
	        public string ModifiedDateEnd { get; set; }
	
	        /// <summary>
	        /// 订单修改时间起始值 格式: yyyy-mm-dd hh:mm:ss 需要加上createdate控制查询范围。可查询时间范围；默认180天，查询已结束订单为30天。此时间为美国太平洋时间
	        /// </summary>
	        [XmlElement("modified_date_start")]
	        public string ModifiedDateStart { get; set; }
	
	        /// <summary>
	        /// 订单状态： PLACE_ORDER_SUCCESS:等待买家付款; IN_CANCEL:买家申请取消; WAIT_SELLER_SEND_GOODS:等待您发货; SELLER_PART_SEND_GOODS:部分发货; WAIT_BUYER_ACCEPT_GOODS:等待买家收货; FUND_PROCESSING:买卖家达成一致，资金处理中； IN_ISSUE:含纠纷中的订单; IN_FROZEN:冻结中的订单; WAIT_SELLER_EXAMINE_MONEY:等待您确认金额; RISK_CONTROL:订单处于风控24小时中，从买家在线支付完成后开始，持续24小时。 以上状态查询可分别做单独查询，不传订单状态查询订单信息不包含（FINISH，已结束订单状态） FINISH:已结束的订单，需单独查询。
	        /// </summary>
	        [XmlElement("order_status")]
	        public string OrderStatus { get; set; }
	
	        /// <summary>
	        /// 查询多个订单状态下的订单信息，具体订单状态见order_status描述
	        /// </summary>
	        [XmlArray("order_status_list")]
	        [XmlArrayItem("string")]
	        public List<string> OrderStatusList { get; set; }
	
	        /// <summary>
	        /// 每页条数
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
}

        #endregion
    }
}
