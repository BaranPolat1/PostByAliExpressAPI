using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.postmultilanguageaeproduct
    /// </summary>
    public class AliexpressPostproductRedefiningPostmultilanguageaeproductRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningPostmultilanguageaeproductResponse>
    {
        /// <summary>
        /// 产品信息
        /// </summary>
        public string Product { get; set; }

        public MultilanguageAeopAeProductDomain Product_ { set { this.Product = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.postmultilanguageaeproduct";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("product", this.Product);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
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
	        /// none
	        /// </summary>
	        [XmlElement("property_value_id")]
	        public Nullable<long> PropertyValueId { get; set; }
	
	        /// <summary>
	        /// SKU图片地址
	        /// </summary>
	        [XmlElement("sku_image")]
	        public string SkuImage { get; set; }
	
	        /// <summary>
	        /// SKU属性ID
	        /// </summary>
	        [XmlElement("sku_property_id")]
	        public Nullable<long> SkuPropertyId { get; set; }
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
	        /// sku分国家的日常促销价价格
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
	        [XmlArray("aeop_s_k_u_national_discount_price")]
	        [XmlArrayItem("aeop_sku_national_discount_price")]
	        public List<AeopSkuNationalDiscountPriceDomain> AeopSKUNationalDiscountPrice { get; set; }
	
	        /// <summary>
	        /// SKU属性信息
	        /// </summary>
	        [XmlArray("aeop_s_k_u_property")]
	        [XmlArrayItem("aeop_sku_property")]
	        public List<AeopSkuPropertyDomain> AeopSKUProperty { get; set; }
	
	        /// <summary>
	        /// 供应链条码，非供应链仓库发布不要填写
	        /// </summary>
	        [XmlElement("barcode")]
	        public string Barcode { get; set; }
	
	        /// <summary>
	        /// 产品货币单位。如果不提供该值信息，则默认为"USD"；非俄罗斯卖家这个属性值可以不提供。对于俄罗斯海外卖家，该单位值必须提供，如: "RUB"。
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
	
	        /// <summary>
	        /// SKU ID，格式：“sku_property_id:property_value_id”，
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// SKU实际可售库存属性ipmSkuStock，该属性值的合理取值范围为0~999999，如该商品有SKU时，请确保至少有一个SKU是有货状态，也就是ipmSkuStock取值是1~999999，在整个商品纬度库存值的取值范围是1~999999。 如果同时设置了skuStock属性，那么系统以ipmSkuStock属性为优先；如果没有设置ipmSkuStock属性，那么系统会根据skuStock属性进行设置库存，true表示999，false表示0。
	        /// </summary>
	        [XmlElement("ipm_sku_stock")]
	        public Nullable<long> IpmSkuStock { get; set; }
	
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
	        public Nullable<bool> SkuStock { get; set; }
}

	/// <summary>
/// AeopAeVideoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAeVideoDomain : TopObject
{
	        /// <summary>
	        /// 卖家主账户ID
	        /// </summary>
	        [XmlElement("ali_member_id")]
	        public Nullable<long> AliMemberId { get; set; }
	
	        /// <summary>
	        /// 视频ID
	        /// </summary>
	        [XmlElement("media_id")]
	        public Nullable<long> MediaId { get; set; }
	
	        /// <summary>
	        /// 视频的状态
	        /// </summary>
	        [XmlElement("media_status")]
	        public string MediaStatus { get; set; }
	
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
	        public Nullable<long> AttrNameId { get; set; }
	
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
	        /// 自定义属性值ID
	        /// </summary>
	        [XmlElement("attr_value_id")]
	        public Nullable<long> AttrValueId { get; set; }
	
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
/// AeopNationalQuoteConfigurationDomain Data Structure.
/// </summary>
[Serializable]

public class AeopNationalQuoteConfigurationDomain : TopObject
{
	        /// <summary>
	        /// jsonArray格式的分国家定价规则数据。 1)基于基准价格按比例配置的数据格式：[{"shiptoCountry":"US","percentage":"5"},{"shiptoCountry":"RU","percentage":"-2"}] 其中shiptoCountry：ISO两位的国家编码（目前支持11个国家：RU,US,CA,ES,FR,UK,NL,IL,BR,CL,AU）， percentage：相对于基准价的调价比例（百分比整数，支持负数，当前限制>=-30 && <=100）
	        /// </summary>
	        [XmlElement("configuration_data")]
	        public string ConfigurationData { get; set; }
	
	        /// <summary>
	        /// 分国家定价规则类型[percentage：基于基准价格按比例配置]
	        /// </summary>
	        [XmlElement("configuration_type")]
	        public string ConfigurationType { get; set; }
}

	/// <summary>
/// MultilanguageAeopAeProductDomain Data Structure.
/// </summary>
[Serializable]

public class MultilanguageAeopAeProductDomain : TopObject
{
	        /// <summary>
	        /// isPackSell为true时,此项必填。  每增加件数.取值范围1-1000。
	        /// </summary>
	        [XmlElement("add_unit")]
	        public Nullable<long> AddUnit { get; set; }
	
	        /// <summary>
	        /// isPackSell为true时,此项必填。  对应增加的重量.取值范围:0.001-500.000,保留三位小数,采用进位制,单位:公斤。
	        /// </summary>
	        [XmlElement("add_weight")]
	        public string AddWeight { get; set; }
	
	        /// <summary>
	        /// 商品多媒体信息，该属性主要包含商品的视频列表
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
	        /// 商品的SKU信息，列表类型，以json格式来表达。参看aeopAeProductSKUs数据结构。特别提示：新增SKU实际可售库存属性ipmSkuStock，该属性值的合理取值范围为0~999999，如该商品有SKU时，请确保至少有一个SKU是有货状态，也就是ipmSkuStock取值是1~999999，在整个商品纬度库存值的取值范围是1~999999。
	        /// </summary>
	        [XmlArray("aeop_ae_product_s_k_us")]
	        [XmlArrayItem("aeop_ae_product_sku")]
	        public List<AeopAeProductSkuDomain> AeopAeProductSKUs { get; set; }
	
	        /// <summary>
	        /// 商品分国家定价规则数据，建议使用新格式，请参考：https://developers.aliexpress.com/doc.htm?docId=109575&docType=1
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
	        /// 卡券商品结束有效期
	        /// </summary>
	        [XmlElement("coupon_end_date")]
	        public Nullable<DateTime> CouponEndDate { get; set; }
	
	        /// <summary>
	        /// 卡券商品开始有效期
	        /// </summary>
	        [XmlElement("coupon_start_date")]
	        public Nullable<DateTime> CouponStartDate { get; set; }
	
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
	        /// Detail详情。以下内容会被过滤，但不影响产品提交:(1)含有script\textarea\style\iframe\frame\input\pre\button均被过滤.(2)a标签href属性只允许是aliexpress.com域名连接,否则被过滤.(3)img标签src只允许alibaba.com或者aliimg.com域名链接.(4)任意具有style属性的html标签，其style受检查，只允许一般简单的样式.不允许的内容将被过滤.(5)如果发现html内容标签缺失，会自动补全标签.
	        /// </summary>
	        [XmlElement("detail")]
	        public string Detail { get; set; }
	
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
	        /// 是否是动态图产品，是：true，否：false
	        /// </summary>
	        [XmlElement("is_image_dynamic")]
	        public Nullable<bool> IsImageDynamic { get; set; }
	
	        /// <summary>
	        /// 是否自定义计重.true为自定义计重,false反之.
	        /// </summary>
	        [XmlElement("is_pack_sell")]
	        public Nullable<bool> IsPackSell { get; set; }
	
	        /// <summary>
	        /// 关键字
	        /// </summary>
	        [XmlElement("keyword")]
	        public string Keyword { get; set; }
	
	        /// <summary>
	        /// 多语言语种。当前支持的语种有：ru_RU(俄语)、pt_BR(葡萄牙语)、fr_FR(法语)、es_ES(西班牙语)、in_ID(印度尼西亚语)、it_IT(意大利语)、de_DE(德语)、nl_NL(荷兰语)、tr_TR(土耳其语)、iw_IL(以色列语)、ja_JP(日语)、ar_MA(阿拉伯语)、th_TH(泰语)、vi_VN(越南语)、ko_KR(韩语)、pl_PL(波兰语)
	        /// </summary>
	        [XmlElement("locale_name")]
	        public string LocaleName { get; set; }
	
	        /// <summary>
	        /// 每包件数。  打包销售情况，lotNum>1,非打包销售情况,lotNum=1
	        /// </summary>
	        [XmlElement("lot_num")]
	        public Nullable<long> LotNum { get; set; }
	
	        /// <summary>
	        /// mobile Detail详情，格式请参考https://developers.aliexpress.com/doc.htm#?docType=1&docId=108598。
	        /// </summary>
	        [XmlElement("mobile_detail")]
	        public string MobileDetail { get; set; }
	
	        /// <summary>
	        /// 多语言详描，长度不能超过90000个字符。
	        /// </summary>
	        [XmlElement("multilanguage_detail")]
	        public string MultilanguageDetail { get; set; }
	
	        /// <summary>
	        /// 多语言标题，长度不能超过218个字符。
	        /// </summary>
	        [XmlElement("multilanguage_subject")]
	        public string MultilanguageSubject { get; set; }
	
	        /// <summary>
	        /// 商品拥有者的login_id
	        /// </summary>
	        [XmlElement("owner_member_id")]
	        public string OwnerMemberId { get; set; }
	
	        /// <summary>
	        /// 商品拥有者的ID
	        /// </summary>
	        [XmlElement("owner_member_seq")]
	        public Nullable<long> OwnerMemberSeq { get; set; }
	
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
	        /// 产品ID
	        /// </summary>
	        [XmlElement("product_id")]
	        public Nullable<long> ProductId { get; set; }
	
	        /// <summary>
	        /// product_more_keywords1
	        /// </summary>
	        [XmlElement("product_more_keywords1")]
	        public string ProductMoreKeywords1 { get; set; }
	
	        /// <summary>
	        /// product_more_keywords2
	        /// </summary>
	        [XmlElement("product_more_keywords2")]
	        public string ProductMoreKeywords2 { get; set; }
	
	        /// <summary>
	        /// 商品一口价。取值范围:0-100000,保留两位小数;单位:美元。如:200.07，表示:200美元7分。需要在正确的价格区间内。上传多属性产品的时候，有好几个SKU和价格，productprice无需填写。
	        /// </summary>
	        [XmlElement("product_price")]
	        public string ProductPrice { get; set; }
	
	        /// <summary>
	        /// 产品的状态，包括onSelling（正在销售），offline（已下架），auditing（审核中），editingRequired（审核不通过）
	        /// </summary>
	        [XmlElement("product_status_type")]
	        public string ProductStatusType { get; set; }
	
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
	        /// 尺码表模版ID。必须选择当前类目下的尺码模版。可通过findaeproductbyid获取产品关联的尺码模板ID
	        /// </summary>
	        [XmlElement("sizechart_id")]
	        public Nullable<long> SizechartId { get; set; }
	
	        /// <summary>
	        /// 产品的来源
	        /// </summary>
	        [XmlElement("src")]
	        public string Src { get; set; }
	
	        /// <summary>
	        /// 商品标题  长度在1-128之间英文。
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
	
	        /// <summary>
	        /// 商品概要
	        /// </summary>
	        [XmlElement("summary")]
	        public string Summary { get; set; }
	
	        /// <summary>
	        /// 是否使用自动翻译，如果带上这个参数，则localeName必须为ru_RU，并且会自动把多语言标题和描述通过机器翻译自动翻译成英文，覆盖传人的英文描述和标题里面
	        /// </summary>
	        [XmlElement("use_auto_trans")]
	        public Nullable<bool> UseAutoTrans { get; set; }
	
	        /// <summary>
	        /// 产品的下架原因，包括user_offline：手动下架，expire_offline：到期下架，punish_offline：网规处罚下架，violate_offline：交易违规下架，degrade_offline：降级下架，industry_offline：未续约下架
	        /// </summary>
	        [XmlElement("ws_display")]
	        public string WsDisplay { get; set; }
	
	        /// <summary>
	        /// 产品的下架日期
	        /// </summary>
	        [XmlElement("ws_offline_date")]
	        public Nullable<DateTime> WsOfflineDate { get; set; }
	
	        /// <summary>
	        /// 商品有效天数。取值范围:1-30,单位:天。
	        /// </summary>
	        [XmlElement("ws_valid_num")]
	        public Nullable<long> WsValidNum { get; set; }
}

        #endregion
    }
}
