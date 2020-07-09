using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressDistributorOrderQueryResponse.
    /// </summary>
    public class AliexpressDistributorOrderQueryResponse : TopResponse
    {
        /// <summary>
        /// 分销订单列表
        /// </summary>
        [XmlArray("distribute_order_list")]
        [XmlArrayItem("module")]
        public List<ModuleDomain> DistributeOrderList { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 是否需要重试
        /// </summary>
        [XmlElement("need_retry")]
        public bool NeedRetry { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 订单总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

	/// <summary>
/// SubDistributeOrderListDomain Data Structure.
/// </summary>
[Serializable]

public class SubDistributeOrderListDomain : TopObject
{
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("comment")]
	        public string Comment { get; set; }
	
	        /// <summary>
	        /// 采购单价
	        /// </summary>
	        [XmlElement("distribute_unit_price")]
	        public string DistributeUnitPrice { get; set; }
	
	        /// <summary>
	        /// 采购履约状态: 采购中/采购失败/采购成功, 待发货/已发货/已到仓/入仓失败/已出仓/已取消
	        /// </summary>
	        [XmlElement("fulfillment_status")]
	        public string FulfillmentStatus { get; set; }
	
	        /// <summary>
	        /// 前台商品ID
	        /// </summary>
	        [XmlElement("item_id")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// 前台商品名称
	        /// </summary>
	        [XmlElement("item_title")]
	        public string ItemTitle { get; set; }
	
	        /// <summary>
	        /// 物流公司
	        /// </summary>
	        [XmlElement("logistics_company")]
	        public string LogisticsCompany { get; set; }
	
	        /// <summary>
	        /// 采购数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public long Quantity { get; set; }
	
	        /// <summary>
	        /// 销售单价
	        /// </summary>
	        [XmlElement("sale_unit_price")]
	        public string SaleUnitPrice { get; set; }
	
	        /// <summary>
	        /// 商品编码
	        /// </summary>
	        [XmlElement("seller_sku_code")]
	        public string SellerSkuCode { get; set; }
	
	        /// <summary>
	        /// 供应商发货时间
	        /// </summary>
	        [XmlElement("ship_time")]
	        public string ShipTime { get; set; }
	
	        /// <summary>
	        /// 快递单号
	        /// </summary>
	        [XmlElement("tracking_number")]
	        public string TrackingNumber { get; set; }
}

	/// <summary>
/// ModuleDomain Data Structure.
/// </summary>
[Serializable]

public class ModuleDomain : TopObject
{
	        /// <summary>
	        /// 采购下单时间, 格式: yyyy-MM-dd HH:mm:ss, 时间为美国太平洋时间
	        /// </summary>
	        [XmlElement("distribute_order_create_time")]
	        public string DistributeOrderCreateTime { get; set; }
	
	        /// <summary>
	        /// 采购币种
	        /// </summary>
	        [XmlElement("distribute_order_currency")]
	        public string DistributeOrderCurrency { get; set; }
	
	        /// <summary>
	        /// 分销订单号
	        /// </summary>
	        [XmlElement("distribute_order_id")]
	        public long DistributeOrderId { get; set; }
	
	        /// <summary>
	        /// 订单更新时间, 格式: yyyy-MM-dd HH:mm:ss, 时间为美国太平洋时间
	        /// </summary>
	        [XmlElement("distribute_order_modified_time")]
	        public string DistributeOrderModifiedTime { get; set; }
	
	        /// <summary>
	        /// 采购总金额
	        /// </summary>
	        [XmlElement("distribute_order_total_price")]
	        public string DistributeOrderTotalPrice { get; set; }
	
	        /// <summary>
	        /// 商家中国主体名称
	        /// </summary>
	        [XmlElement("distributor")]
	        public string Distributor { get; set; }
	
	        /// <summary>
	        /// 货源类型: 厂商直供/自营认证
	        /// </summary>
	        [XmlElement("item_source_type")]
	        public string ItemSourceType { get; set; }
	
	        /// <summary>
	        /// 采购付款状态: 未支付/支付中/支付成功/支付失败/支付已取消
	        /// </summary>
	        [XmlElement("payment_status")]
	        public string PaymentStatus { get; set; }
	
	        /// <summary>
	        /// 商家香港主体名称
	        /// </summary>
	        [XmlElement("purchaser")]
	        public string Purchaser { get; set; }
	
	        /// <summary>
	        /// 销售订单下单时间, 格式: yyyy-MM-dd HH:mm:ss, 时间为美国太平洋时间
	        /// </summary>
	        [XmlElement("sale_order_create_time")]
	        public string SaleOrderCreateTime { get; set; }
	
	        /// <summary>
	        /// 销售币种
	        /// </summary>
	        [XmlElement("sale_order_currency")]
	        public string SaleOrderCurrency { get; set; }
	
	        /// <summary>
	        /// 前台交易主单号(AE/TW)
	        /// </summary>
	        [XmlElement("sale_order_id")]
	        public long SaleOrderId { get; set; }
	
	        /// <summary>
	        /// 销售订单支付时间, 格式: yyyy-MM-dd HH:mm:ss, 时间为美国太平洋时间
	        /// </summary>
	        [XmlElement("sale_order_pay_time")]
	        public string SaleOrderPayTime { get; set; }
	
	        /// <summary>
	        /// 销售订单状态: 下单成功, 待支付/待发货/已发货/交易取消
	        /// </summary>
	        [XmlElement("sale_order_status")]
	        public string SaleOrderStatus { get; set; }
	
	        /// <summary>
	        /// 销售总金额
	        /// </summary>
	        [XmlElement("sale_order_total_price")]
	        public string SaleOrderTotalPrice { get; set; }
	
	        /// <summary>
	        /// 子订单列表
	        /// </summary>
	        [XmlArray("sub_distribute_order_list")]
	        [XmlArrayItem("sub_distribute_order_list")]
	        public List<SubDistributeOrderListDomain> SubDistributeOrderList { get; set; }
}

    }
}
