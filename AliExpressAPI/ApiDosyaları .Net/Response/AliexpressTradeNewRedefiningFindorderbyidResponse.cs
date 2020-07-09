using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressTradeNewRedefiningFindorderbyidResponse.
    /// </summary>
    public class AliexpressTradeNewRedefiningFindorderbyidResponse : TopResponse
    {
        /// <summary>
        /// 订单详情
        /// </summary>
        [XmlElement("target")]
        public AeopTpOrderDetailDtoDomain Target { get; set; }

        /// <summary>
        /// timeStamp
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }

	/// <summary>
/// AeopTpPersonDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopTpPersonDtoDomain : TopObject
{
	        /// <summary>
	        /// 国家/地区
	        /// </summary>
	        [XmlElement("country")]
	        public string Country { get; set; }
	
	        /// <summary>
	        /// first name
	        /// </summary>
	        [XmlElement("first_name")]
	        public string FirstName { get; set; }
	
	        /// <summary>
	        /// last name
	        /// </summary>
	        [XmlElement("last_name")]
	        public string LastName { get; set; }
	
	        /// <summary>
	        /// 登录id
	        /// </summary>
	        [XmlElement("login_id")]
	        public string LoginId { get; set; }
}

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
	        /// 默认最小精确度
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
/// MoneyStrDomain Data Structure.
/// </summary>
[Serializable]

public class MoneyStrDomain : TopObject
{
	        /// <summary>
	        /// 金额（mount=cent/cant_factor）
	        /// </summary>
	        [XmlElement("amount")]
	        public string Amount { get; set; }
	
	        /// <summary>
	        /// 最小货币单位（例如人民币：分）
	        /// </summary>
	        [XmlElement("cent")]
	        public long Cent { get; set; }
	
	        /// <summary>
	        /// 到最小货币单元的乘积因子（例如人民币：100）
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
/// AeopTpOrderProductInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopTpOrderProductInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// 商品ID
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
	
	        /// <summary>
	        /// 商品名称
	        /// </summary>
	        [XmlElement("product_name")]
	        public string ProductName { get; set; }
	
	        /// <summary>
	        /// 商品数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public long Quantity { get; set; }
	
	        /// <summary>
	        /// 商品SKU
	        /// </summary>
	        [XmlElement("sku")]
	        public string Sku { get; set; }
	
	        /// <summary>
	        /// 商品单价
	        /// </summary>
	        [XmlElement("unit_price")]
	        public MoneyStrDomain UnitPrice { get; set; }
}

	/// <summary>
/// AeopTpIssueInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopTpIssueInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// 纠纷类型
	        /// </summary>
	        [XmlElement("issue_model")]
	        public string IssueModel { get; set; }
	
	        /// <summary>
	        /// 纠纷状态 处理中 processing、 纠纷取消canceled_issue、纠纷完结,退款处理完成finish
	        /// </summary>
	        [XmlElement("issue_status")]
	        public string IssueStatus { get; set; }
	
	        /// <summary>
	        /// 纠纷创建时间
	        /// </summary>
	        [XmlElement("issue_time")]
	        public string IssueTime { get; set; }
}

	/// <summary>
/// AeopTpLoanInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopTpLoanInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// 子订单放款金额
	        /// </summary>
	        [XmlElement("loan_amount")]
	        public MoneyStrDomain LoanAmount { get; set; }
	
	        /// <summary>
	        /// 放款时间 (此时间为美国太平洋时间）
	        /// </summary>
	        [XmlElement("loan_time")]
	        public string LoanTime { get; set; }
}

	/// <summary>
/// AeopTpRefundInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopTpRefundInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// 退款现金金额(不包括coupon)
	        /// </summary>
	        [XmlElement("refund_cash_amt")]
	        public MoneyStrDomain RefundCashAmt { get; set; }
	
	        /// <summary>
	        /// 退款coupon金额
	        /// </summary>
	        [XmlElement("refund_coupon_amt")]
	        public MoneyStrDomain RefundCouponAmt { get; set; }
	
	        /// <summary>
	        /// 退款原因
	        /// </summary>
	        [XmlElement("refund_reason")]
	        public string RefundReason { get; set; }
	
	        /// <summary>
	        /// 退款状态：等待退款 wait_refund,退款成功 refund_ok, 退款取消refund_cancel,  关闭 close, 退款冻结 refund_frozen
	        /// </summary>
	        [XmlElement("refund_status")]
	        public string RefundStatus { get; set; }
	
	        /// <summary>
	        /// 退款时间（此时间为美国太平洋时间）
	        /// </summary>
	        [XmlElement("refund_time")]
	        public string RefundTime { get; set; }
	
	        /// <summary>
	        /// 退款类型：售后退款 c,售中退款 sale_refund，赔付退款 payout_refund
	        /// </summary>
	        [XmlElement("refund_type")]
	        public string RefundType { get; set; }
}

	/// <summary>
/// AeopTpChildOrderDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopTpChildOrderDtoDomain : TopObject
{
	        /// <summary>
	        /// 联盟佣金比例
	        /// </summary>
	        [XmlElement("afflicate_fee_rate")]
	        public string AfflicateFeeRate { get; set; }
	
	        /// <summary>
	        /// 买家备注(子订单级别)
	        /// </summary>
	        [XmlElement("buyer_memo")]
	        public string BuyerMemo { get; set; }
	
	        /// <summary>
	        /// 纠纷信息
	        /// </summary>
	        [XmlElement("child_issue_info")]
	        public AeopTpIssueInfoDtoDomain ChildIssueInfo { get; set; }
	
	        /// <summary>
	        /// 子订单ID
	        /// </summary>
	        [XmlElement("child_order_id")]
	        public string ChildOrderId { get; set; }
	
	        /// <summary>
	        /// 交易佣金比例
	        /// </summary>
	        [XmlElement("escrow_fee_rate")]
	        public string EscrowFeeRate { get; set; }
	
	        /// <summary>
	        /// 冻结状态（NO_FROZEN:未冻结；IN_FROZEN:冻结中）
	        /// </summary>
	        [XmlElement("frozen_status")]
	        public string FrozenStatus { get; set; }
	
	        /// <summary>
	        /// 资金状态(NOT_PAY：待支付；PAY_SUCCESS:支付成功)
	        /// </summary>
	        [XmlElement("fund_status")]
	        public string FundStatus { get; set; }
	
	        /// <summary>
	        /// 备货时间
	        /// </summary>
	        [XmlElement("goods_prepare_time")]
	        public long GoodsPrepareTime { get; set; }
	
	        /// <summary>
	        /// 订单ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 订单原始总金额
	        /// </summary>
	        [XmlElement("init_order_amt")]
	        public MoneyStrDomain InitOrderAmt { get; set; }
	
	        /// <summary>
	        /// 纠纷状态
	        /// </summary>
	        [XmlElement("issue_status")]
	        public string IssueStatus { get; set; }
	
	        /// <summary>
	        /// 子订单放款信息
	        /// </summary>
	        [XmlElement("loan_info")]
	        public AeopTpLoanInfoDtoDomain LoanInfo { get; set; }
	
	        /// <summary>
	        /// 放款金额
	        /// </summary>
	        [XmlElement("logistics_amount")]
	        public MoneyStrDomain LogisticsAmount { get; set; }
	
	        /// <summary>
	        /// 物流服务
	        /// </summary>
	        [XmlElement("logistics_service_name")]
	        public string LogisticsServiceName { get; set; }
	
	        /// <summary>
	        /// 物流类型，买家选择的物流方式
	        /// </summary>
	        [XmlElement("logistics_type")]
	        public string LogisticsType { get; set; }
	
	        /// <summary>
	        /// cainiaoInternationalWarehouse表示是菜鸟认证海外仓发货的，这类订单（子订单）将由菜鸟系统下发海外仓系统，进行订单履行，商家ERP需进行过滤此类型的订单（子订单）。其他情况为空
	        /// </summary>
	        [XmlElement("logistics_warehouse_type")]
	        public string LogisticsWarehouseType { get; set; }
	
	        /// <summary>
	        /// 每个piece或lot对应多少个产品
	        /// </summary>
	        [XmlElement("lot_num")]
	        public long LotNum { get; set; }
	
	        /// <summary>
	        /// 子订单序号，用于子订单发货，即sub_trade_order_index
	        /// </summary>
	        [XmlElement("order_sort_id")]
	        public long OrderSortId { get; set; }
	
	        /// <summary>
	        /// 订单状态：PLACE_ORDER_SUCCESS:等待买家付款;  IN_CANCEL:买家申请取消;  WAIT_SELLER_SEND_GOODS:等待您发货;  SELLER_PART_SEND_GOODS:部分发货;  WAIT_BUYER_ACCEPT_GOODS:等待买家收货;  FUND_PROCESSING:买卖家达成一致，资金处理中；  IN_ISSUE:含纠纷中的订单;  IN_FROZEN:冻结中的订单;  WAIT_SELLER_EXAMINE_MONEY:等待您确认金额;  RISK_CONTROL:订单处于风控24小时中，从买家在线支付完成后开始，持续24小时。
	        /// </summary>
	        [XmlElement("order_status")]
	        public string OrderStatus { get; set; }
	
	        /// <summary>
	        /// 商品扩展属性，skuid等
	        /// </summary>
	        [XmlElement("product_attributes")]
	        public string ProductAttributes { get; set; }
	
	        /// <summary>
	        /// 商品数量
	        /// </summary>
	        [XmlElement("product_count")]
	        public long ProductCount { get; set; }
	
	        /// <summary>
	        /// 商品ID
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
	
	        /// <summary>
	        /// 商品主图Url
	        /// </summary>
	        [XmlElement("product_img_url")]
	        public string ProductImgUrl { get; set; }
	
	        /// <summary>
	        /// 商品名称
	        /// </summary>
	        [XmlElement("product_name")]
	        public string ProductName { get; set; }
	
	        /// <summary>
	        /// 商品单价
	        /// </summary>
	        [XmlElement("product_price")]
	        public MoneyStrDomain ProductPrice { get; set; }
	
	        /// <summary>
	        /// 快照Url
	        /// </summary>
	        [XmlElement("product_snap_url")]
	        public string ProductSnapUrl { get; set; }
	
	        /// <summary>
	        /// 商品规格，已废弃
	        /// </summary>
	        [XmlElement("product_standard")]
	        public string ProductStandard { get; set; }
	
	        /// <summary>
	        /// 产品单位
	        /// </summary>
	        [XmlElement("product_unit")]
	        public string ProductUnit { get; set; }
	
	        /// <summary>
	        /// 子订单退款信息
	        /// </summary>
	        [XmlElement("refund_info")]
	        public AeopTpRefundInfoDtoDomain RefundInfo { get; set; }
	
	        /// <summary>
	        /// 发货类型"SELLER_SEND_GOODS": 卖家发货; "WAREHOUSE_SEND_GOODS":仓库发货
	        /// </summary>
	        [XmlElement("send_goods_operator")]
	        public string SendGoodsOperator { get; set; }
	
	        /// <summary>
	        /// SKU信息
	        /// </summary>
	        [XmlElement("sku_code")]
	        public string SkuCode { get; set; }
	
	        /// <summary>
	        /// 快照ID
	        /// </summary>
	        [XmlElement("snapshot_id")]
	        public string SnapshotId { get; set; }
	
	        /// <summary>
	        /// 产品快照的图片路径
	        /// </summary>
	        [XmlElement("snapshot_small_photo_path")]
	        public string SnapshotSmallPhotoPath { get; set; }
	
	        /// <summary>
	        /// 子订单中的各种标
	        /// </summary>
	        [XmlArray("tags")]
	        [XmlArrayItem("string")]
	        public List<string> Tags { get; set; }
}

	/// <summary>
/// AeopTpLogisticInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopTpLogisticInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// 妥投时间（此时间为美国太平洋时间）
	        /// </summary>
	        [XmlElement("gmt_received")]
	        public string GmtReceived { get; set; }
	
	        /// <summary>
	        /// 发货时间（此时间为美国太平洋时间）
	        /// </summary>
	        [XmlElement("gmt_send")]
	        public string GmtSend { get; set; }
	
	        /// <summary>
	        /// 是否可获取物流追踪信息
	        /// </summary>
	        [XmlElement("have_tracking_info")]
	        public bool HaveTrackingInfo { get; set; }
	
	        /// <summary>
	        /// 物流追踪号
	        /// </summary>
	        [XmlElement("logistics_no")]
	        public string LogisticsNo { get; set; }
	
	        /// <summary>
	        /// 发货物流服务展示线路英文名称
	        /// </summary>
	        [XmlElement("logistics_service_name")]
	        public string LogisticsServiceName { get; set; }
	
	        /// <summary>
	        /// 物流服务名称key(与声明发货中的service_name相同)
	        /// </summary>
	        [XmlElement("logistics_type_code")]
	        public string LogisticsTypeCode { get; set; }
	
	        /// <summary>
	        /// 投递状态。(default:初始值; received:已经妥投; not_received:没有妥投; suspected_received:疑似妥投)
	        /// </summary>
	        [XmlElement("receive_status")]
	        public string ReceiveStatus { get; set; }
	
	        /// <summary>
	        /// 未妥投原因，如国家/地区不匹配
	        /// </summary>
	        [XmlElement("recv_status_desc")]
	        public string RecvStatusDesc { get; set; }
	
	        /// <summary>
	        /// 物流订单ID
	        /// </summary>
	        [XmlElement("ship_order_id")]
	        public long ShipOrderId { get; set; }
}

	/// <summary>
/// AeopTpOperationLogDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopTpOperationLogDtoDomain : TopObject
{
	        /// <summary>
	        /// 操作类型，用于记录操作事件。可能值为front_create_order, front_seller_send_all_goods, front_seller_send_part_goods, front_pay_online_success, front_trade_completed, front_trade_success, trade_close, front_buyerComfirmAcceptGoods, front_sellerAnnounceSendGoods, front_paypal_pay_success, front_pay_wu_success, front_pay_qw_success, front_mb_pay_success, cancel_order_close_trade, buyer_close_cancel, pledge_refund_ing, pledge_refund_fail, pledge_refund_success, pledge_issue_buyer_create, pledge_issue_buyer_modify, pledge_issue_buyer_accept, pledge_issue_buyer_cancel, pledge_issue_cs_cancel_money, risk_control_pass, buyer_cancle_group_after_payment, group_success, group_failure, buyer_cancle_group_after_payment, presell_promotion_end
	        /// </summary>
	        [XmlElement("action_type")]
	        public string ActionType { get; set; }
	
	        /// <summary>
	        /// 子订单ID
	        /// </summary>
	        [XmlElement("child_order_id")]
	        public long ChildOrderId { get; set; }
	
	        /// <summary>
	        /// 创建时间（此时间为美国太平洋时间）
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 修改时间（此时间为美国太平洋时间）
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 操作备注
	        /// </summary>
	        [XmlElement("memo")]
	        public string Memo { get; set; }
	
	        /// <summary>
	        /// 操作者
	        /// </summary>
	        [XmlElement("operator")]
	        public string Operator { get; set; }
	
	        /// <summary>
	        /// 订单ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
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
	        /// 最小货币单位（例如人民币：分）
	        /// </summary>
	        [XmlElement("cent")]
	        public long Cent { get; set; }
	
	        /// <summary>
	        /// 到最小货币单元的乘积因子（例如人民币：100）
	        /// </summary>
	        [XmlElement("cent_factor")]
	        public long CentFactor { get; set; }
	
	        /// <summary>
	        /// 货币描述
	        /// </summary>
	        [XmlElement("currency")]
	        public CurrencyDomain Currency { get; set; }
	
	        /// <summary>
	        /// 币种
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
}

	/// <summary>
/// AeopTpOrderMsgDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopTpOrderMsgDtoDomain : TopObject
{
	        /// <summary>
	        /// 订单号
	        /// </summary>
	        [XmlElement("business_order_id")]
	        public long BusinessOrderId { get; set; }
	
	        /// <summary>
	        /// 留言内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 修改时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 信息发送方( buyer; seller)
	        /// </summary>
	        [XmlElement("poster")]
	        public string Poster { get; set; }
	
	        /// <summary>
	        /// 接收者主帐号序号
	        /// </summary>
	        [XmlElement("receiver_admin_seq")]
	        public long ReceiverAdminSeq { get; set; }
	
	        /// <summary>
	        /// 接收者FirstName
	        /// </summary>
	        [XmlElement("receiver_first_name")]
	        public string ReceiverFirstName { get; set; }
	
	        /// <summary>
	        /// 接收者LastName
	        /// </summary>
	        [XmlElement("receiver_last_name")]
	        public string ReceiverLastName { get; set; }
	
	        /// <summary>
	        /// 接收者帐号ID
	        /// </summary>
	        [XmlElement("receiver_login_id")]
	        public string ReceiverLoginId { get; set; }
	
	        /// <summary>
	        /// 接收者帐号序号
	        /// </summary>
	        [XmlElement("receiver_seq")]
	        public long ReceiverSeq { get; set; }
	
	        /// <summary>
	        /// 发送者主帐号序号
	        /// </summary>
	        [XmlElement("sender_admin_seq")]
	        public long SenderAdminSeq { get; set; }
	
	        /// <summary>
	        /// 发送者FirstName
	        /// </summary>
	        [XmlElement("sender_first_name")]
	        public string SenderFirstName { get; set; }
	
	        /// <summary>
	        /// 发送者LastName
	        /// </summary>
	        [XmlElement("sender_last_name")]
	        public string SenderLastName { get; set; }
	
	        /// <summary>
	        /// 发送者帐号ID
	        /// </summary>
	        [XmlElement("sender_login_id")]
	        public string SenderLoginId { get; set; }
	
	        /// <summary>
	        /// 发送者帐号序号
	        /// </summary>
	        [XmlElement("sender_seq")]
	        public long SenderSeq { get; set; }
	
	        /// <summary>
	        /// 留言状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
}

	/// <summary>
/// AeopTpAddressDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopTpAddressDtoDomain : TopObject
{
	        /// <summary>
	        /// 地址1
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 地址2
	        /// </summary>
	        [XmlElement("address2")]
	        public string Address2 { get; set; }
	
	        /// <summary>
	        /// 城市
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// 收件人
	        /// </summary>
	        [XmlElement("contact_person")]
	        public string ContactPerson { get; set; }
	
	        /// <summary>
	        /// 国家/地区
	        /// </summary>
	        [XmlElement("country")]
	        public string Country { get; set; }
	
	        /// <summary>
	        /// 街道详细地址
	        /// </summary>
	        [XmlElement("detail_address")]
	        public string DetailAddress { get; set; }
	
	        /// <summary>
	        /// 传真号
	        /// </summary>
	        [XmlElement("fax_area")]
	        public string FaxArea { get; set; }
	
	        /// <summary>
	        /// 传真国家/地区码
	        /// </summary>
	        [XmlElement("fax_country")]
	        public string FaxCountry { get; set; }
	
	        /// <summary>
	        /// 传真号
	        /// </summary>
	        [XmlElement("fax_number")]
	        public string FaxNumber { get; set; }
	
	        /// <summary>
	        /// 手机号
	        /// </summary>
	        [XmlElement("mobile_no")]
	        public string MobileNo { get; set; }
	
	        /// <summary>
	        /// 区号
	        /// </summary>
	        [XmlElement("phone_area")]
	        public string PhoneArea { get; set; }
	
	        /// <summary>
	        /// 国家/地区码
	        /// </summary>
	        [XmlElement("phone_country")]
	        public string PhoneCountry { get; set; }
	
	        /// <summary>
	        /// 电话
	        /// </summary>
	        [XmlElement("phone_number")]
	        public string PhoneNumber { get; set; }
	
	        /// <summary>
	        /// 省份
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// 邮编
	        /// </summary>
	        [XmlElement("zip")]
	        public string Zip { get; set; }
}

	/// <summary>
/// SimpleMoneyDomain Data Structure.
/// </summary>
[Serializable]

public class SimpleMoneyDomain : TopObject
{
	        /// <summary>
	        /// 金额
	        /// </summary>
	        [XmlElement("amount")]
	        public string Amount { get; set; }
	
	        /// <summary>
	        /// 币种
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
}

	/// <summary>
/// AeopTpOrderDetailDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopTpOrderDetailDtoDomain : TopObject
{
	        /// <summary>
	        /// 买家信息
	        /// </summary>
	        [XmlElement("buyer_info")]
	        public AeopTpPersonDtoDomain BuyerInfo { get; set; }
	
	        /// <summary>
	        /// 买家全名
	        /// </summary>
	        [XmlElement("buyer_signer_fullname")]
	        public string BuyerSignerFullname { get; set; }
	
	        /// <summary>
	        /// 买家登录id
	        /// </summary>
	        [XmlElement("buyerloginid")]
	        public string Buyerloginid { get; set; }
	
	        /// <summary>
	        /// 买家申请取消订单的原因，仅对取消中的订单有效
	        /// </summary>
	        [XmlElement("cancel_request_reason")]
	        public string CancelRequestReason { get; set; }
	
	        /// <summary>
	        /// 商品信息
	        /// </summary>
	        [XmlArray("child_order_ext_info_list")]
	        [XmlArrayItem("aeop_tp_order_product_info_dto")]
	        public List<AeopTpOrderProductInfoDtoDomain> ChildOrderExtInfoList { get; set; }
	
	        /// <summary>
	        /// 子订单列表
	        /// </summary>
	        [XmlArray("child_order_list")]
	        [XmlArrayItem("aeop_tp_child_order_dto")]
	        public List<AeopTpChildOrderDtoDomain> ChildOrderList { get; set; }
	
	        /// <summary>
	        /// 是否是货到付款订单
	        /// </summary>
	        [XmlElement("cod")]
	        public bool Cod { get; set; }
	
	        /// <summary>
	        /// 手续费（已废弃）
	        /// </summary>
	        [XmlElement("escrow_fee")]
	        public MoneyStrDomain EscrowFee { get; set; }
	
	        /// <summary>
	        /// 冻结状态
	        /// </summary>
	        [XmlElement("frozen_status")]
	        public string FrozenStatus { get; set; }
	
	        /// <summary>
	        /// 资金状态
	        /// </summary>
	        [XmlElement("fund_status")]
	        public string FundStatus { get; set; }
	
	        /// <summary>
	        /// 订单创建时间(此时间为美国太平洋时间)
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 订单修改时间(此时间为美国太平洋时间)
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 支付成功时间（与订单列表中gmtPayTime字段意义相同）(此时间为美国太平洋时间)
	        /// </summary>
	        [XmlElement("gmt_pay_success")]
	        public string GmtPaySuccess { get; set; }
	
	        /// <summary>
	        /// 订单结束时间(此时间为美国太平洋时间)
	        /// </summary>
	        [XmlElement("gmt_trade_end")]
	        public string GmtTradeEnd { get; set; }
	
	        /// <summary>
	        /// 订单ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 产品总金额
	        /// </summary>
	        [XmlElement("init_oder_amount")]
	        public MoneyStrDomain InitOderAmount { get; set; }
	
	        /// <summary>
	        /// 是否手机订单
	        /// </summary>
	        [XmlElement("is_phone")]
	        public bool IsPhone { get; set; }
	
	        /// <summary>
	        /// 纠纷信息
	        /// </summary>
	        [XmlElement("issue_info")]
	        public AeopTpIssueInfoDtoDomain IssueInfo { get; set; }
	
	        /// <summary>
	        /// 纠纷状态（IN_ISSUE:纠纷中，NO_ISSUE:无纠纷;END_ISSUE:纠纷结束）
	        /// </summary>
	        [XmlElement("issue_status")]
	        public string IssueStatus { get; set; }
	
	        /// <summary>
	        /// 放款信息
	        /// </summary>
	        [XmlElement("loan_info")]
	        public AeopTpLoanInfoDtoDomain LoanInfo { get; set; }
	
	        /// <summary>
	        /// 放款状态("loan_none":无放款;"wait_loan":等待放款;"loan_ok":放款成功)
	        /// </summary>
	        [XmlElement("loan_status")]
	        public string LoanStatus { get; set; }
	
	        /// <summary>
	        /// 运费佣金比例(已废弃)
	        /// </summary>
	        [XmlElement("logisitcs_escrow_fee_rate")]
	        public string LogisitcsEscrowFeeRate { get; set; }
	
	        /// <summary>
	        /// 物流信息
	        /// </summary>
	        [XmlArray("logistic_info_list")]
	        [XmlArrayItem("aeop_tp_logistic_info_dto")]
	        public List<AeopTpLogisticInfoDtoDomain> LogisticInfoList { get; set; }
	
	        /// <summary>
	        /// 物流费用
	        /// </summary>
	        [XmlElement("logistics_amount")]
	        public MoneyStrDomain LogisticsAmount { get; set; }
	
	        /// <summary>
	        /// 物流状态：NO_LOGISTICS 无物流信息、等待卖家发货 WAIT_SELLER_SEND_GOODS,卖家部分发货 SELLER_SEND_PART_GOODS,卖家已发货  SELLER_SEND_GOODS,买家已确认收货  BUYER_ACCEPT_GOODS,NO_LOGISTICS
	        /// </summary>
	        [XmlElement("logistics_status")]
	        public string LogisticsStatus { get; set; }
	
	        /// <summary>
	        /// 买家备注（订单级别）
	        /// </summary>
	        [XmlElement("memo")]
	        public string Memo { get; set; }
	
	        /// <summary>
	        /// 新订单金额，比order_amount更准确，考虑了卖家调价及COD费用。仅限于新订单（7.18-7.31期间创建的部分订单及8.1以后创建的所有订单）。
	        /// </summary>
	        [XmlElement("new_order_amount")]
	        public SimpleMoneyDomain NewOrderAmount { get; set; }
	
	        /// <summary>
	        /// 操作日志列表
	        /// </summary>
	        [XmlArray("opr_log_dto_list")]
	        [XmlArrayItem("aeop_tp_operation_log_dto")]
	        public List<AeopTpOperationLogDtoDomain> OprLogDtoList { get; set; }
	
	        /// <summary>
	        /// 订单金额
	        /// </summary>
	        [XmlElement("order_amount")]
	        public MoneyDomain OrderAmount { get; set; }
	
	        /// <summary>
	        /// 订单结束原因
	        /// </summary>
	        [XmlElement("order_end_reason")]
	        public string OrderEndReason { get; set; }
	
	        /// <summary>
	        /// 留言信息（已废弃）
	        /// </summary>
	        [XmlArray("order_msg_list")]
	        [XmlArrayItem("aeop_tp_order_msg_dto")]
	        public List<AeopTpOrderMsgDtoDomain> OrderMsgList { get; set; }
	
	        /// <summary>
	        /// 订单状态
	        /// </summary>
	        [XmlElement("order_status")]
	        public string OrderStatus { get; set; }
	
	        /// <summary>
	        /// 当前状态超时日期 （此时间为美国太平洋时间）
	        /// </summary>
	        [XmlElement("over_time_left")]
	        public string OverTimeLeft { get; set; }
	
	        /// <summary>
	        /// 买家支付金额(结算币种)
	        /// </summary>
	        [XmlElement("pay_amount_by_settlement_cur")]
	        public string PayAmountBySettlementCur { get; set; }
	
	        /// <summary>
	        /// 付款方式 （migs信用卡支付走人民币渠道； migs102MasterCard支付并且走人民币渠道； migs101Visa支付并且走人民币渠道； pp101 PayPal； mb MoneyBooker渠道； tt101 Bank Transfer支付； wu101 West Union支付； wp101 Visa走美金渠道的支付； wp102 Mastercard 走美金渠道的支付； qw101 QIWI支付； cybs101 Visa走CYBS渠道的支付； cybs102 Mastercard 走CYBS渠道的支付； wm101 WebMoney支付； ebanx101 巴西Beloto支付 ；）
	        /// </summary>
	        [XmlElement("payment_type")]
	        public string PaymentType { get; set; }
	
	        /// <summary>
	        /// 收货地址信息
	        /// </summary>
	        [XmlElement("receipt_address")]
	        public AeopTpAddressDtoDomain ReceiptAddress { get; set; }
	
	        /// <summary>
	        /// 退款信息
	        /// </summary>
	        [XmlElement("refund_info")]
	        public AeopTpRefundInfoDtoDomain RefundInfo { get; set; }
	
	        /// <summary>
	        /// 卖家操作员Ali id
	        /// </summary>
	        [XmlElement("seller_operator_aliidloginid")]
	        public string SellerOperatorAliidloginid { get; set; }
	
	        /// <summary>
	        /// 卖家操作员登录ID
	        /// </summary>
	        [XmlElement("seller_operator_login_id")]
	        public string SellerOperatorLoginId { get; set; }
	
	        /// <summary>
	        /// 卖家名称
	        /// </summary>
	        [XmlElement("seller_signer_fullname")]
	        public string SellerSignerFullname { get; set; }
	
	        /// <summary>
	        /// 支付金额结算币种
	        /// </summary>
	        [XmlElement("settlement_currency")]
	        public string SettlementCurrency { get; set; }
}

    }
}
