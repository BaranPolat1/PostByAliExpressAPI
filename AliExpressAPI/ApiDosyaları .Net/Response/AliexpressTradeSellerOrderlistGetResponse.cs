using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressTradeSellerOrderlistGetResponse.
    /// </summary>
    public class AliexpressTradeSellerOrderlistGetResponse : TopResponse
    {
        /// <summary>
        /// 出参
        /// </summary>
        [XmlElement("result")]
        public AeopPageResultDtoDomain Result { get; set; }

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
/// AeopOrderProductDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopOrderProductDtoDomain : TopObject
{
	        /// <summary>
	        /// 联盟佣金比例
	        /// </summary>
	        [XmlElement("afflicate_fee_rate")]
	        public string AfflicateFeeRate { get; set; }
	
	        /// <summary>
	        /// 买家firstName
	        /// </summary>
	        [XmlElement("buyer_signer_first_name")]
	        public string BuyerSignerFirstName { get; set; }
	
	        /// <summary>
	        /// 买家lastName
	        /// </summary>
	        [XmlElement("buyer_signer_last_name")]
	        public string BuyerSignerLastName { get; set; }
	
	        /// <summary>
	        /// 子订单是否能提交纠纷
	        /// </summary>
	        [XmlElement("can_submit_issue")]
	        public bool CanSubmitIssue { get; set; }
	
	        /// <summary>
	        /// 子订单id
	        /// </summary>
	        [XmlElement("child_id")]
	        public long ChildId { get; set; }
	
	        /// <summary>
	        /// 妥投时间
	        /// </summary>
	        [XmlElement("delivery_time")]
	        public string DeliveryTime { get; set; }
	
	        /// <summary>
	        /// 交易佣金比例
	        /// </summary>
	        [XmlElement("escrow_fee_rate")]
	        public string EscrowFeeRate { get; set; }
	
	        /// <summary>
	        /// 限时达
	        /// </summary>
	        [XmlElement("freight_commit_day")]
	        public string FreightCommitDay { get; set; }
	
	        /// <summary>
	        /// 资金状态。(NOT_PAY:未付款; PAY_SUCCESS:付款成功; WAIT_SELLER_CHECK:卖家验款)
	        /// </summary>
	        [XmlElement("fund_status")]
	        public string FundStatus { get; set; }
	
	        /// <summary>
	        /// 备货时间
	        /// </summary>
	        [XmlElement("goods_prepare_time")]
	        public long GoodsPrepareTime { get; set; }
	
	        /// <summary>
	        /// 纠纷类型
	        /// </summary>
	        [XmlElement("issue_mode")]
	        public string IssueMode { get; set; }
	
	        /// <summary>
	        /// 纠纷状态。(NO_ISSUE:无纠纷; IN_ISSUE:纠纷中; END_ISSUE:纠纷结束)
	        /// </summary>
	        [XmlElement("issue_status")]
	        public string IssueStatus { get; set; }
	
	        /// <summary>
	        /// 物流费用（子订单没有运费，请忽略）
	        /// </summary>
	        [XmlElement("logistics_amount")]
	        public SimpleMoneyDomain LogisticsAmount { get; set; }
	
	        /// <summary>
	        /// 物流服务
	        /// </summary>
	        [XmlElement("logistics_service_name")]
	        public string LogisticsServiceName { get; set; }
	
	        /// <summary>
	        /// 物流类型
	        /// </summary>
	        [XmlElement("logistics_type")]
	        public string LogisticsType { get; set; }
	
	        /// <summary>
	        /// 买家备注
	        /// </summary>
	        [XmlElement("memo")]
	        public string Memo { get; set; }
	
	        /// <summary>
	        /// 是否假一赔三产品
	        /// </summary>
	        [XmlElement("money_back3x")]
	        public bool MoneyBack3x { get; set; }
	
	        /// <summary>
	        /// 订单id
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// 商品数量
	        /// </summary>
	        [XmlElement("product_count")]
	        public long ProductCount { get; set; }
	
	        /// <summary>
	        /// 商品id
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
	        /// 快照Url
	        /// </summary>
	        [XmlElement("product_snap_url")]
	        public string ProductSnapUrl { get; set; }
	
	        /// <summary>
	        /// 商品规格
	        /// </summary>
	        [XmlElement("product_standard")]
	        public string ProductStandard { get; set; }
	
	        /// <summary>
	        /// 商品单位
	        /// </summary>
	        [XmlElement("product_unit")]
	        public string ProductUnit { get; set; }
	
	        /// <summary>
	        /// 商品单价
	        /// </summary>
	        [XmlElement("product_unit_price")]
	        public SimpleMoneyDomain ProductUnitPrice { get; set; }
	
	        /// <summary>
	        /// 发货者类型。 "SELLER_SEND_GOODS": 卖家发货; "WAREHOUSE_SEND_GOODS":仓库发货
	        /// </summary>
	        [XmlElement("send_goods_operator")]
	        public string SendGoodsOperator { get; set; }
	
	        /// <summary>
	        /// 最后发货时间
	        /// </summary>
	        [XmlElement("send_goods_time")]
	        public string SendGoodsTime { get; set; }
	
	        /// <summary>
	        /// 订单显示状态
	        /// </summary>
	        [XmlElement("show_status")]
	        public string ShowStatus { get; set; }
	
	        /// <summary>
	        /// 商品编码
	        /// </summary>
	        [XmlElement("sku_code")]
	        public string SkuCode { get; set; }
	
	        /// <summary>
	        /// 子订单状态
	        /// </summary>
	        [XmlElement("son_order_status")]
	        public string SonOrderStatus { get; set; }
	
	        /// <summary>
	        /// 子订单中的各种标
	        /// </summary>
	        [XmlArray("tags")]
	        [XmlArrayItem("string")]
	        public List<string> Tags { get; set; }
	
	        /// <summary>
	        /// 全部商品金额
	        /// </summary>
	        [XmlElement("total_product_amount")]
	        public SimpleMoneyDomain TotalProductAmount { get; set; }
}

	/// <summary>
/// AeopOrderItemDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopOrderItemDtoDomain : TopObject
{
	        /// <summary>
	        /// 订单类型。（AE_COMMON:普通订单;AE_TRIAL:试用订单;AE_RECHARGE:手机充值订单)
	        /// </summary>
	        [XmlElement("biz_type")]
	        public string BizType { get; set; }
	
	        /// <summary>
	        /// 买家登录id
	        /// </summary>
	        [XmlElement("buyer_login_id")]
	        public string BuyerLoginId { get; set; }
	
	        /// <summary>
	        /// 买家全名
	        /// </summary>
	        [XmlElement("buyer_signer_fullname")]
	        public string BuyerSignerFullname { get; set; }
	
	        /// <summary>
	        /// 结束原因
	        /// </summary>
	        [XmlElement("end_reason")]
	        public string EndReason { get; set; }
	
	        /// <summary>
	        /// 手续费
	        /// </summary>
	        [XmlElement("escrow_fee")]
	        public SimpleMoneyDomain EscrowFee { get; set; }
	
	        /// <summary>
	        /// 手续费率
	        /// </summary>
	        [XmlElement("escrow_fee_rate")]
	        public long EscrowFeeRate { get; set; }
	
	        /// <summary>
	        /// 冻结状态。(NO_FROZEN:无冻结; IN_FROZEN:冻结中)
	        /// </summary>
	        [XmlElement("frozen_status")]
	        public string FrozenStatus { get; set; }
	
	        /// <summary>
	        /// 资金状态。(NOT_PAY:未付款; PAY_SUCCESS:付款成功; WAIT_SELLER_CHECK:卖家验款)
	        /// </summary>
	        [XmlElement("fund_status")]
	        public string FundStatus { get; set; }
	
	        /// <summary>
	        /// 订单创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 订单支付时间（和订单详情中gmtPaysuccess字段意义相同。)
	        /// </summary>
	        [XmlElement("gmt_pay_time")]
	        public string GmtPayTime { get; set; }
	
	        /// <summary>
	        /// 最后一次订单发货时间（已完成订单不返回时间）
	        /// </summary>
	        [XmlElement("gmt_send_goods_time")]
	        public string GmtSendGoodsTime { get; set; }
	
	        /// <summary>
	        /// 订单最后更新时间
	        /// </summary>
	        [XmlElement("gmt_update")]
	        public string GmtUpdate { get; set; }
	
	        /// <summary>
	        /// 是否已请求放款
	        /// </summary>
	        [XmlElement("has_request_loan")]
	        public bool HasRequestLoan { get; set; }
	
	        /// <summary>
	        /// 纠纷状态。(NO_ISSUE:无纠纷; IN_ISSUE:纠纷中; END_ISSUE:纠纷结束)
	        /// </summary>
	        [XmlElement("issue_status")]
	        public string IssueStatus { get; set; }
	
	        /// <summary>
	        /// 剩余发货时间（天）
	        /// </summary>
	        [XmlElement("left_send_good_day")]
	        public string LeftSendGoodDay { get; set; }
	
	        /// <summary>
	        /// 剩余发货时间（小时）
	        /// </summary>
	        [XmlElement("left_send_good_hour")]
	        public string LeftSendGoodHour { get; set; }
	
	        /// <summary>
	        /// 剩余发货时间（分钟）
	        /// </summary>
	        [XmlElement("left_send_good_min")]
	        public string LeftSendGoodMin { get; set; }
	
	        /// <summary>
	        /// 放款金额
	        /// </summary>
	        [XmlElement("loan_amount")]
	        public SimpleMoneyDomain LoanAmount { get; set; }
	
	        /// <summary>
	        /// 运费佣金比例
	        /// </summary>
	        [XmlElement("logisitcs_escrow_fee_rate")]
	        public string LogisitcsEscrowFeeRate { get; set; }
	
	        /// <summary>
	        /// 物流状态。（WAIT_SELLER_SEND_GOODS:等待卖家发货; SELLER_SEND_PART_GOODS:卖家部分发货; SELLER_SEND_GOODS:卖家已发货; BUYER_ACCEPT_GOODS:买家已确认收货; NO_LOGISTICS:没有物流流转信息）
	        /// </summary>
	        [XmlElement("logistics_status")]
	        public string LogisticsStatus { get; set; }
	
	        /// <summary>
	        /// 订单详情链接
	        /// </summary>
	        [XmlElement("order_detail_url")]
	        public string OrderDetailUrl { get; set; }
	
	        /// <summary>
	        /// 订单ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// 订单状态
	        /// </summary>
	        [XmlElement("order_status")]
	        public string OrderStatus { get; set; }
	
	        /// <summary>
	        /// 付款金额
	        /// </summary>
	        [XmlElement("pay_amount")]
	        public SimpleMoneyDomain PayAmount { get; set; }
	
	        /// <summary>
	        /// 付款方式。 （migs:信用卡支付走人民币渠道; migs102:MasterCard支付并且走人民币渠道; migs101:Visa支付并且走人民币渠道; pp101:PayPal; mb: MoneyBooker渠道; tt101:Bank Transfer支付; wu101: West Union支付； wp101:Visa走美金渠道的支付; wp102:Mastercard走美金渠道的支付; qw101:QIWI支付; cybs101:Visa走CYBS渠道的支付; cybs102: Mastercard走CYBS渠道的支付; wm101:WebMoney支付; ebanx101:巴西Beloto支付）
	        /// </summary>
	        [XmlElement("payment_type")]
	        public string PaymentType { get; set; }
	
	        /// <summary>
	        /// 是否手机订单
	        /// </summary>
	        [XmlElement("phone")]
	        public bool Phone { get; set; }
	
	        /// <summary>
	        /// 商品列表
	        /// </summary>
	        [XmlArray("product_list")]
	        [XmlArrayItem("aeop_order_product_dto")]
	        public List<AeopOrderProductDtoDomain> ProductList { get; set; }
	
	        /// <summary>
	        /// 卖家登录ID
	        /// </summary>
	        [XmlElement("seller_login_id")]
	        public string SellerLoginId { get; set; }
	
	        /// <summary>
	        /// 卖家操作人员的登录id
	        /// </summary>
	        [XmlElement("seller_operator_login_id")]
	        public string SellerOperatorLoginId { get; set; }
	
	        /// <summary>
	        /// 卖家全名
	        /// </summary>
	        [XmlElement("seller_signer_fullname")]
	        public string SellerSignerFullname { get; set; }
	
	        /// <summary>
	        /// 当前状态下的超时剩余时间（负数表示已超时时间）
	        /// </summary>
	        [XmlElement("timeout_left_time")]
	        public long TimeoutLeftTime { get; set; }
}

	/// <summary>
/// AeopPageResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopPageResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 页码
	        /// </summary>
	        [XmlElement("current_page")]
	        public long CurrentPage { get; set; }
	
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 每页条数
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// 出参如下
	        /// </summary>
	        [XmlArray("target_list")]
	        [XmlArrayItem("aeop_order_item_dto")]
	        public List<AeopOrderItemDtoDomain> TargetList { get; set; }
	
	        /// <summary>
	        /// timeStamp
	        /// </summary>
	        [XmlElement("time_stamp")]
	        public string TimeStamp { get; set; }
	
	        /// <summary>
	        /// 总数量(SC订单不包含在结果中）
	        /// </summary>
	        [XmlElement("total_count")]
	        public long TotalCount { get; set; }
	
	        /// <summary>
	        /// 总页数
	        /// </summary>
	        [XmlElement("total_page")]
	        public long TotalPage { get; set; }
}

    }
}
