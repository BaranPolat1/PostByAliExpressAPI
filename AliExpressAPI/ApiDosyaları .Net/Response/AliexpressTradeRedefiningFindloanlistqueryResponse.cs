using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressTradeRedefiningFindloanlistqueryResponse.
    /// </summary>
    public class AliexpressTradeRedefiningFindloanlistqueryResponse : TopResponse
    {
        /// <summary>
        /// 出参
        /// </summary>
        [XmlElement("result")]
        public FundLoanListVoDomain Result { get; set; }

	/// <summary>
/// CurrencyDomain Data Structure.
/// </summary>
[Serializable]

public class CurrencyDomain : TopObject
{
	        /// <summary>
	        /// 币种
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
	
	        /// <summary>
	        /// 默认最小精确度（精确到的小数点位数）
	        /// </summary>
	        [XmlElement("default_fraction_digits")]
	        public long DefaultFractionDigits { get; set; }
	
	        /// <summary>
	        /// 币种名称
	        /// </summary>
	        [XmlElement("display_name")]
	        public string DisplayName { get; set; }
	
	        /// <summary>
	        /// 币种数字编码
	        /// </summary>
	        [XmlElement("numeric_code")]
	        public long NumericCode { get; set; }
	
	        /// <summary>
	        /// 币种符号
	        /// </summary>
	        [XmlElement("symbol")]
	        public string Symbol { get; set; }
}

	/// <summary>
/// MoneyDomain Data Structure.
/// </summary>
[Serializable]

public class MoneyDomain : TopObject
{
	        /// <summary>
	        /// 金额
	        /// </summary>
	        [XmlElement("amount")]
	        public string Amount { get; set; }
	
	        /// <summary>
	        /// 分
	        /// </summary>
	        [XmlElement("cent")]
	        public long Cent { get; set; }
	
	        /// <summary>
	        /// 到最小货币单元的乘积因子
	        /// </summary>
	        [XmlElement("cent_factor")]
	        public long CentFactor { get; set; }
	
	        /// <summary>
	        /// 货币描述
	        /// </summary>
	        [XmlElement("currency")]
	        public CurrencyDomain Currency { get; set; }
	
	        /// <summary>
	        /// 币种USD/RUB
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
}

	/// <summary>
/// SonOrderLoanVoDomain Data Structure.
/// </summary>
[Serializable]

public class SonOrderLoanVoDomain : TopObject
{
	        /// <summary>
	        /// 联盟佣金
	        /// </summary>
	        [XmlElement("affiliate_commission")]
	        public MoneyDomain AffiliateCommission { get; set; }
	
	        /// <summary>
	        /// 放款金额(已废弃)
	        /// </summary>
	        [XmlElement("amount")]
	        public MoneyDomain Amount { get; set; }
	
	        /// <summary>
	        /// 子订单ID
	        /// </summary>
	        [XmlElement("child_order_id")]
	        public long ChildOrderId { get; set; }
	
	        /// <summary>
	        /// 手续费
	        /// </summary>
	        [XmlElement("escrow_fee")]
	        public MoneyDomain EscrowFee { get; set; }
	
	        /// <summary>
	        /// 放款金额
	        /// </summary>
	        [XmlElement("loan_amount")]
	        public MoneyDomain LoanAmount { get; set; }
	
	        /// <summary>
	        /// 放款状态
	        /// </summary>
	        [XmlElement("loan_status")]
	        public string LoanStatus { get; set; }
	
	        /// <summary>
	        /// 实际放款出账金额
	        /// </summary>
	        [XmlElement("real_loan_amount")]
	        public MoneyDomain RealLoanAmount { get; set; }
	
	        /// <summary>
	        /// 实际退款出账金额
	        /// </summary>
	        [XmlElement("real_refund_amount")]
	        public MoneyDomain RealRefundAmount { get; set; }
	
	        /// <summary>
	        /// 退款金额
	        /// </summary>
	        [XmlElement("refund_amount")]
	        public MoneyDomain RefundAmount { get; set; }
	
	        /// <summary>
	        /// 放款时间（不返回）
	        /// </summary>
	        [XmlElement("released_datetime")]
	        public string ReleasedDatetime { get; set; }
	
	        /// <summary>
	        /// 待放款原因
	        /// </summary>
	        [XmlElement("wait_loan_reson")]
	        public string WaitLoanReson { get; set; }
}

	/// <summary>
/// OrderLoanItemVoDomain Data Structure.
/// </summary>
[Serializable]

public class OrderLoanItemVoDomain : TopObject
{
	        /// <summary>
	        /// 总金额
	        /// </summary>
	        [XmlElement("amount_total")]
	        public MoneyDomain AmountTotal { get; set; }
	
	        /// <summary>
	        /// 订单ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// 订单状态： PLACE_ORDER_SUCCESS:等待买家付款; IN_CANCEL:买家申请取消; WAIT_SELLER_SEND_GOODS:等待您发货; SELLER_PART_SEND_GOODS:部分发货; WAIT_BUYER_ACCEPT_GOODS:等待买家收货; FUND_PROCESSING:买卖家达成一致，资金处理中； IN_ISSUE:含纠纷中的订单; IN_FROZEN:冻结中的订单; WAIT_SELLER_EXAMINE_MONEY:等待您确认金额; RISK_CONTROL:订单处于风控24小时中，从买家在线支付完成后开始，持续24小时。 以上状态查询可分别做单独查询，不传订单状态查询订单信息不包含（FINISH，已结束订单状态） FINISH:已结束的订单，需单独查询。
	        /// </summary>
	        [XmlElement("order_status")]
	        public string OrderStatus { get; set; }
	
	        /// <summary>
	        /// 子订单元素列表
	        /// </summary>
	        [XmlArray("son_order_list")]
	        [XmlArrayItem("son_order_loan_vo")]
	        public List<SonOrderLoanVoDomain> SonOrderList { get; set; }
}

	/// <summary>
/// FundLoanListVoDomain Data Structure.
/// </summary>
[Serializable]

public class FundLoanListVoDomain : TopObject
{
	        /// <summary>
	        /// 订单放款列表
	        /// </summary>
	        [XmlArray("order_list")]
	        [XmlArrayItem("order_loan_item_vo")]
	        public List<OrderLoanItemVoDomain> OrderList { get; set; }
	
	        /// <summary>
	        /// 总条数
	        /// </summary>
	        [XmlElement("total_item")]
	        public long TotalItem { get; set; }
}

    }
}
