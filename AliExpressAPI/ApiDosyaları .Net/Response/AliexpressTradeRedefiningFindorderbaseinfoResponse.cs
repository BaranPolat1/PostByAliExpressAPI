using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressTradeRedefiningFindorderbaseinfoResponse.
    /// </summary>
    public class AliexpressTradeRedefiningFindorderbaseinfoResponse : TopResponse
    {
        /// <summary>
        /// 出参
        /// </summary>
        [XmlElement("result")]
        public OrderBaseInfoDomain Result { get; set; }

	/// <summary>
/// OrderBaseInfoDomain Data Structure.
/// </summary>
[Serializable]

public class OrderBaseInfoDomain : TopObject
{
	        /// <summary>
	        /// 冻结状态("NO_FROZEN":无冻结;"IN_FROZEN":冻结中)
	        /// </summary>
	        [XmlElement("frozen_status")]
	        public string FrozenStatus { get; set; }
	
	        /// <summary>
	        /// 资金状态("NOT_PAY":未付款;"PAY_SUCCESS":付款成功;"WAIT_SELLER_CHECK":等待卖家验款)
	        /// </summary>
	        [XmlElement("fund_status")]
	        public string FundStatus { get; set; }
	
	        /// <summary>
	        /// 订单创建时间，此时间为美国太平洋时间。
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 订单修改时间,此事件为美国太平洋时间。
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 纠纷状态("NO_ISSUE":无纠纷;"IN_ISSUE":纠纷中;"END_ISSUE":纠纷结束)
	        /// </summary>
	        [XmlElement("issue_status")]
	        public string IssueStatus { get; set; }
	
	        /// <summary>
	        /// 订单放款状态("wait_loan":未放款;"loan_ok":已放款)
	        /// </summary>
	        [XmlElement("loan_status")]
	        public string LoanStatus { get; set; }
	
	        /// <summary>
	        /// 物流状态("WAIT_SELLER_SEND_GOODS":等待卖家发货; "SELLER_SEND_PART_GOODS": 卖家部分发货;"SELLER_SEND_GOODS":卖家已发货;"BUYER_ACCEPT_GOODS":买家确认收货;"NO_LOGISTICS":无物流)
	        /// </summary>
	        [XmlElement("logistics_status")]
	        public string LogisticsStatus { get; set; }
	
	        /// <summary>
	        /// 订单状态
	        /// </summary>
	        [XmlElement("order_status")]
	        public string OrderStatus { get; set; }
	
	        /// <summary>
	        /// 负责人账号ID
	        /// </summary>
	        [XmlElement("seller_operator_login_id")]
	        public string SellerOperatorLoginId { get; set; }
	
	        /// <summary>
	        /// 卖家全名
	        /// </summary>
	        [XmlElement("seller_signer_fullname")]
	        public string SellerSignerFullname { get; set; }
}

    }
}
