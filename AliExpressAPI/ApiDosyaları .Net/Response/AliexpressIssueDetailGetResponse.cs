using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressIssueDetailGetResponse.
    /// </summary>
    public class AliexpressIssueDetailGetResponse : TopResponse
    {
        /// <summary>
        /// 返回结果集
        /// </summary>
        [XmlElement("result_object")]
        public IssueDetailOpenApiDtoDomain ResultObject { get; set; }

	/// <summary>
/// SolutionApiDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SolutionApiDtoDomain : TopObject
{
	        /// <summary>
	        /// 买家接受时间
	        /// </summary>
	        [XmlElement("buyer_accept_time")]
	        public string BuyerAcceptTime { get; set; }
	
	        /// <summary>
	        /// 内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 方案创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 最后修改时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 方案id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 是否是默认方案
	        /// </summary>
	        [XmlElement("is_default")]
	        public bool IsDefault { get; set; }
	
	        /// <summary>
	        /// 纠纷id
	        /// </summary>
	        [XmlElement("issue_id")]
	        public long IssueId { get; set; }
	
	        /// <summary>
	        /// 退货运费金额
	        /// </summary>
	        [XmlElement("logistics_fee_amount")]
	        public long LogisticsFeeAmount { get; set; }
	
	        /// <summary>
	        /// 退货运费币种
	        /// </summary>
	        [XmlElement("logistics_fee_amount_currency")]
	        public string LogisticsFeeAmountCurrency { get; set; }
	
	        /// <summary>
	        /// 运费承担方：seller、buyer、platform
	        /// </summary>
	        [XmlElement("logistics_fee_bear_role")]
	        public string LogisticsFeeBearRole { get; set; }
	
	        /// <summary>
	        /// 订单id
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// 达成时间
	        /// </summary>
	        [XmlElement("reached_time")]
	        public string ReachedTime { get; set; }
	
	        /// <summary>
	        /// 方案达成类型：协商一致negotiation_consensus、平台仲裁platform_arbitrate、卖家响应超时seller_reponse_timeout
	        /// </summary>
	        [XmlElement("reached_type")]
	        public string ReachedType { get; set; }
	
	        /// <summary>
	        /// 退款金额本币
	        /// </summary>
	        [XmlElement("refund_money")]
	        public string RefundMoney { get; set; }
	
	        /// <summary>
	        /// 本币币种
	        /// </summary>
	        [XmlElement("refund_money_currency")]
	        public string RefundMoneyCurrency { get; set; }
	
	        /// <summary>
	        /// 退款金额 美金
	        /// </summary>
	        [XmlElement("refund_money_post")]
	        public string RefundMoneyPost { get; set; }
	
	        /// <summary>
	        /// refundMoneyPostCurrency
	        /// </summary>
	        [XmlElement("refund_money_post_currency")]
	        public string RefundMoneyPostCurrency { get; set; }
	
	        /// <summary>
	        /// 卖家接受时间
	        /// </summary>
	        [XmlElement("seller_accept_time")]
	        public string SellerAcceptTime { get; set; }
	
	        /// <summary>
	        /// 方案提出者
	        /// </summary>
	        [XmlElement("solution_owner")]
	        public string SolutionOwner { get; set; }
	
	        /// <summary>
	        /// 方案类型：退款refund、退货退款return_and_refund
	        /// </summary>
	        [XmlElement("solution_type")]
	        public string SolutionType { get; set; }
	
	        /// <summary>
	        /// 方案状态 待买卖家双方接受wait_buyer_and_seller_accept,待买家接受wait_buyer_accept,待卖家接受wait_seller_accept,达成reached,买家拒绝buyer_refused,卖家接受买家拒绝(针对平台方案)seller_accept_and_buyer_refused,退货阶段,卖家上升仲裁,平台给方案,之前达成的方案改成此状态reach_cancle,执行perform
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 版本号
	        /// </summary>
	        [XmlElement("version")]
	        public long Version { get; set; }
}

	/// <summary>
/// ApiAttachmentDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ApiAttachmentDtoDomain : TopObject
{
	        /// <summary>
	        /// 图片路径
	        /// </summary>
	        [XmlElement("file_path")]
	        public string FilePath { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 纠纷id
	        /// </summary>
	        [XmlElement("issue_id")]
	        public long IssueId { get; set; }
	
	        /// <summary>
	        /// 过程id
	        /// </summary>
	        [XmlElement("issue_process_id")]
	        public long IssueProcessId { get; set; }
	
	        /// <summary>
	        /// 所属人:buyer\seller
	        /// </summary>
	        [XmlElement("owner")]
	        public string Owner { get; set; }
}

	/// <summary>
/// ApiIssueProcessDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ApiIssueProcessDtoDomain : TopObject
{
	        /// <summary>
	        /// 操作类型 发起纠纷initiate取消纠纷，cancel买家取消纠纷, 买家同意方案buyer_accept,卖家同意方案seller_accept,买家拒绝方案buyer_refuse, 买家创建方案buyer_create_solution, 买家修改方案buyer_modify_solution,买家删除方案buyer_delete_solution,卖家创建方案seller_create_solution,卖家修改方案seller_modify_solution,卖家删除方案seller_delete_solution
	        /// </summary>
	        [XmlElement("action_type")]
	        public string ActionType { get; set; }
	
	        /// <summary>
	        /// 图片附件
	        /// </summary>
	        [XmlArray("attachments")]
	        [XmlArrayItem("api_attachment_dto")]
	        public List<ApiAttachmentDtoDomain> Attachments { get; set; }
	
	        /// <summary>
	        /// 过程context,eg:buyer提起填写内容,seller拒绝填写内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 是否有buyer视频(淘宝视频必须授权才能播放,目前不支持)
	        /// </summary>
	        [XmlElement("has_buyer_video")]
	        public bool HasBuyerVideo { get; set; }
	
	        /// <summary>
	        /// 是否有seller视频(淘宝视频必须授权才能播放,目前不支持)
	        /// </summary>
	        [XmlElement("has_seller_video")]
	        public bool HasSellerVideo { get; set; }
	
	        /// <summary>
	        /// 过程id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// issueId
	        /// </summary>
	        [XmlElement("issue_id")]
	        public long IssueId { get; set; }
	
	        /// <summary>
	        /// 是否收到货
	        /// </summary>
	        [XmlElement("receive_goods")]
	        public bool ReceiveGoods { get; set; }
	
	        /// <summary>
	        /// 操作人类型：seller卖家，buyer买家，waiter客服，system
	        /// </summary>
	        [XmlElement("submit_member_type")]
	        public string SubmitMemberType { get; set; }
}

	/// <summary>
/// IssueDetailOpenApiDtoDomain Data Structure.
/// </summary>
[Serializable]

public class IssueDetailOpenApiDtoDomain : TopObject
{
	        /// <summary>
	        /// 是否售后宝纠纷
	        /// </summary>
	        [XmlElement("after_sale_warranty")]
	        public bool AfterSaleWarranty { get; set; }
	
	        /// <summary>
	        /// 买家登录帐号
	        /// </summary>
	        [XmlElement("buyer_login_id")]
	        public string BuyerLoginId { get; set; }
	
	        /// <summary>
	        /// 买家退货物流公司
	        /// </summary>
	        [XmlElement("buyer_return_logistics_company")]
	        public string BuyerReturnLogisticsCompany { get; set; }
	
	        /// <summary>
	        /// 退货物流订单LP单号
	        /// </summary>
	        [XmlElement("buyer_return_logistics_lp_no")]
	        public string BuyerReturnLogisticsLpNo { get; set; }
	
	        /// <summary>
	        /// 买家退货单号
	        /// </summary>
	        [XmlElement("buyer_return_no")]
	        public string BuyerReturnNo { get; set; }
	
	        /// <summary>
	        /// 买家协商方案
	        /// </summary>
	        [XmlArray("buyer_solution_list")]
	        [XmlArrayItem("solution_api_dto")]
	        public List<SolutionApiDtoDomain> BuyerSolutionList { get; set; }
	
	        /// <summary>
	        /// 纠纷创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 纠纷id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 纠纷原因
	        /// </summary>
	        [XmlElement("issue_reason")]
	        public string IssueReason { get; set; }
	
	        /// <summary>
	        /// 纠纷原因id
	        /// </summary>
	        [XmlElement("issue_reason_id")]
	        public long IssueReasonId { get; set; }
	
	        /// <summary>
	        /// 纠纷状态 处理中 processing、 纠纷取消canceled_issue、纠纷完结,退款处理完成finish
	        /// </summary>
	        [XmlElement("issue_status")]
	        public string IssueStatus { get; set; }
	
	        /// <summary>
	        /// 订单id
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// 父订单id
	        /// </summary>
	        [XmlElement("parent_order_id")]
	        public long ParentOrderId { get; set; }
	
	        /// <summary>
	        /// 平台方案集合
	        /// </summary>
	        [XmlArray("platform_solution_list")]
	        [XmlArrayItem("solution_api_dto")]
	        public List<SolutionApiDtoDomain> PlatformSolutionList { get; set; }
	
	        /// <summary>
	        /// 操作记录
	        /// </summary>
	        [XmlArray("process_dto_list")]
	        [XmlArrayItem("api_issue_process_dto")]
	        public List<ApiIssueProcessDtoDomain> ProcessDtoList { get; set; }
	
	        /// <summary>
	        /// 产品名称
	        /// </summary>
	        [XmlElement("product_name")]
	        public string ProductName { get; set; }
	
	        /// <summary>
	        /// 产品价格
	        /// </summary>
	        [XmlElement("product_price")]
	        public string ProductPrice { get; set; }
	
	        /// <summary>
	        /// 产品价格币种
	        /// </summary>
	        [XmlElement("product_price_currency")]
	        public string ProductPriceCurrency { get; set; }
	
	        /// <summary>
	        /// 退款上限
	        /// </summary>
	        [XmlElement("refund_money_max")]
	        public string RefundMoneyMax { get; set; }
	
	        /// <summary>
	        /// 退款上限币种
	        /// </summary>
	        [XmlElement("refund_money_max_currency")]
	        public string RefundMoneyMaxCurrency { get; set; }
	
	        /// <summary>
	        /// 退款上限当地货币
	        /// </summary>
	        [XmlElement("refund_money_max_local")]
	        public string RefundMoneyMaxLocal { get; set; }
	
	        /// <summary>
	        /// 退款上限当地货币币种
	        /// </summary>
	        [XmlElement("refund_money_max_local_currency")]
	        public string RefundMoneyMaxLocalCurrency { get; set; }
	
	        /// <summary>
	        /// 卖家协商方案
	        /// </summary>
	        [XmlArray("seller_solution_list")]
	        [XmlArrayItem("solution_api_dto")]
	        public List<SolutionApiDtoDomain> SellerSolutionList { get; set; }
}

    }
}
