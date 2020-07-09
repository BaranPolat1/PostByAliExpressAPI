using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.trade.redefining.findorderlistsimplequery
    /// </summary>
    public class AliexpressTradeRedefiningFindorderlistsimplequeryRequest : BaseTopRequest<Top.Api.Response.AliexpressTradeRedefiningFindorderlistsimplequeryResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Param1 { get; set; }

        public OrderListRequestDomain Param1_ { set { this.Param1 = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.trade.redefining.findorderlistsimplequery";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param1", this.Param1);
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
/// OrderListRequestDomain Data Structure.
/// </summary>
[Serializable]

public class OrderListRequestDomain : TopObject
{
	        /// <summary>
	        /// 订单创建时间结束值，格式: yyyy-MM-dd hh:MM:ss,如2015-07-10 00:00:00 倘若时间维度未精确到时分秒，故该时间条件筛选不许生效。此入参时间为美国太平洋时间。
	        /// </summary>
	        [XmlElement("create_date_end")]
	        public string CreateDateEnd { get; set; }
	
	        /// <summary>
	        /// 订单创建时间起始值，格式: yyyy-MM-dd hh:MM:ss,如2015-07-09 00:00:00 倘若时间维度未精确到时分秒，故该时间条件筛选不许生效。此入参为美国太平洋时间。
	        /// </summary>
	        [XmlElement("create_date_start")]
	        public string CreateDateStart { get; set; }
	
	        /// <summary>
	        /// 订单状态： PLACE_ORDER_SUCCESS:等待买家付款; IN_CANCEL:买家申请取消; WAIT_SELLER_SEND_GOODS:等待您发货; SELLER_PART_SEND_GOODS:部分发货; WAIT_BUYER_ACCEPT_GOODS:等待买家收货; FUND_PROCESSING:买家确认收货后，等待退放款处理的状态; FINISH:已结束的订单; IN_ISSUE:含纠纷的订单; IN_FROZEN:冻结中的订单; WAIT_SELLER_EXAMINE_MONEY:等待您确认金额; RISK_CONTROL:订单处于风控24小时中，从买家在线支付完成后开始，持续24小时。
	        /// </summary>
	        [XmlElement("order_status")]
	        public string OrderStatus { get; set; }
	
	        /// <summary>
	        /// 查询多个订单状态下的订单信息，具体订单状态见order_status详情。
	        /// </summary>
	        [XmlArray("order_status_list")]
	        [XmlArrayItem("json")]
	        public List<string> OrderStatusList { get; set; }
	
	        /// <summary>
	        /// 当前页码
	        /// </summary>
	        [XmlElement("page")]
	        public Nullable<long> Page { get; set; }
	
	        /// <summary>
	        /// 每页订单数，最大50
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
}

        #endregion
    }
}
