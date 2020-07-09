using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionOrderGetResponse.
    /// </summary>
    public class AliexpressSolutionOrderGetResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public PaginationResultDomain Result { get; set; }

	/// <summary>
/// SimpleMoneyDomain Data Structure.
/// </summary>
[Serializable]

public class SimpleMoneyDomain : TopObject
{
	        /// <summary>
	        /// amount
	        /// </summary>
	        [XmlElement("amount")]
	        public string Amount { get; set; }
	
	        /// <summary>
	        /// currency code
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
}

	/// <summary>
/// OrderProductDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OrderProductDtoDomain : TopObject
{
	        /// <summary>
	        /// afflicate fee rate
	        /// </summary>
	        [XmlElement("afflicate_fee_rate")]
	        public string AfflicateFeeRate { get; set; }
	
	        /// <summary>
	        /// buyer first name
	        /// </summary>
	        [XmlElement("buyer_signer_first_name")]
	        public string BuyerSignerFirstName { get; set; }
	
	        /// <summary>
	        /// buyer last name
	        /// </summary>
	        [XmlElement("buyer_signer_last_name")]
	        public string BuyerSignerLastName { get; set; }
	
	        /// <summary>
	        /// Whether child orders can submit disputes
	        /// </summary>
	        [XmlElement("can_submit_issue")]
	        public bool CanSubmitIssue { get; set; }
	
	        /// <summary>
	        /// child order id
	        /// </summary>
	        [XmlElement("child_id")]
	        public long ChildId { get; set; }
	
	        /// <summary>
	        /// delivery time
	        /// </summary>
	        [XmlElement("delivery_time")]
	        public string DeliveryTime { get; set; }
	
	        /// <summary>
	        /// escrow fee rate
	        /// </summary>
	        [XmlElement("escrow_fee_rate")]
	        public string EscrowFeeRate { get; set; }
	
	        /// <summary>
	        /// Limited time
	        /// </summary>
	        [XmlElement("freight_commit_day")]
	        public string FreightCommitDay { get; set; }
	
	        /// <summary>
	        /// fund status (NOT_PAY; PAY_SUCCESS; WAIT_SELLER_CHECK)
	        /// </summary>
	        [XmlElement("fund_status")]
	        public string FundStatus { get; set; }
	
	        /// <summary>
	        /// goods prepare days
	        /// </summary>
	        [XmlElement("goods_prepare_time")]
	        public long GoodsPrepareTime { get; set; }
	
	        /// <summary>
	        /// issue mode
	        /// </summary>
	        [XmlElement("issue_mode")]
	        public string IssueMode { get; set; }
	
	        /// <summary>
	        /// issue status (NO_ISSUE; IN_ISSUE; END_ISSUE)
	        /// </summary>
	        [XmlElement("issue_status")]
	        public string IssueStatus { get; set; }
	
	        /// <summary>
	        /// Logistics amount(sub-orders have no shipping costs, please ignore)
	        /// </summary>
	        [XmlElement("logistics_amount")]
	        public SimpleMoneyDomain LogisticsAmount { get; set; }
	
	        /// <summary>
	        /// logistics service show name
	        /// </summary>
	        [XmlElement("logistics_service_name")]
	        public string LogisticsServiceName { get; set; }
	
	        /// <summary>
	        /// logistics service name( key)
	        /// </summary>
	        [XmlElement("logistics_type")]
	        public string LogisticsType { get; set; }
	
	        /// <summary>
	        /// buyer memo
	        /// </summary>
	        [XmlElement("memo")]
	        public string Memo { get; set; }
	
	        /// <summary>
	        /// fake one compensate three flag
	        /// </summary>
	        [XmlElement("money_back3x")]
	        public bool MoneyBack3x { get; set; }
	
	        /// <summary>
	        /// order ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// product count
	        /// </summary>
	        [XmlElement("product_count")]
	        public long ProductCount { get; set; }
	
	        /// <summary>
	        /// product id
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
	
	        /// <summary>
	        /// product main image url
	        /// </summary>
	        [XmlElement("product_img_url")]
	        public string ProductImgUrl { get; set; }
	
	        /// <summary>
	        /// product name
	        /// </summary>
	        [XmlElement("product_name")]
	        public string ProductName { get; set; }
	
	        /// <summary>
	        /// product snap Url
	        /// </summary>
	        [XmlElement("product_snap_url")]
	        public string ProductSnapUrl { get; set; }
	
	        /// <summary>
	        /// product standard
	        /// </summary>
	        [XmlElement("product_standard")]
	        public string ProductStandard { get; set; }
	
	        /// <summary>
	        /// product unit
	        /// </summary>
	        [XmlElement("product_unit")]
	        public string ProductUnit { get; set; }
	
	        /// <summary>
	        /// product unit price
	        /// </summary>
	        [XmlElement("product_unit_price")]
	        public SimpleMoneyDomain ProductUnitPrice { get; set; }
	
	        /// <summary>
	        /// Shipper type. "SELLER_SEND_GOODS": seller shipping; "WAREHOUSE_SEND_GOODS": warehouse delivery
	        /// </summary>
	        [XmlElement("send_goods_operator")]
	        public string SendGoodsOperator { get; set; }
	
	        /// <summary>
	        /// Last delivery time
	        /// </summary>
	        [XmlElement("send_goods_time")]
	        public string SendGoodsTime { get; set; }
	
	        /// <summary>
	        /// order show status
	        /// </summary>
	        [XmlElement("show_status")]
	        public string ShowStatus { get; set; }
	
	        /// <summary>
	        /// sku code
	        /// </summary>
	        [XmlElement("sku_code")]
	        public string SkuCode { get; set; }
	
	        /// <summary>
	        /// child order status
	        /// </summary>
	        [XmlElement("son_order_status")]
	        public string SonOrderStatus { get; set; }
	
	        /// <summary>
	        /// total product amount
	        /// </summary>
	        [XmlElement("total_product_amount")]
	        public SimpleMoneyDomain TotalProductAmount { get; set; }
}

	/// <summary>
/// OrderDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OrderDtoDomain : TopObject
{
	        /// <summary>
	        /// order type。（AE_COMMON:common type,AE_TRIAL:trial type;AE_RECHARGE:recharge order)
	        /// </summary>
	        [XmlElement("biz_type")]
	        public string BizType { get; set; }
	
	        /// <summary>
	        /// buyer login id
	        /// </summary>
	        [XmlElement("buyer_login_id")]
	        public string BuyerLoginId { get; set; }
	
	        /// <summary>
	        /// buyer full name
	        /// </summary>
	        [XmlElement("buyer_signer_fullname")]
	        public string BuyerSignerFullname { get; set; }
	
	        /// <summary>
	        /// order finished reason
	        /// </summary>
	        [XmlElement("end_reason")]
	        public string EndReason { get; set; }
	
	        /// <summary>
	        /// escrow fee
	        /// </summary>
	        [XmlElement("escrow_fee")]
	        public SimpleMoneyDomain EscrowFee { get; set; }
	
	        /// <summary>
	        /// escrow fee rate
	        /// </summary>
	        [XmlElement("escrow_fee_rate")]
	        public long EscrowFeeRate { get; set; }
	
	        /// <summary>
	        /// frozen status。(NO_FROZEN:no frozen; IN_FROZEN:in frozen)
	        /// </summary>
	        [XmlElement("frozen_status")]
	        public string FrozenStatus { get; set; }
	
	        /// <summary>
	        /// fund status (NOT_PAY; PAY_SUCCESS; WAIT_SELLER_CHECK)
	        /// </summary>
	        [XmlElement("fund_status")]
	        public string FundStatus { get; set; }
	
	        /// <summary>
	        /// order create time,it's US Pacific time
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// order pay time (The gmtPaysuccess field has the same meaning in the order details.)it's US Pacific time
	        /// </summary>
	        [XmlElement("gmt_pay_time")]
	        public string GmtPayTime { get; set; }
	
	        /// <summary>
	        /// Last order delivery time
	        /// </summary>
	        [XmlElement("gmt_send_goods_time")]
	        public string GmtSendGoodsTime { get; set; }
	
	        /// <summary>
	        /// Last order update time
	        /// </summary>
	        [XmlElement("gmt_update")]
	        public string GmtUpdate { get; set; }
	
	        /// <summary>
	        /// Have you requested a loan?
	        /// </summary>
	        [XmlElement("has_request_loan")]
	        public bool HasRequestLoan { get; set; }
	
	        /// <summary>
	        /// issue status (NO_ISSUE; IN_ISSUE; END_ISSUE)
	        /// </summary>
	        [XmlElement("issue_status")]
	        public string IssueStatus { get; set; }
	
	        /// <summary>
	        /// Remaining delivery time (days)
	        /// </summary>
	        [XmlElement("left_send_good_day")]
	        public string LeftSendGoodDay { get; set; }
	
	        /// <summary>
	        /// Remaining delivery time (hour）
	        /// </summary>
	        [XmlElement("left_send_good_hour")]
	        public string LeftSendGoodHour { get; set; }
	
	        /// <summary>
	        /// Remaining delivery time (minute)
	        /// </summary>
	        [XmlElement("left_send_good_min")]
	        public string LeftSendGoodMin { get; set; }
	
	        /// <summary>
	        /// loan amount details
	        /// </summary>
	        [XmlElement("loan_amount")]
	        public SimpleMoneyDomain LoanAmount { get; set; }
	
	        /// <summary>
	        /// logistics escrow fee rate
	        /// </summary>
	        [XmlElement("logisitcs_escrow_fee_rate")]
	        public string LogisitcsEscrowFeeRate { get; set; }
	
	        /// <summary>
	        /// logistics status。logistics status。(WAIT_SELLER_SEND_GOODS: Waiting for seller to ship; SELLER_SEND_PART_GOODS: Partial delivery by seller; SELLER_SEND_GOODS: Seller has shipped; BUYER_ACCEPT_GOODS: Buyer has confirmed receipt; NO_LOGISTICS: No logistics transfer)
	        /// </summary>
	        [XmlElement("logistics_status")]
	        public string LogisticsStatus { get; set; }
	
	        /// <summary>
	        /// order detail url
	        /// </summary>
	        [XmlElement("order_detail_url")]
	        public string OrderDetailUrl { get; set; }
	
	        /// <summary>
	        /// order ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// order status
	        /// </summary>
	        [XmlElement("order_status")]
	        public string OrderStatus { get; set; }
	
	        /// <summary>
	        /// pay amount
	        /// </summary>
	        [XmlElement("pay_amount")]
	        public SimpleMoneyDomain PayAmount { get; set; }
	
	        /// <summary>
	        /// pay type: migs: Credit card payments go through the RMB channel; migs: 102MasterCard pays and takes the RMB channel; migs101:Visa Pay and take the RMB channel; pp101: PayPal; mb: MoneyBooker channel; tt101: Bank Transfer payment; wu101: West Union payment; wp101: Visa pays for the US dollar channel; wp102: Mastercard to pay for the US dollar channel; qw101: QIWI payment; cybs101: Visa takes the payment of the CYBS channel; cybs102: Mastercard to pay for CYBS channels; wm101: WebMoney payment; ebanx101: Brazilian Beloto payment;
	        /// </summary>
	        [XmlElement("payment_type")]
	        public string PaymentType { get; set; }
	
	        /// <summary>
	        /// Whether mobile phone orders
	        /// </summary>
	        [XmlElement("phone")]
	        public bool Phone { get; set; }
	
	        /// <summary>
	        /// product list
	        /// </summary>
	        [XmlArray("product_list")]
	        [XmlArrayItem("order_product_dto")]
	        public List<OrderProductDtoDomain> ProductList { get; set; }
	
	        /// <summary>
	        /// seller login id
	        /// </summary>
	        [XmlElement("seller_login_id")]
	        public string SellerLoginId { get; set; }
	
	        /// <summary>
	        /// seller operator login id
	        /// </summary>
	        [XmlElement("seller_operator_login_id")]
	        public string SellerOperatorLoginId { get; set; }
	
	        /// <summary>
	        /// seller fuller name
	        /// </summary>
	        [XmlElement("seller_signer_fullname")]
	        public string SellerSignerFullname { get; set; }
	
	        /// <summary>
	        /// The remain time of the current status (negative number indicates the timeout period)
	        /// </summary>
	        [XmlElement("timeout_left_time")]
	        public long TimeoutLeftTime { get; set; }
}

	/// <summary>
/// PaginationResultDomain Data Structure.
/// </summary>
[Serializable]

public class PaginationResultDomain : TopObject
{
	        /// <summary>
	        /// current page
	        /// </summary>
	        [XmlElement("current_page")]
	        public long CurrentPage { get; set; }
	
	        /// <summary>
	        /// error code
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// error massage
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// the number of each page
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// success or not
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// target list
	        /// </summary>
	        [XmlArray("target_list")]
	        [XmlArrayItem("order_dto")]
	        public List<OrderDtoDomain> TargetList { get; set; }
	
	        /// <summary>
	        /// timeStamp
	        /// </summary>
	        [XmlElement("time_stamp")]
	        public string TimeStamp { get; set; }
	
	        /// <summary>
	        /// total count(SC order is not include the result）
	        /// </summary>
	        [XmlElement("total_count")]
	        public long TotalCount { get; set; }
	
	        /// <summary>
	        /// total page
	        /// </summary>
	        [XmlElement("total_page")]
	        public long TotalPage { get; set; }
}

    }
}
