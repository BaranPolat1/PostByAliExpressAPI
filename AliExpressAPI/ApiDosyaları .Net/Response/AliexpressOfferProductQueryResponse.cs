using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressOfferProductQueryResponse.
    /// </summary>
    public class AliexpressOfferProductQueryResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopFindProductResultDtoDomain Result { get; set; }

	/// <summary>
/// AeopAeVideoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAeVideoDomain : TopObject
{
	        /// <summary>
	        /// 视频ID
	        /// </summary>
	        [XmlElement("media_id")]
	        public long MediaId { get; set; }
	
	        /// <summary>
	        /// 视频的类型
	        /// </summary>
	        [XmlElement("media_type")]
	        public string MediaType { get; set; }
	
	        /// <summary>
	        /// 视频封面图片的URL
	        /// </summary>
	        [XmlElement("poster_url")]
	        public string PosterUrl { get; set; }
}

	/// <summary>
/// AeopAeMultimediaDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAeMultimediaDomain : TopObject
{
	        /// <summary>
	        /// 多媒体信息。
	        /// </summary>
	        [XmlArray("aeop_a_e_videos")]
	        [XmlArrayItem("aeop_ae_video")]
	        public List<AeopAeVideoDomain> AeopAEVideos { get; set; }
}

	/// <summary>
/// AeopAeProductPropertyDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAeProductPropertyDomain : TopObject
{
	        /// <summary>
	        /// 自定义属性名属性名。 自定义属性名时,该项必填.
	        /// </summary>
	        [XmlElement("attr_name")]
	        public string AttrName { get; set; }
	
	        /// <summary>
	        /// 属性名ID。从类目属性接口getAttributesResultByCateId获取普通类目属性，不可填入sku属性。 自定义属性名时,该项不填.
	        /// </summary>
	        [XmlElement("attr_name_id")]
	        public long AttrNameId { get; set; }
	
	        /// <summary>
	        /// 自定义属性值。自定义属性名时,该项必填。 当自定义属性值内容为区间情况时，建议格式2 - 5 kg。(注意，数字'-'单位三者间是要加空格的！)
	        /// </summary>
	        [XmlElement("attr_value")]
	        public string AttrValue { get; set; }
	
	        /// <summary>
	        /// 自定义属性值的结束端
	        /// </summary>
	        [XmlElement("attr_value_end")]
	        public string AttrValueEnd { get; set; }
	
	        /// <summary>
	        /// 属性值ID
	        /// </summary>
	        [XmlElement("attr_value_id")]
	        public long AttrValueId { get; set; }
	
	        /// <summary>
	        /// 自定义属性值的开始端
	        /// </summary>
	        [XmlElement("attr_value_start")]
	        public string AttrValueStart { get; set; }
	
	        /// <summary>
	        /// 自定义属性值单位
	        /// </summary>
	        [XmlElement("attr_value_unit")]
	        public string AttrValueUnit { get; set; }
}

	/// <summary>
/// AeopSkuPropertyDomain Data Structure.
/// </summary>
[Serializable]

public class AeopSkuPropertyDomain : TopObject
{
	        /// <summary>
	        /// 属性值自定义名称
	        /// </summary>
	        [XmlElement("property_value_definition_name")]
	        public string PropertyValueDefinitionName { get; set; }
	
	        /// <summary>
	        /// SKU属性值ID
	        /// </summary>
	        [XmlElement("property_value_id")]
	        public long PropertyValueId { get; set; }
	
	        /// <summary>
	        /// SKU图片地址
	        /// </summary>
	        [XmlElement("sku_image")]
	        public string SkuImage { get; set; }
	
	        /// <summary>
	        /// SKU属性ID
	        /// </summary>
	        [XmlElement("sku_property_id")]
	        public long SkuPropertyId { get; set; }
}

	/// <summary>
/// AeopSkuNationalDiscountPriceDomain Data Structure.
/// </summary>
[Serializable]

public class AeopSkuNationalDiscountPriceDomain : TopObject
{
	        /// <summary>
	        /// sku分国家的日常促销价价格
	        /// </summary>
	        [XmlElement("discount_price")]
	        public string DiscountPrice { get; set; }
	
	        /// <summary>
	        /// sku分国家的日常促销价国家
	        /// </summary>
	        [XmlElement("shipto_country")]
	        public string ShiptoCountry { get; set; }
}

	/// <summary>
/// AeopAeProductSkuDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAeProductSkuDomain : TopObject
{
	        /// <summary>
	        /// sku分国家的日常促销价
	        /// </summary>
	        [XmlArray("aeop_s_k_u_national_discount_price_list")]
	        [XmlArrayItem("aeop_sku_national_discount_price")]
	        public List<AeopSkuNationalDiscountPriceDomain> AeopSKUNationalDiscountPriceList { get; set; }
	
	        /// <summary>
	        /// Sku属性对象list，允许1-3个sku属性对象，按sku属性顺序排放。sku属性从类目属性接口getAttributesResultByCateId获取。该项值输入sku属性，不能输入普通类目属性。注意，sku属性是有顺序的，必须按照顺序存放。
	        /// </summary>
	        [XmlArray("aeop_s_k_u_property_list")]
	        [XmlArrayItem("aeop_sku_property")]
	        public List<AeopSkuPropertyDomain> AeopSKUPropertyList { get; set; }
	
	        /// <summary>
	        /// 条码，所有的仓发商品（尖货，自营，假发）会返回这个参数
	        /// </summary>
	        [XmlElement("barcode")]
	        public string Barcode { get; set; }
	
	        /// <summary>
	        /// 产品的货币单位。美元: USD, 卢布: RUB
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
	
	        /// <summary>
	        /// SKU ID，格式：“sku_property_id:property_value_id”
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// SKU实际可售库存属性ipmSkuStock，该属性值的合理取值范围为0~999999，如该商品有SKU时，请确保至少有一个SKU是有货状态，也就是ipmSkuStock取值是1~999999，在整个商品纬度库存值的取值范围是1~999999。 如果同时设置了skuStock属性，那么系统以ipmSkuStock属性为优先；如果没有设置ipmSkuStock属性，那么系统会根据skuStock属性进行设置库存，true表示999，false表示0。
	        /// </summary>
	        [XmlElement("ipm_sku_stock")]
	        public long IpmSkuStock { get; set; }
	
	        /// <summary>
	        /// Sku商家编码。 格式:半角英数字,长度20,不包含空格大于号和小于号。如果用户只填写零售价（productprice）和商品编码，需要完整生成一条SKU记录提交，否则商品编码无法保存。系统会认为只提交了零售价，而没有SKU，导致商品编辑未保存。
	        /// </summary>
	        [XmlElement("sku_code")]
	        public string SkuCode { get; set; }
	
	        /// <summary>
	        /// sku日常促销价
	        /// </summary>
	        [XmlElement("sku_discount_price")]
	        public string SkuDiscountPrice { get; set; }
	
	        /// <summary>
	        /// Sku价格。取值范围:0.01-100000;单位:美元。 如:200.07，表示:200美元7分。需要在正确的价格区间内。
	        /// </summary>
	        [XmlElement("sku_price")]
	        public string SkuPrice { get; set; }
	
	        /// <summary>
	        /// Sku库存,数据格式有货true，无货false；至少有一条sku记录是有货的。
	        /// </summary>
	        [XmlElement("sku_stock")]
	        public bool SkuStock { get; set; }
}

	/// <summary>
/// AeopNationalQuoteConfigurationDomain Data Structure.
/// </summary>
[Serializable]

public class AeopNationalQuoteConfigurationDomain : TopObject
{
	        /// <summary>
	        /// jsonArray格式的分国家定价规则数据。 1)基于基准价格按比例配置的数据格式；2)基于基准价格按涨或者跌多少；3）为每个SKU直接设置价格绝对值。其中shiptoCountry：ISO两位的国家编码（目前支持国家：RU US CA ES FR UK NL IL BR CL AU UA BY JP TH SG KR ID MY PH VN IT DE SA AE PL TR）， percentage：相对于基准价的调价比例（百分比整数，支持负数，当前限制>=-30 && <=100）；configuration_type为absolute：14:193为sku属性ID：SKU属性值， 多个属性用，号拼接。
	        /// </summary>
	        [XmlElement("configuration_data")]
	        public string ConfigurationData { get; set; }
	
	        /// <summary>
	        /// 分国家定价规则类型[absolute: 为每个SKU直接设置价格绝对值；percentage：基于基准价格按比例配置; relative:相对原价涨或跌多少;
	        /// </summary>
	        [XmlElement("configuration_type")]
	        public string ConfigurationType { get; set; }
}

	/// <summary>
