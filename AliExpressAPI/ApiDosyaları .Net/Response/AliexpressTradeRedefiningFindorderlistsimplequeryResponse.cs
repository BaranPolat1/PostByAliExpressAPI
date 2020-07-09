using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressTradeRedefiningFindorderlistsimplequeryResponse.
    /// </summary>
    public class AliexpressTradeRedefiningFindorderlistsimplequeryResponse : TopResponse
    {
        /// <summary>
        /// 出参
        /// </summary>
        [XmlElement("result")]
        public SimpleOrderListVoDomain Result { get; set; }

	/// <summary>
/// SimpleOrderProductVoDomain Data Structure.
/// </summary>
[Serializable]

public class SimpleOrderProductVoDomain : TopObject
{
	        /// <summary>
	        /// 子订单号
	        /// </summary>
	        [XmlElement("child_id")]
	        public long ChildId { get; set; }
	
	        /// <summary>
	        /// 备货时间
	        /// </summary>
	        [XmlElement("goods_prepare_time")]
	        public long GoodsPrepareTime { get; set; }
	
	        /// <summary>
	        /// 是否假一赔三产品
	        /// </summary>
	        [XmlElement("money_back3x")]
	        public bool MoneyBack3x { get; set; }
	
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
	        /// 商品主图URL
	        /// </summary>
	        [XmlElement("product_img_url")]
	        public string ProductImgUrl { get; set; }
	
	        /// <summary>
	        /// 商品名称
	        /// </summary>
	        [XmlElement("product_name")]
	        public string ProductName { get; set; }
	
	        /// <summary>
	        /// 快照URL
	        /// </summary>
	        [XmlElement("product_snap_url")]
	        public string ProductSnapUrl { get; set; }
	
	        /// <summary>
	        /// 商品单位
	        /// </summary>
	        [XmlElement("product_unit")]
	        public string ProductUnit { get; set; }
	
	        /// <summary>
	        /// 商品单价
	        /// </summary>
	        [XmlElement("product_unit_price")]
	        public string ProductUnitPrice { get; set; }
	
	        /// <summary>
	        /// 商品货币名称
	        /// </summary>
	        [XmlElement("product_unit_price_cur")]
	        public string ProductUnitPriceCur { get; set; }
	
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
}

	/// <summary>
/// SimpleOrderItemVoDomain Data Structure.
/// </summary>
[Serializable]

public class SimpleOrderItemVoDomain : TopObject
{
	        /// <summary>
	        /// 订单类型（AE_COMMON:普通订单;AE_TRIAL:试用订单;AE_RECHARGE:手机充值订单)
	        /// </summary>
	        [XmlElement("biz_type")]
	        public string BizType { get; set; }
	
	        /// <summary>
	        /// 订单创建时间，美国太平洋时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 订单修改时间，美国太平洋时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 订单备注
	        /// </summary>
	        [XmlElement("memo")]
	        public string Memo { get; set; }
	
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
	        /// 商品列表
	        /// </summary>
	        [XmlArray("product_list")]
	        [XmlArrayItem("simple_order_product_vo")]
	        public List<SimpleOrderProductVoDomain> ProductList { get; set; }
	
	        /// <summary>
	        /// 当前状态的超时剩余时间，单位毫秒（负数表示已超时时间）。已作废,不再返回值。
	        /// </summary>
	        [XmlElement("timeout_left_time")]
	        public long TimeoutLeftTime { get; set; }
}

	/// <summary>
/// SimpleOrderListVoDomain Data Structure.
/// </summary>
[Serializable]

public class SimpleOrderListVoDomain : TopObject
{
	        /// <summary>
	        /// 订单列表
	        /// </summary>
	        [XmlArray("order_list")]
	        [XmlArrayItem("simple_order_item_vo")]
	        public List<SimpleOrderItemVoDomain> OrderList { get; set; }
	
	        /// <summary>
	        /// 总数量(SC订单不包含在结果中）
	        /// </summary>
	        [XmlElement("total_item")]
	        public long TotalItem { get; set; }
}

    }
}
