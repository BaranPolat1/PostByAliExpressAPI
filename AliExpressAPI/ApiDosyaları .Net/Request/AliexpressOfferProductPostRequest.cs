using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.offer.product.post
    /// </summary>
    public class AliexpressOfferProductPostRequest : BaseTopRequest<Top.Api.Response.AliexpressOfferProductPostResponse>
    {
        /// <summary>
        /// 待发布商品数据
        /// </summary>
        public string AeopAEProduct { get; set; }

        public AeopAeProductDomain AeopAEProduct_ { set { this.AeopAEProduct = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.offer.product.post";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("aeop_a_e_product", this.AeopAEProduct);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("aeop_a_e_product", this.AeopAEProduct);
        }

	/// <summary>
/// AeopAeVideoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAeVideoDomain : TopObject
{
	        /// <summary>
	        /// 媒体唯一标识Id
	        /// </summary>
	        [XmlElement("media_id")]
	        public Nullable<long> MediaId { get; set; }
	
	        /// <summary>
	        /// 媒体类型
	        /// </summary>
	        [XmlElement("media_type")]
	        public string MediaType { get; set; }
	
	        /// <summary>
	        /// 媒体封面URL
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
	        /// 主图视频，只允许一个
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
	        /// 属性名称
	        /// </summary>
	        [XmlElement("attr_name")]
	        public string AttrName { get; set; }
	
	        /// <summary>
	        /// 属性名Id
	        /// </summary>
	        [XmlElement("attr_name_id")]
	        public Nullable<long> AttrNameId { get; set; }
	
	        /// <summary>
	        /// 属性值
	        /// </summary>
	        [XmlElement("attr_value")]
	        public string AttrValue { get; set; }
	
	        /// <summary>
	        /// 属性值区间结束
	        /// </summary>
	        [XmlElement("attr_value_end")]
	        public string AttrValueEnd { get; set; }
	
	        /// <summary>
	        /// 属性值Id
	        /// </summary>
	        [XmlElement("attr_value_id")]
	        public Nullable<long> AttrValueId { get; set; }
	
	        /// <summary>
	        /// 属性值区间开始
	        /// </summary>
	        [XmlElement("attr_value_start")]
	        public string AttrValueStart { get; set; }
	
	        /// <summary>
	        /// 属性值单位
	        /// </summary>
	        [XmlElement("attr_value_unit")]
	        public string AttrValueUnit { get; set; }
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
	        /// sku分国家的日常促销价的国家：ISO两位的国家编码（目前支持国家：RU US CA ES FR UK NL IL BR CL AU UA BY JP TH SG KR ID MY PH VN IT DE SA AE PL TR）
	        /// </summary>
	        [XmlElement("shipto_country")]
	        public string ShiptoCountry { get; set; }
}

	/// <summary>
/// AeopSkuPropertyDomain Data Structure.
/// </summary>
[Serializable]

public class AeopSkuPropertyDomain : TopObject
{
	        /// <summary>
	        /// 属性自定义名称
	        /// </summary>
	        [XmlElement("property_value_definition_name")]
	        public string PropertyValueDefinitionName { get; set; }
	
	        /// <summary>
	        /// 属性值Id
	        /// </summary>
	        [XmlElement("property_value_id")]
	        public Nullable<long> PropertyValueId { get; set; }
	
	        /// <summary>
	        /// 自定义图片
	        /// </summary>
	        [XmlElement("sku_image")]
	        public string SkuImage { get; set; }
	
	        /// <summary>
	        /// 属性Id
	        /// </summary>
	        [XmlElement("sku_property_id")]
	        public Nullable<long> SkuPropertyId { get; set; }
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
	        [XmlArray("aeop_s_k_u_national_discount_price")]
	        [XmlArrayItem("aeop_sku_national_discount_price")]
	        public List<AeopSkuNationalDiscountPriceDomain> AeopSKUNationalDiscountPrice { get; set; }
	
	        /// <summary>
	        /// sku属性列表
	        /// </summary>
	        [XmlArray("aeop_s_k_u_property")]
	        [XmlArrayItem("aeop_sku_property")]
	        public List<AeopSkuPropertyDomain> AeopSKUProperty { get; set; }
	
	        /// <summary>
	        /// 商品条形码
	        /// </summary>
	        [XmlElement("barcode")]
	        public string Barcode { get; set; }
	
	        /// <summary>
	        /// 货币单位。如果不提供该值信息，则默认为"USD"；非俄罗斯卖家这个属性值可以不提供。对于俄罗斯海外卖家，该单位值必须提供，如: "RUB"。
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
	
	        /// <summary>
	        /// sku库存
	        /// </summary>
	        [XmlElement("ipm_sku_stock")]
	        public Nullable<long> IpmSkuStock { get; set; }
	
	        /// <summary>
	        /// 商品编码
	        /// </summary>
	        [XmlElement("sku_code")]
	        public string SkuCode { get; set; }
	
	        /// <summary>
	        /// sku日常促销价
	        /// </summary>
	        [XmlElement("sku_discount_price")]
	        public string SkuDiscountPrice { get; set; }
	
	        /// <summary>
	        /// sku价格
	        /// </summary>
	        [XmlElement("sku_price")]
	        public string SkuPrice { get; set; }
}

	/// <summary>
/// AeopNationalQuoteConfigurationDomain Data Structure.
/// </summary>
[Serializable]

public class AeopNationalQuoteConfigurationDomain : TopObject
{
	        /// <summary>
	        /// jsonArray格式的分国家定价规则数据。 [{"absoluteQuoteMap":{"":1.0},"shiptoCountry":"RU"},{"absoluteQuoteMap":{"":2.0},"shiptoCountry":"US"}] 其中shiptoCountry：ISO两位的国家编码（目前支持国家：RU US CA ES FR UK NL IL BR CL AU UA BY JP TH SG KR ID MY PH VN IT DE SA AE PL TR）， absoluteQuoteMap：价格调整信息，为map结构，其中的key为[sku_property_id:property_value_id]，如果多个sku属性，则用“;”进行分割，没有sku则直接用空字符串，示例为"", "14:173", "14:173;3:2034781"；值则为具体的按照configuration_type设置的数据 percentage：相对于基准价的调价比例（百分比整数，支持负数，当前限制>=-30 && <=100）; relative: 相对基准价的调整值，支持负数; absolute：直接设置具体数值，不支持负数。
	        /// </summary>
	        [XmlElement("configuration_data")]
	        public string ConfigurationData { get; set; }
	
	        /// <summary>
	        /// 分国家定价规则类型[percentage：基于基准价格按比例配置; relative:相对原价涨或跌多少; absolute: 直接报价]
	        /// </summary>
	        [XmlElement("configuration_type")]
	        public string ConfigurationType { get; set; }
}

	/// <summary>
/// DetailSourceDomain Data Structure.
/// </summary>
[Serializable]

public class DetailSourceDomain : TopObject
{
	        /// <summary>
	        /// 详描locale
	        /// </summary>
	        [XmlElement("locale")]
	        public string Locale { get; set; }
	
	        /// <summary>
	        /// 移动端详描内容，具体格式请参考：https://developers.aliexpress.com/doc.htm?docId=109513&docType=1
	        /// </summary>
	        [XmlElement("mobile_detail")]
	        public string MobileDetail { get; set; }
	
	        /// <summary>
	        /// PC 端详描内容，具体格式请参考：https://developers.aliexpress.com/doc.htm?docId=109513&docType=1
	        /// </summary>
	        [XmlElement("web_detail")]
	        public string WebDetail { get; set; }
}

	/// <summary>
/// SubjectDomain Data Structure.
/// </summary>
[Serializable]

public class SubjectDomain : TopObject
{
	        /// <summary>
	        /// 标题locale
	        /// </summary>
	        [XmlElement("locale")]
	        public string Locale { get; set; }
	
	        /// <summary>
	        /// 标题内容
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
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
	        public Nullable<long> ImageType { get; set; }
	
	        /// <summary>
	        /// 营销图片URL
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// AeopAeProductDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAeProductDomain : TopObject
{
	        /// <summary>
	        /// isPackSell为true时,此项必填。 每增加件数.取值范围1-1000。
	        /// </summary>
	        [XmlElement("add_unit")]
	        public Nullable<long> AddUnit { get; set; }
	
	        /// <summary>
	        /// isPackSell为true时,此项必填。 对应增加的重量.取值范围:0.001-500.000,保留三位小数,采用进位制,单位:公斤。
	        /// </summary>
	        [XmlElement("add_weight")]
	        public string AddWeight { get; set; }
	
	        /// <summary>
	        /// 多媒体对象
	        /// </summary>
	        [XmlElement("aeop_a_e_multimedia")]
	        public AeopAeMultimediaDomain AeopAEMultimedia { get; set; }
	
	        /// <summary>
	        /// 产品属性，以json格式进行封装后提交。参看aeopAeProductPropertys数据结构。此字段是否必填，需从类目接口getChildAttributesResultByPostCateIdAndPath获取（即获取到的required来判断属性是否必填），该项只输入普通类目属性数据，不可输入sku类目属性。 对于类目属性包含子类目属性的情况，此处不确认父属性和子属性，即选择任何属性，都以该对象提交。 对于一个属性多个选中值的情况，以多个该对象存放。 其中"attrNameId","attrValueId"为整型(Integer), "attrName", "attrValue"为字符串类型(String)。 1. 当设置一些系统属性时，如果类目自定义了一些候选值，只需要提供"attrNameId"和"attrValueId"即可。例如：{"attrNameId":494, "attrValueId":284}。 2. 当设置一些需要手工输入属性内容时，只需要提供"attrNameId"和"attrValue"即可。例如：{"attrNameId": 1000, "attrValue": "test"} 3. 当设置自定义属性时，需要提供"attrName"和"attrValue"即可。例如: {"attrName": "Color", "attrValue": "red"} 4. 当设置一个Other属性时，需要提供"attrNameId", "attrValueId", "attrValue"三个参数。例如：{"attrNameId": 1000, "attrValueId": 4, "attrValue": "Other Value"}。
	        /// </summary>
	        [XmlArray("aeop_ae_product_propertys")]
	        [XmlArrayItem("aeop_ae_product_property")]
	        public List<AeopAeProductPropertyDomain> AeopAeProductPropertys { get; set; }
	
	        /// <summary>
	        /// 列表类型，以json格式来表达。参看aeopAeProductSKUs数据结构。特别提示：新增SKU实际可售库存属性ipmSkuStock，该属性值的合理取值范围为0~999999，如该商品有SKU时，请确保至少有一个SKU是有货状态，也就是ipmSkuStock取值是1~999999，在整个商品纬度库存值的取值范围是1~999999。
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
	        /// isPackSell为true时,此项必填。购买几件以内不增加运费。取值范围1-1000
	        /// </summary>
	        [XmlElement("base_unit")]
	        public Nullable<long> BaseUnit { get; set; }
	
	        /// <summary>
	        /// 批发折扣。扩大100倍，存整数。取值范围:1-99。注意：这是折扣，不是打折率。 如,打68折,则存32。批发最小数量和批发折扣需同时有值或无值。
	        /// </summary>
	        [XmlElement("bulk_discount")]
	        public Nullable<long> BulkDiscount { get; set; }
	
	        /// <summary>
	        /// 批发最小数量 。取值范围2-100000。批发最小数量和批发折扣需同时有值或无值。
	        /// </summary>
	        [XmlElement("bulk_order")]
	        public Nullable<long> BulkOrder { get; set; }
	
	        /// <summary>
	        /// 商品所属类目ID。必须是叶子类目，通过类目接口获取。
	        /// </summary>
	        [XmlElement("category_id")]
	        public Nullable<long> CategoryId { get; set; }
	
	        /// <summary>
	        /// 货币单位。如果不提供该值信息，则默认为"USD"；非俄罗斯卖家这个属性值可以不提供。对于俄罗斯海外卖家，该单位值必须提供，如: "RUB"。
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
	
	        /// <summary>
	        /// 备货期。取值范围:1-60;单位:天。
	        /// </summary>
	        [XmlElement("delivery_time")]
	        public Nullable<long> DeliveryTime { get; set; }
	
	        /// <summary>
	        /// 商品详描
	        /// </summary>
	        [XmlArray("detail_source_list")]
	        [XmlArrayItem("detail_source")]
	        public List<DetailSourceDomain> DetailSourceList { get; set; }
	
	        /// <summary>
	        /// 运费模版ID。通过运费接口listFreightTemplate获取。
	        /// </summary>
	        [XmlElement("freight_template_id")]
	        public Nullable<long> FreightTemplateId { get; set; }
	
	        /// <summary>
	        /// 商品毛重,取值范围:0.001-500.000,保留三位小数,采用进位制,单位:公斤。
	        /// </summary>
	        [XmlElement("gross_weight")]
	        public string GrossWeight { get; set; }
	
	        /// <summary>
	        /// 这个产品需要关联的产品分组ID. 只能关联一个产品分组，如果想关联多个产品分组，请使用api.setGroups接口。
	        /// </summary>
	        [XmlElement("group_id")]
	        public Nullable<long> GroupId { get; set; }
	
	        /// <summary>
	        /// 产品的主图URL列表。如果这个产品有多张主图，那么这些URL之间使用英文分号(";")隔开。一个产品最多只能有6张主图。图片格式JPEG，文件大小5M以内；图片像素建议大于800*800；横向和纵向比例建议1:1到1:1.3之间；图片中产品主体占比建议大于70%；背景白色或纯色，风格统一；如果有LOGO，建议放置在左上角，不宜过大。不建议自行添加促销标签或文字。切勿盗用他人图片，以免受网规处罚。更多说明请至http://seller.aliexpress.com/so/tupianguifan.php进行了解。
	        /// </summary>
	        [XmlElement("image_u_r_ls")]
	        public string ImageURLs { get; set; }
	
	        /// <summary>
	        /// 是否自定义计重.true为自定义计重,false反之.
	        /// </summary>
	        [XmlElement("is_pack_sell")]
	        public Nullable<bool> IsPackSell { get; set; }
	
	        /// <summary>
	        /// 商品原发locale，标记商品的发布初始locale，用于标记初始发布语种
	        /// </summary>
	        [XmlElement("locale")]
	        public string Locale { get; set; }
	
	        /// <summary>
	        /// 每包件数。 打包销售情况，lotNum>1,非打包销售情况,lotNum=1
	        /// </summary>
	        [XmlElement("lot_num")]
	        public Nullable<long> LotNum { get; set; }
	
	        /// <summary>
	        /// 营销图列表
	        /// </summary>
	        [XmlArray("market_images")]
	        [XmlArrayItem("market_image")]
	        public List<MarketImageDomain> MarketImages { get; set; }
	
	        /// <summary>
	        /// 商品包装高度。取值范围:1-700,单位:厘米。
	        /// </summary>
	        [XmlElement("package_height")]
	        public Nullable<long> PackageHeight { get; set; }
	
	        /// <summary>
	        /// 商品包装长度。取值范围:1-700,单位:厘米。产品包装尺寸的最大值+2×（第二大值+第三大值）不能超过2700厘米。
	        /// </summary>
	        [XmlElement("package_length")]
	        public Nullable<long> PackageLength { get; set; }
	
	        /// <summary>
	        /// 打包销售: true 非打包销售:false
	        /// </summary>
	        [XmlElement("package_type")]
	        public Nullable<bool> PackageType { get; set; }
	
	        /// <summary>
	        /// 商品包装宽度。取值范围:1-700,单位:厘米。
	        /// </summary>
	        [XmlElement("package_width")]
	        public Nullable<long> PackageWidth { get; set; }
	
	        /// <summary>
	        /// 商品默认价格。取值范围:0-100000,保留两位小数;单位:美元。如:200.07，表示:200美元7分。需要在正确的价格区间内。上传多属性产品的时候，有好几个SKU和价格，productprice无需填写。
	        /// </summary>
	        [XmlElement("product_price")]
	        public string ProductPrice { get; set; }
	
	        /// <summary>
	        /// 商品单位 (存储单位编号) 100000000:袋 (bag/bags)100000001:桶 (barrel/barrels)100000002:蒲式耳 (bushel/bushels)100078580:箱 (carton)100078581:厘米 (centimeter)100000003:立方米 (cubic meter)100000004:打 (dozen)100078584:英尺 (feet)100000005:加仑 (gallon)100000006:克 (gram)100078587:英寸 (inch)100000007:千克 (kilogram)100078589:千升 (kiloliter)100000008:千米 (kilometer)100078559:升 (liter/liters)100000009:英吨 (long ton)100000010:米 (meter)100000011:公吨 (metric ton)100078560:毫克 (milligram)100078596:毫升 (milliliter)100078597:毫米 (millimeter)100000012:盎司 (ounce)100000014:包 (pack/packs)100000013:双 (pair)100000015:件/个 (piece/pieces)100000016:磅 (pound)100078603:夸脱 (quart)100000017:套 (set/sets)100000018:美吨 (short ton)100078606:平方英尺 (square feet)100078607:平方英寸 (square inch)100000019:平方米 (square meter)100078609:平方码 (square yard)100000020:吨 (ton)100078558:码 (yard/yards)
	        /// </summary>
	        [XmlElement("product_unit")]
	        public Nullable<long> ProductUnit { get; set; }
	
	        /// <summary>
	        /// 服务模板设置。（需和服务模板查询接口api.queryPromiseTemplateById进行关联使用）
	        /// </summary>
	        [XmlElement("promise_template_id")]
	        public Nullable<long> PromiseTemplateId { get; set; }
	
	        /// <summary>
	        /// 库存扣减策略，总共有2种：下单减库存(place_order_withhold)和支付减库存(payment_success_deduct)。
	        /// </summary>
	        [XmlElement("reduce_strategy")]
	        public string ReduceStrategy { get; set; }
	
	        /// <summary>
	        /// 尺码表模版ID。必须选择当前类目下的尺码模版。
	        /// </summary>
	        [XmlElement("sizechart_id")]
	        public Nullable<long> SizechartId { get; set; }
	
	        /// <summary>
	        /// 商品多语言标题
	        /// </summary>
	        [XmlArray("subject_list")]
	        [XmlArrayItem("subject")]
	        public List<SubjectDomain> SubjectList { get; set; }
	
	        /// <summary>
	        /// 商品有效天数。取值范围:1-30,单位:天。
	        /// </summary>
	        [XmlElement("ws_valid_num")]
	        public Nullable<long> WsValidNum { get; set; }
}

        #endregion
    }
}