/// SubjectDomain Data Structure.
/// </summary>
[Serializable]

public class SubjectDomain : TopObject
{
	        /// <summary>
	        /// 语种标记locale
	        /// </summary>
	        [XmlElement("locale")]
	        public string Locale { get; set; }
	
	        /// <summary>
	        /// 多语言标题内容
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// DetailSourceDomain Data Structure.
/// </summary>
[Serializable]

public class DetailSourceDomain : TopObject
{
	        /// <summary>
	        /// 详描语种locale
	        /// </summary>
	        [XmlElement("locale")]
	        public string Locale { get; set; }
	
	        /// <summary>
	        /// 移动端详描内容
	        /// </summary>
	        [XmlElement("mobile_detail")]
	        public string MobileDetail { get; set; }
	
	        /// <summary>
	        /// PC端详描内容
	        /// </summary>
	        [XmlElement("web_detail")]
	        public string WebDetail { get; set; }
}

	/// <summary>
/// MarketImageDomain Data Structure.
/// </summary>
[Serializable]

public class MarketImageDomain : TopObject
{
	        /// <summary>
	        /// 1：代表长图，大小为750*1000; 2：代表方图，大小为800*800
	        /// </summary>
	        [XmlElement("image_type")]
	        public long ImageType { get; set; }
	
	        /// <summary>
	        /// 营销图片URL
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// AeopFindProductResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopFindProductResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 每增加件数.取值范围1-1000。
	        /// </summary>
	        [XmlElement("add_unit")]
	        public long AddUnit { get; set; }
	
	        /// <summary>
	        /// 对应增加的重量.取值范围:0.001-500.000,保留三位小数,采用进位制,单位:公斤。
	        /// </summary>
	        [XmlElement("add_weight")]
	        public string AddWeight { get; set; }
	
	        /// <summary>
	        /// 商品多媒体信息，该属性主要包含商品的视频列表
	        /// </summary>
	        [XmlElement("aeop_a_e_multimedia")]
	        public AeopAeMultimediaDomain AeopAEMultimedia { get; set; }
	
	        /// <summary>
	        /// 商品的类目属性
	        /// </summary>
	        [XmlArray("aeop_ae_product_propertys")]
	        [XmlArrayItem("aeop_ae_product_property")]
	        public List<AeopAeProductPropertyDomain> AeopAeProductPropertys { get; set; }
	
	        /// <summary>
	        /// 商品的SKU信息
	        /// </summary>
	        [XmlArray("aeop_ae_product_s_k_us")]
	        [XmlArrayItem("aeop_ae_product_sku")]
	        public List<AeopAeProductSkuDomain> AeopAeProductSKUs { get; set; }
	
	        /// <summary>
	        /// 商品分国家报价的配置
	        /// </summary>
	        [XmlElement("aeop_national_quote_configuration")]
	        public AeopNationalQuoteConfigurationDomain AeopNationalQuoteConfiguration { get; set; }
	
	        /// <summary>
	        /// 自定义计重的基本产品件数
	        /// </summary>
	        [XmlElement("base_unit")]
	        public long BaseUnit { get; set; }
	
	        /// <summary>
	        /// 产品的批发折扣
	        /// </summary>
	        [XmlElement("bulk_discount")]
	        public long BulkDiscount { get; set; }
	
	        /// <summary>
	        /// 享受批发价的产品数
	        /// </summary>
	        [XmlElement("bulk_order")]
	        public long BulkOrder { get; set; }
	
	        /// <summary>
	        /// 产品所在类目的ID
	        /// </summary>
	        [XmlElement("category_id")]
	        public long CategoryId { get; set; }
	
	        /// <summary>
	        /// 产品的货币单位。美元: USD, 卢布: RUB
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
	
	        /// <summary>
	        /// 商品的备货期
	        /// </summary>
	        [XmlElement("delivery_time")]
	        public long DeliveryTime { get; set; }
	
	        /// <summary>
	        /// 多语言详描
	        /// </summary>
	        [XmlArray("detail_source_list")]
	        [XmlArrayItem("detail_source")]
	        public List<DetailSourceDomain> DetailSourceList { get; set; }
	
	        /// <summary>
	        /// 产品关联的运费模版ID
	        /// </summary>
	        [XmlElement("freight_template_id")]
	        public long FreightTemplateId { get; set; }
	
