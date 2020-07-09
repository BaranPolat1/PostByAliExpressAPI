using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressTradeRedefiningFindordertradeinfoResponse.
    /// </summary>
    public class AliexpressTradeRedefiningFindordertradeinfoResponse : TopResponse
    {
        /// <summary>
        /// 出参
        /// </summary>
        [XmlElement("result")]
        public OrderTradeInfoDomain Result { get; set; }

	/// <summary>
/// ChildOrderDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ChildOrderDtoDomain : TopObject
{
	        /// <summary>
	        /// 冻结状态(NO_FROZEN:无冻结；IN_FROZEN:冻结中)
	        /// </summary>
	        [XmlElement("frozen_status")]
	        public string FrozenStatus { get; set; }
	
	        /// <summary>
	        /// 资金状态(NOT_PAY:未付款; PAY_SUCCESS:付款成功;  WAIT_SELLER_CHECK:卖家验款)
	        /// </summary>
	        [XmlElement("fund_status")]
	        public string FundStatus { get; set; }
	
	        /// <summary>
	        /// 子订单ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 子订单初始金额
	        /// </summary>
	        [XmlElement("init_order_amt")]
	        public string InitOrderAmt { get; set; }
	
	        /// <summary>
	        /// 子订单初始金额的货币单位
	        /// </summary>
	        [XmlElement("init_order_amt_cur")]
	        public string InitOrderAmtCur { get; set; }
	
	        /// <summary>
	        /// 纠纷状态(NO_ISSUE:无纠纷；IN_ISSUE:纠纷中；END_ISSUE:纠纷结束)
	        /// </summary>
	        [XmlElement("issue_status")]
	        public string IssueStatus { get; set; }
	
	        /// <summary>
	        /// lot数量
	        /// </summary>
	        [XmlElement("lot_num")]
	        public string LotNum { get; set; }
	
	        /// <summary>
	        /// 商品排序号
	        /// </summary>
	        [XmlElement("order_sort_id")]
	        public long OrderSortId { get; set; }
	
	        /// <summary>
	        /// 子订单状态
	        /// </summary>
	        [XmlElement("order_status")]
	        public string OrderStatus { get; set; }
	
	        /// <summary>
	        /// 商品属性
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
	        /// 商品名称
	        /// </summary>
	        [XmlElement("product_name")]
	        public string ProductName { get; set; }
	
	        /// <summary>
	        /// 商品价格
	        /// </summary>
	        [XmlElement("product_price")]
	        public string ProductPrice { get; set; }
	
	        /// <summary>
	        /// 商品价格的货币单位
	        /// </summary>
	        [XmlElement("product_price_cur")]
	        public string ProductPriceCur { get; set; }
	
	        /// <summary>
	        /// 商品规格
	        /// </summary>
	        [XmlElement("product_standard")]
	        public string ProductStandard { get; set; }
	
	        /// <summary>
	        /// 商品计量单位
	        /// </summary>
	        [XmlElement("product_unit")]
	        public string ProductUnit { get; set; }
	
	        /// <summary>
	        /// 商品的SKU编码
	        /// </summary>
	        [XmlElement("sku_code")]
	        public string SkuCode { get; set; }
}

	/// <summary>
/// OrderTradeInfoDomain Data Structure.
/// </summary>
[Serializable]

public class OrderTradeInfoDomain : TopObject
{
	        /// <summary>
	        /// 商品列表
	        /// </summary>
	        [XmlArray("child_order_list")]
	        [XmlArrayItem("child_order_dto")]
	        public List<ChildOrderDtoDomain> ChildOrderList { get; set; }
	
	        /// <summary>
	        /// 订单ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 订单初始金额
	        /// </summary>
	        [XmlElement("init_oder_amount")]
	        public string InitOderAmount { get; set; }
	
	        /// <summary>
	        /// 订单金额的货币单位
	        /// </summary>
	        [XmlElement("init_oder_amount_cur")]
	        public string InitOderAmountCur { get; set; }
	
	        /// <summary>
	        /// 是否手机订单
	        /// </summary>
	        [XmlElement("is_phone")]
	        public bool IsPhone { get; set; }
	
	        /// <summary>
	        /// 物流金额（仅返回买家支付的物流费用）
	        /// </summary>
	        [XmlElement("logistics_amount")]
	        public string LogisticsAmount { get; set; }
	
	        /// <summary>
	        /// 物流金额的货币单位
	        /// </summary>
	        [XmlElement("logistics_amount_cur")]
	        public string LogisticsAmountCur { get; set; }
	
	        /// <summary>
	        /// 订单金额
	        /// </summary>
	        [XmlElement("order_amount")]
	        public string OrderAmount { get; set; }
	
	        /// <summary>
	        /// 订单金额货币单位
	        /// </summary>
	        [XmlElement("order_amount_cur")]
	        public string OrderAmountCur { get; set; }
}

    }
}
