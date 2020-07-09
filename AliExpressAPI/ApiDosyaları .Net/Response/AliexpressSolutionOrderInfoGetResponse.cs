using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionOrderInfoGetResponse.
    /// </summary>
    public class AliexpressSolutionOrderInfoGetResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public BaseResultDomain Result { get; set; }

	/// <summary>
/// GlobalAeopTpPersonDtoDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopTpPersonDtoDomain : TopObject
{
	        /// <summary>
	        /// country/region
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
	        /// login ID
	        /// </summary>
	        [XmlElement("login_id")]
	        public string LoginId { get; set; }
}

	/// <summary>
/// GlobalAeopTpAddressDtoDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopTpAddressDtoDomain : TopObject
{
	        /// <summary>
	        /// address 1
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// address 2
	        /// </summary>
	        [XmlElement("address2")]
	        public string Address2 { get; set; }
	
	        /// <summary>
	        /// city
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// Recipient
	        /// </summary>
	        [XmlElement("contact_person")]
	        public string ContactPerson { get; set; }
	
	        /// <summary>
	        /// country/region
	        /// </summary>
	        [XmlElement("country")]
	        public string Country { get; set; }
	
	        /// <summary>
	        /// detail address
	        /// </summary>
	        [XmlElement("detail_address")]
	        public string DetailAddress { get; set; }
	
	        /// <summary>
	        /// Fax area code
	        /// </summary>
	        [XmlElement("fax_area")]
	        public string FaxArea { get; set; }
	
	        /// <summary>
	        /// Fax country/region code
	        /// </summary>
	        [XmlElement("fax_country")]
	        public string FaxCountry { get; set; }
	
	        /// <summary>
	        /// fax number
	        /// </summary>
	        [XmlElement("fax_number")]
	        public string FaxNumber { get; set; }
	
	        /// <summary>
	        /// mobile phone number
	        /// </summary>
	        [XmlElement("mobile_no")]
	        public string MobileNo { get; set; }
	
	        /// <summary>
	        /// Phone area code
	        /// </summary>
	        [XmlElement("phone_area")]
	        public string PhoneArea { get; set; }
	
	        /// <summary>
	        /// Phone country/region code
	        /// </summary>
	        [XmlElement("phone_country")]
	        public string PhoneCountry { get; set; }
	
	        /// <summary>
	        /// phone number
	        /// </summary>
	        [XmlElement("phone_number")]
	        public string PhoneNumber { get; set; }
	
	        /// <summary>
	        /// province
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// Postal code
	        /// </summary>
	        [XmlElement("zip")]
	        public string Zip { get; set; }
}

	/// <summary>
/// CurrencyDomain Data Structure.
/// </summary>
[Serializable]

public class CurrencyDomain : TopObject
{
	        /// <summary>
	        /// Currency code
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
	
	        /// <summary>
	        /// The default minimum accuracy of the currency
	        /// </summary>
	        [XmlElement("default_fraction_digits")]
	        public long DefaultFractionDigits { get; set; }
	
	        /// <summary>
	        /// Display name of the currency
	        /// </summary>
	        [XmlElement("display_name")]
	        public string DisplayName { get; set; }
	
	        /// <summary>
	        /// Numeric code of the currency
	        /// </summary>
	        [XmlElement("numeric_code")]
	        public long NumericCode { get; set; }
	
	        /// <summary>
	        /// Symbol of the currency
	        /// </summary>
	        [XmlElement("symbol")]
	        public string Symbol { get; set; }
}

	/// <summary>
/// GlobalMoneyStrDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalMoneyStrDomain : TopObject
{
	        /// <summary>
	        /// Amount
	        /// </summary>
	        [XmlElement("amount")]
	        public string Amount { get; set; }
	
	        /// <summary>
	        /// Cent
	        /// </summary>
	        [XmlElement("cent")]
	        public long Cent { get; set; }
	
	        /// <summary>
	        /// The factor to the smallest currency unit
	        /// </summary>
	        [XmlElement("cent_factor")]
	        public long CentFactor { get; set; }
	
	        /// <summary>
	        /// Currency description
	        /// </summary>
	        [XmlElement("currency")]
	        public CurrencyDomain Currency { get; set; }
	
	        /// <summary>
	        /// Currency code
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
}

	/// <summary>
/// GlobalAeopTpOrderMsgDtoDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopTpOrderMsgDtoDomain : TopObject
{
	        /// <summary>
	        /// business order id
	        /// </summary>
	        [XmlElement("business_order_id")]
	        public long BusinessOrderId { get; set; }
	
	        /// <summary>
	        /// meesage content
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// order creation time
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// order modification time
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// order id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// message sender ( buyer; seller)
	        /// </summary>
	        [XmlElement("poster")]
	        public string Poster { get; set; }
	
	        /// <summary>
	        /// receiver admin account seq
	        /// </summary>
	        [XmlElement("receiver_admin_seq")]
	        public long ReceiverAdminSeq { get; set; }
	
	        /// <summary>
	        /// receiver first name
	        /// </summary>
	        [XmlElement("receiver_first_name")]
	        public string ReceiverFirstName { get; set; }
	
	        /// <summary>
	        /// receiver last name
	        /// </summary>
	        [XmlElement("receiver_last_name")]
	        public string ReceiverLastName { get; set; }
	
	        /// <summary>
	        /// receiver ID
	        /// </summary>
	        [XmlElement("receiver_login_id")]
	        public string ReceiverLoginId { get; set; }
	
	        /// <summary>
	        /// receiver account seq
	        /// </summary>
	        [XmlElement("receiver_seq")]
	        public long ReceiverSeq { get; set; }
	
	        /// <summary>
	        /// sender admin account seq
	        /// </summary>
	        [XmlElement("sender_admin_seq")]
	        public long SenderAdminSeq { get; set; }
	
	        /// <summary>
	        /// sender first name
	        /// </summary>
	        [XmlElement("sender_first_name")]
	        public string SenderFirstName { get; set; }
	
	        /// <summary>
	        /// send last name
	        /// </summary>
	        [XmlElement("sender_last_name")]
	        public string SenderLastName { get; set; }
	
	        /// <summary>
	        /// sender login ID
	        /// </summary>
	        [XmlElement("sender_login_id")]
	        public string SenderLoginId { get; set; }
	
	        /// <summary>
	        /// sender account seq
	        /// </summary>
	        [XmlElement("sender_seq")]
	        public long SenderSeq { get; set; }
	
	        /// <summary>
	        /// message status
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
}

	/// <summary>
/// GlobalAeopTpOrderProductInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopTpOrderProductInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// product id
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
	
	        /// <summary>
	        /// product name
	        /// </summary>
	        [XmlElement("product_name")]
	        public string ProductName { get; set; }
	
	        /// <summary>
	        /// product quantity
	        /// </summary>
	        [XmlElement("quantity")]
	        public long Quantity { get; set; }
	
	        /// <summary>
	        /// product SKU details
	        /// </summary>
	        [XmlElement("sku")]
	        public string Sku { get; set; }
	
	        /// <summary>
	        /// product unit price
	        /// </summary>
	        [XmlElement("unit_price")]
	        public GlobalMoneyStrDomain UnitPrice { get; set; }
}

	/// <summary>
/// GlobalAeopTpIssueInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopTpIssueInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// Issue model
	        /// </summary>
	        [XmlElement("issue_model")]
	        public string IssueModel { get; set; }
	
	        /// <summary>
	        /// Issue status
	        /// </summary>
	        [XmlElement("issue_status")]
	        public string IssueStatus { get; set; }
	
	        /// <summary>
	        /// issue creation time
	        /// </summary>
	        [XmlElement("issue_time")]
	        public string IssueTime { get; set; }
}

	/// <summary>
/// GlobalAeopTpRefundInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopTpRefundInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// refund cash amount
	        /// </summary>
	        [XmlElement("refund_cash_amt")]
	        public GlobalMoneyStrDomain RefundCashAmt { get; set; }
	
	        /// <summary>
	        /// refund coupon amount
	        /// </summary>
	        [XmlElement("refund_coupon_amt")]
	        public GlobalMoneyStrDomain RefundCouponAmt { get; set; }
	
	        /// <summary>
	        /// refund reason
	        /// </summary>
	        [XmlElement("refund_reason")]
	        public string RefundReason { get; set; }
	
	        /// <summary>
	        /// refund status: wait_refund, refund_ok, refund_cancel,  close,  refund_frozen
	        /// </summary>
	        [XmlElement("refund_status")]
	        public string RefundStatus { get; set; }
	
	        /// <summary>
	        /// refund time
	        /// </summary>
	        [XmlElement("refund_time")]
	        public string RefundTime { get; set; }
	
	        /// <summary>
	        /// refund type
	        /// </summary>
	        [XmlElement("refund_type")]
	        public string RefundType { get; set; }
}

	/// <summary>
/// GlobalAeopTpLogisticInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopTpLogisticInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// received time
	        /// </summary>
	        [XmlElement("gmt_received")]
	        public string GmtReceived { get; set; }
	
	        /// <summary>
	        /// send time
	        /// </summary>
	        [XmlElement("gmt_send")]
	        public string GmtSend { get; set; }
	
	        /// <summary>
	        /// to get logistics tracking information
	        /// </summary>
	        [XmlElement("have_tracking_info")]
	        public bool HaveTrackingInfo { get; set; }
	
	        /// <summary>
	        /// logistics tracking number
	        /// </summary>
	        [XmlElement("logistics_no")]
	        public string LogisticsNo { get; set; }
	
	        /// <summary>
	        /// logistics service show name
	        /// </summary>
	        [XmlElement("logistics_service_name")]
	        public string LogisticsServiceName { get; set; }
	
	        /// <summary>
	        /// logistics service name key
	        /// </summary>
	        [XmlElement("logistics_type_code")]
	        public string LogisticsTypeCode { get; set; }
	
	        /// <summary>
	        /// receive status。(default:initial value; received:; not_received; suspected_received)
	        /// </summary>
	        [XmlElement("receive_status")]
	        public string ReceiveStatus { get; set; }
	
	        /// <summary>
	        /// un-receive reason,such as Country does not match
	        /// </summary>
	        [XmlElement("recv_status_desc")]
	        public string RecvStatusDesc { get; set; }
	
	        /// <summary>
	        /// ship order id
	        /// </summary>
	        [XmlElement("ship_order_id")]
	        public long ShipOrderId { get; set; }
}

	/// <summary>
/// GlobalAeopTpOperationLogDtoDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopTpOperationLogDtoDomain : TopObject
{
	        /// <summary>
	        /// action type
	        /// </summary>
	        [XmlElement("action_type")]
	        public string ActionType { get; set; }
	
	        /// <summary>
	        /// child order ID
	        /// </summary>
	        [XmlElement("child_order_id")]
	        public long ChildOrderId { get; set; }
	
	        /// <summary>
	        /// order creation time
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// order modification time
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// buyer memo
	        /// </summary>
	        [XmlElement("memo")]
	        public string Memo { get; set; }
	
	        /// <summary>
	        /// operator
	        /// </summary>
	        [XmlElement("operator")]
	        public string Operator { get; set; }
	
	        /// <summary>
	        /// order ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
}

	/// <summary>
/// GlobalAeopTpLoanInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopTpLoanInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// loan amount
	        /// </summary>
	        [XmlElement("loan_amount")]
	        public GlobalMoneyStrDomain LoanAmount { get; set; }
	
	        /// <summary>
	        /// loan time
	        /// </summary>
	        [XmlElement("loan_time")]
	        public string LoanTime { get; set; }
}

	/// <summary>
/// GlobalAeopTpChildOrderDtoDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopTpChildOrderDtoDomain : TopObject
{
	        /// <summary>
	        /// affiliate fee rate
	        /// </summary>
	        [XmlElement("afflicate_fee_rate")]
	        public string AfflicateFeeRate { get; set; }
	
	        /// <summary>
	        /// buyer memo
	        /// </summary>
	        [XmlElement("buyer_memo")]
	        public string BuyerMemo { get; set; }
	
	        /// <summary>
	        /// child issue info
	        /// </summary>
	        [XmlElement("child_issue_info")]
	        public GlobalAeopTpIssueInfoDtoDomain ChildIssueInfo { get; set; }
	
	        /// <summary>
	        /// child order ID
	        /// </summary>
	        [XmlElement("child_order_id")]
	        public string ChildOrderId { get; set; }
	
	        /// <summary>
	        /// escrow fee rate
	        /// </summary>
	        [XmlElement("escrow_fee_rate")]
	        public string EscrowFeeRate { get; set; }
	
	        /// <summary>
	        /// frozen status（NO_FROZEN; IN_FROZEN）
	        /// </summary>
	        [XmlElement("frozen_status")]
	        public string FrozenStatus { get; set; }
	
	        /// <summary>
	        /// fund status (NOT_PAY；PAY_SUCCESS)
	        /// </summary>
	        [XmlElement("fund_status")]
	        public string FundStatus { get; set; }
	
	        /// <summary>
	        /// goods prepare days
	        /// </summary>
	        [XmlElement("goods_prepare_time")]
	        public long GoodsPrepareTime { get; set; }
	
	        /// <summary>
	        /// order ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// order amount
	        /// </summary>
	        [XmlElement("init_order_amt")]
	        public GlobalMoneyStrDomain InitOrderAmt { get; set; }
	
	        /// <summary>
	        /// issue status
	        /// </summary>
	        [XmlElement("issue_status")]
	        public string IssueStatus { get; set; }
	
	        /// <summary>
	        /// order loan info
	        /// </summary>
	        [XmlElement("loan_info")]
	        public GlobalAeopTpLoanInfoDtoDomain LoanInfo { get; set; }
	
	        /// <summary>
	        /// logistics amount
	        /// </summary>
	        [XmlElement("logistics_amount")]
	        public GlobalMoneyStrDomain LogisticsAmount { get; set; }
	
	        /// <summary>
	        /// logistics service name
	        /// </summary>
	        [XmlElement("logistics_service_name")]
	        public string LogisticsServiceName { get; set; }
	
	        /// <summary>
	        /// logistics type
	        /// </summary>
	        [XmlElement("logistics_type")]
	        public string LogisticsType { get; set; }
	
	        /// <summary>
	        /// cainiaoInternationalWarehouse
	        /// </summary>
	        [XmlElement("logistics_warehouse_type")]
	        public string LogisticsWarehouseType { get; set; }
	
	        /// <summary>
	        /// How many products in one piece or lot
	        /// </summary>
	        [XmlElement("lot_num")]
	        public long LotNum { get; set; }
	
	        /// <summary>
	        /// order sort id
	        /// </summary>
	        [XmlElement("order_sort_id")]
	        public long OrderSortId { get; set; }
	
	        /// <summary>
	        /// Order Status：PLACE_ORDER_SUCCESS;  IN_CANCEL;  WAIT_SELLER_SEND_GOODS;  SELLER_PART_SEND_GOODS;  WAIT_BUYER_ACCEPT_GOODS;  FUND_PROCESSING; IN_ISSUE;  IN_FROZEN;  WAIT_SELLER_EXAMINE_MONEY;  RISK_CONTROL.
	        /// </summary>
	        [XmlElement("order_status")]
	        public string OrderStatus { get; set; }
	
	        /// <summary>
	        /// Extended attributes of product
	        /// </summary>
	        [XmlElement("product_attributes")]
	        public string ProductAttributes { get; set; }
	
	        /// <summary>
	        /// product quantity
	        /// </summary>
	        [XmlElement("product_count")]
	        public long ProductCount { get; set; }
	
	        /// <summary>
	        /// product ID
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
	
	        /// <summary>
	        /// product image Url
	        /// </summary>
	        [XmlElement("product_img_url")]
	        public string ProductImgUrl { get; set; }
	
	        /// <summary>
	        /// product name
	        /// </summary>
	        [XmlElement("product_name")]
	        public string ProductName { get; set; }
	
	        /// <summary>
	        /// product price
	        /// </summary>
	        [XmlElement("product_price")]
	        public GlobalMoneyStrDomain ProductPrice { get; set; }
	
	        /// <summary>
	        /// product snapshot Url
	        /// </summary>
	        [XmlElement("product_snap_url")]
	        public string ProductSnapUrl { get; set; }
	
	        /// <summary>
	        /// Product specifications
	        /// </summary>
	        [XmlElement("product_standard")]
	        public string ProductStandard { get; set; }
	
	        /// <summary>
	        /// product_unit
	        /// </summary>
	        [XmlElement("product_unit")]
	        public string ProductUnit { get; set; }
	
	        /// <summary>
	        /// refund info
	        /// </summary>
	        [XmlElement("refund_info")]
	        public GlobalAeopTpRefundInfoDtoDomain RefundInfo { get; set; }
	
	        /// <summary>
	        /// SELLER_SEND_GOODS" or "WAREHOUSE_SEND_GOODS"
	        /// </summary>
	        [XmlElement("send_goods_operator")]
	        public string SendGoodsOperator { get; set; }
	
	        /// <summary>
	        /// SKU code
	        /// </summary>
	        [XmlElement("sku_code")]
	        public string SkuCode { get; set; }
	
	        /// <summary>
	        /// snapshot ID
	        /// </summary>
	        [XmlElement("snapshot_id")]
	        public string SnapshotId { get; set; }
	
	        /// <summary>
	        /// snapshot small photo path
	        /// </summary>
	        [XmlElement("snapshot_small_photo_path")]
	        public string SnapshotSmallPhotoPath { get; set; }
}

	/// <summary>
/// GlobalAeopTpOrderDetailDtoDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopTpOrderDetailDtoDomain : TopObject
{
	        /// <summary>
	        /// buyer info
	        /// </summary>
	        [XmlElement("buyer_info")]
	        public GlobalAeopTpPersonDtoDomain BuyerInfo { get; set; }
	
	        /// <summary>
	        /// buyer full name
	        /// </summary>
	        [XmlElement("buyer_signer_fullname")]
	        public string BuyerSignerFullname { get; set; }
	
	        /// <summary>
	        /// buyer login id
	        /// </summary>
	        [XmlElement("buyerloginid")]
	        public string Buyerloginid { get; set; }
	
	        /// <summary>
	        /// child order ext info list
	        /// </summary>
	        [XmlArray("child_order_ext_info_list")]
	        [XmlArrayItem("global_aeop_tp_order_product_info_dto")]
	        public List<GlobalAeopTpOrderProductInfoDtoDomain> ChildOrderExtInfoList { get; set; }
	
	        /// <summary>
	        /// child order list
	        /// </summary>
	        [XmlArray("child_order_list")]
	        [XmlArrayItem("global_aeop_tp_child_order_dto")]
	        public List<GlobalAeopTpChildOrderDtoDomain> ChildOrderList { get; set; }
	
	        /// <summary>
	        /// cpf  number of order
	        /// </summary>
	        [XmlElement("cpf_number")]
	        public string CpfNumber { get; set; }
	
	        /// <summary>
	        /// escrow fee (deprecated)
	        /// </summary>
	        [XmlElement("escrow_fee")]
	        public GlobalMoneyStrDomain EscrowFee { get; set; }
	
	        /// <summary>
	        /// frozen status
	        /// </summary>
	        [XmlElement("frozen_status")]
	        public string FrozenStatus { get; set; }
	
	        /// <summary>
	        /// fund status
	        /// </summary>
	        [XmlElement("fund_status")]
	        public string FundStatus { get; set; }
	
	        /// <summary>
	        /// order creation time
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// modified time, it's US pacific time
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// successful payment time
	        /// </summary>
	        [XmlElement("gmt_pay_success")]
	        public string GmtPaySuccess { get; set; }
	
	        /// <summary>
	        /// Order end time
	        /// </summary>
	        [XmlElement("gmt_trade_end")]
	        public string GmtTradeEnd { get; set; }
	
	        /// <summary>
	        /// order ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// order amount
	        /// </summary>
	        [XmlElement("init_oder_amount")]
	        public GlobalMoneyStrDomain InitOderAmount { get; set; }
	
	        /// <summary>
	        /// phone order or not
	        /// </summary>
	        [XmlElement("is_phone")]
	        public bool IsPhone { get; set; }
	
	        /// <summary>
	        /// issue info
	        /// </summary>
	        [XmlElement("issue_info")]
	        public GlobalAeopTpIssueInfoDtoDomain IssueInfo { get; set; }
	
	        /// <summary>
	        /// issue status
	        /// </summary>
	        [XmlElement("issue_status")]
	        public string IssueStatus { get; set; }
	
	        /// <summary>
	        /// loan info
	        /// </summary>
	        [XmlElement("loan_info")]
	        public GlobalAeopTpLoanInfoDtoDomain LoanInfo { get; set; }
	
	        /// <summary>
	        /// loan status
	        /// </summary>
	        [XmlElement("loan_status")]
	        public string LoanStatus { get; set; }
	
	        /// <summary>
	        /// logisitcs escrow fee rate(Deprecated)
	        /// </summary>
	        [XmlElement("logisitcs_escrow_fee_rate")]
	        public string LogisitcsEscrowFeeRate { get; set; }
	
	        /// <summary>
	        /// logistics info
	        /// </summary>
	        [XmlArray("logistic_info_list")]
	        [XmlArrayItem("global_aeop_tp_logistic_info_dto")]
	        public List<GlobalAeopTpLogisticInfoDtoDomain> LogisticInfoList { get; set; }
	
	        /// <summary>
	        /// logistics amount
	        /// </summary>
	        [XmlElement("logistics_amount")]
	        public GlobalMoneyStrDomain LogisticsAmount { get; set; }
	
	        /// <summary>
	        /// logistics status：NO_LOGISTICS 、 WAIT_SELLER_SEND_GOODS, SELLER_SEND_PART_GOODS, SELLER_SEND_GOODS, BUYER_ACCEPT_GOODS,NO_LOGISTICS
	        /// </summary>
	        [XmlElement("logistics_status")]
	        public string LogisticsStatus { get; set; }
	
	        /// <summary>
	        /// buyer memo
	        /// </summary>
	        [XmlElement("memo")]
	        public string Memo { get; set; }
	
	        /// <summary>
	        /// operation details list
	        /// </summary>
	        [XmlArray("opr_log_dto_list")]
	        [XmlArrayItem("global_aeop_tp_operation_log_dto")]
	        public List<GlobalAeopTpOperationLogDtoDomain> OprLogDtoList { get; set; }
	
	        /// <summary>
	        /// order amount
	        /// </summary>
	        [XmlElement("order_amount")]
	        public GlobalMoneyStrDomain OrderAmount { get; set; }
	
	        /// <summary>
	        /// order end reason
	        /// </summary>
	        [XmlElement("order_end_reason")]
	        public string OrderEndReason { get; set; }
	
	        /// <summary>
	        /// Order Message list(deprecated)
	        /// </summary>
	        [XmlArray("order_msg_list")]
	        [XmlArrayItem("global_aeop_tp_order_msg_dto")]
	        public List<GlobalAeopTpOrderMsgDtoDomain> OrderMsgList { get; set; }
	
	        /// <summary>
	        /// Order Status：PLACE_ORDER_SUCCESS;  IN_CANCEL;  WAIT_SELLER_SEND_GOODS;  SELLER_PART_SEND_GOODS;  WAIT_BUYER_ACCEPT_GOODS;  FUND_PROCESSING; IN_ISSUE;  IN_FROZEN;  WAIT_SELLER_EXAMINE_MONEY;  RISK_CONTROL.
	        /// </summary>
	        [XmlElement("order_status")]
	        public string OrderStatus { get; set; }
	
	        /// <summary>
	        /// Current status expiration date
	        /// </summary>
	        [XmlElement("over_time_left")]
	        public string OverTimeLeft { get; set; }
	
	        /// <summary>
	        /// order pay amount(settlemet currency)
	        /// </summary>
	        [XmlElement("pay_amount_by_settlement_cur")]
	        public string PayAmountBySettlementCur { get; set; }
	
	        /// <summary>
	        /// payment type
	        /// </summary>
	        [XmlElement("payment_type")]
	        public string PaymentType { get; set; }
	
	        /// <summary>
	        /// receipt address
	        /// </summary>
	        [XmlElement("receipt_address")]
	        public GlobalAeopTpAddressDtoDomain ReceiptAddress { get; set; }
	
	        /// <summary>
	        /// refund info
	        /// </summary>
	        [XmlElement("refund_info")]
	        public GlobalAeopTpRefundInfoDtoDomain RefundInfo { get; set; }
	
	        /// <summary>
	        /// seller operator ali login id
	        /// </summary>
	        [XmlElement("seller_operator_aliidloginid")]
	        public string SellerOperatorAliidloginid { get; set; }
	
	        /// <summary>
	        /// seller operator login ID
	        /// </summary>
	        [XmlElement("seller_operator_login_id")]
	        public string SellerOperatorLoginId { get; set; }
	
	        /// <summary>
	        /// Seller full name
	        /// </summary>
	        [XmlElement("seller_signer_fullname")]
	        public string SellerSignerFullname { get; set; }
	
	        /// <summary>
	        /// Payment settlement currency
	        /// </summary>
	        [XmlElement("settlement_currency")]
	        public string SettlementCurrency { get; set; }
}

	/// <summary>
/// BaseResultDomain Data Structure.
/// </summary>
[Serializable]

public class BaseResultDomain : TopObject
{
	        /// <summary>
	        /// data
	        /// </summary>
	        [XmlElement("data")]
	        public GlobalAeopTpOrderDetailDtoDomain Data { get; set; }
	
	        /// <summary>
	        /// error code
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// error message
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// time stamp
	        /// </summary>
	        [XmlElement("time_stamp")]
	        public string TimeStamp { get; set; }
}

    }
}