	        /// <summary>
	        /// 创建日期
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 修改日期
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 产品的毛重
	        /// </summary>
	        [XmlElement("gross_weight")]
	        public string GrossWeight { get; set; }
	
	        /// <summary>
	        /// 产品所关联的产品分组ID
	        /// </summary>
	        [XmlElement("group_id")]
	        public long GroupId { get; set; }
	
	        /// <summary>
	        /// 产品所在的产品分组列表
	        /// </summary>
	        [XmlArray("group_ids")]
	        [XmlArrayItem("number")]
	        public List<long> GroupIds { get; set; }
	
	        /// <summary>
	        /// 产品的主图列表
	        /// </summary>
	        [XmlElement("image_u_r_ls")]
	        public string ImageURLs { get; set; }
	
	        /// <summary>
	        /// 是否支持是自定义计重
	        /// </summary>
	        [XmlElement("is_pack_sell")]
	        public bool IsPackSell { get; set; }
	
	        /// <summary>
	        /// 关键字
	        /// </summary>
	        [XmlElement("keyword")]
	        public string Keyword { get; set; }
	
	        /// <summary>
	        /// 商品初始发布locale
	        /// </summary>
	        [XmlElement("locale")]
	        public string Locale { get; set; }
	
	        /// <summary>
	        /// 每包的数量
	        /// </summary>
	        [XmlElement("lot_num")]
	        public long LotNum { get; set; }
	
	        /// <summary>
	        /// 营销图列表
	        /// </summary>
	        [XmlArray("market_images")]
	        [XmlArrayItem("market_image")]
	        public List<MarketImageDomain> MarketImages { get; set; }
	
	        /// <summary>
	        /// 产品的高度
	        /// </summary>
	        [XmlElement("package_height")]
	        public long PackageHeight { get; set; }
	
	        /// <summary>
	        /// 产品的长度
	        /// </summary>
	        [XmlElement("package_length")]
	        public long PackageLength { get; set; }
	
	        /// <summary>
	        /// 打包销售: true 非打包销售:false
	        /// </summary>
	        [XmlElement("package_type")]
	        public bool PackageType { get; set; }
	
	        /// <summary>
	        /// 产品的宽度
	        /// </summary>
	        [XmlElement("package_width")]
	        public long PackageWidth { get; set; }
	
	        /// <summary>
	        /// 产品ID
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
	
	        /// <summary>
	        /// 单品产品的价格。
	        /// </summary>
	        [XmlElement("product_price")]
	        public string ProductPrice { get; set; }
	
	        /// <summary>
	        /// 产品的状态，包括onSelling（正在销售），offline（已下架），auditing（审核中），editingRequired（审核不通过）
	        /// </summary>
	        [XmlElement("product_status_type")]
	        public string ProductStatusType { get; set; }
	
	        /// <summary>
	        /// 产品的单位
	        /// </summary>
	        [XmlElement("product_unit")]
	        public long ProductUnit { get; set; }
	
	        /// <summary>
	        /// 产品所关联的服务模版
	        /// </summary>
	        [XmlElement("promise_template_id")]
	        public long PromiseTemplateId { get; set; }
	
	        /// <summary>
	        /// 库存的扣减策略
	        /// </summary>
	        [XmlElement("reduce_strategy")]
	        public string ReduceStrategy { get; set; }
	
	        /// <summary>
	        /// 产品所关联的尺码模版ID
	        /// </summary>
	        [XmlElement("sizechart_id")]
	        public long SizechartId { get; set; }
	
	        /// <summary>
	        /// 多语言标题
	        /// </summary>
	        [XmlArray("subject_list")]
	        [XmlArrayItem("subject")]
	        public List<SubjectDomain> SubjectList { get; set; }
	
	        /// <summary>
	        /// 产品的下架原因，包括user_offline：手动下架，expire_offline：到期下架，punish_offline：网规处罚下架，violate_offline：交易违规下架，degrade_offline：降级下架，industry_offline：未续约下架
	        /// </summary>
	        [XmlElement("ws_display")]
	        public string WsDisplay { get; set; }
	
	        /// <summary>
	        /// 产品的下架日期
	        /// </summary>
	        [XmlElement("ws_offline_date")]
	        public string WsOfflineDate { get; set; }
	
	        /// <summary>
	        /// 产品的有效期
	        /// </summary>
	        [XmlElement("ws_valid_num")]
	        public long WsValidNum { get; set; }
}

    }
}
