using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionProductInfoGetResponse.
    /// </summary>
    public class AliexpressSolutionProductInfoGetResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public GlobalAeopFindProductResultDtoDomain Result { get; set; }

	/// <summary>
/// GlobalAeopAeVideoDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopAeVideoDomain : TopObject
{
	        /// <summary>
	        /// Seller admin ID
	        /// </summary>
	        [XmlElement("ali_member_id")]
	        public long AliMemberId { get; set; }
	
	        /// <summary>
	        /// Video ID
	        /// </summary>
	        [XmlElement("media_id")]
	        public long MediaId { get; set; }
	
	        /// <summary>
	        /// The status of the video
	        /// </summary>
	        [XmlElement("media_status")]
	        public string MediaStatus { get; set; }
	
	        /// <summary>
	        /// The type of video
	        /// </summary>
	        [XmlElement("media_type")]
	        public string MediaType { get; set; }
	
	        /// <summary>
	        /// URL of the video cover image
	        /// </summary>
	        [XmlElement("poster_url")]
	        public string PosterUrl { get; set; }
}

	/// <summary>
/// GlobalAeopAeMultimediaDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopAeMultimediaDomain : TopObject
{
	        /// <summary>
	        /// video information
	        /// </summary>
	        [XmlArray("aeop_a_e_videos")]
	        [XmlArrayItem("global_aeop_ae_video")]
	        public List<GlobalAeopAeVideoDomain> AeopAEVideos { get; set; }
}

	/// <summary>
/// GlobalAeopAeProductPropertyDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopAeProductPropertyDomain : TopObject
{
	        /// <summary>
	        /// Customized attribute name
	        /// </summary>
	        [XmlElement("attr_name")]
	        public string AttrName { get; set; }
	
	        /// <summary>
	        /// Attribute Name ID
	        /// </summary>
	        [XmlElement("attr_name_id")]
	        public long AttrNameId { get; set; }
	
	        /// <summary>
	        /// Customized attribute value
	        /// </summary>
	        [XmlElement("attr_value")]
	        public string AttrValue { get; set; }
	
	        /// <summary>
	        /// Attribute Value ID
	        /// </summary>
	        [XmlElement("attr_value_id")]
	        public long AttrValueId { get; set; }
	
	        /// <summary>
	        /// unit of customized attribute value
	        /// </summary>
	        [XmlElement("attr_value_unit")]
	        public string AttrValueUnit { get; set; }
}

	/// <summary>
/// GlobalAeopSkuPropertyDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopSkuPropertyDomain : TopObject
{
	        /// <summary>
	        /// Customized attribute value name
	        /// </summary>
	        [XmlElement("property_value_definition_name")]
	        public string PropertyValueDefinitionName { get; set; }
	
	        /// <summary>
	        /// SKU attribute value id
	        /// </summary>
	        [XmlElement("property_value_id")]
	        public long PropertyValueId { get; set; }
	
	        /// <summary>
	        /// Self-defined image url for this sku.
	        /// </summary>
	        [XmlElement("sku_image")]
	        public string SkuImage { get; set; }
	
	        /// <summary>
	        /// SKU attribute name id
	        /// </summary>
	        [XmlElement("sku_property_id")]
	        public long SkuPropertyId { get; set; }
}

	/// <summary>
/// GlobalAeopAeProductSkuDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopAeProductSkuDomain : TopObject
{
	        /// <summary>
	        /// List of SKU attributes
	        /// </summary>
	        [XmlArray("aeop_s_k_u_property_list")]
	        [XmlArrayItem("global_aeop_sku_property")]
	        public List<GlobalAeopSkuPropertyDomain> AeopSKUPropertyList { get; set; }
	
	        /// <summary>
	        /// all of warehouse goods will return barcode
	        /// </summary>
	        [XmlElement("barcode")]
	        public string Barcode { get; set; }
	
	        /// <summary>
	        /// The Currency code. "USD" will be used as the default value if this information is not provided; Currency code is mandatory for Russian sellers(RUB) and Spanish sellers(EUR).
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
	
	        /// <summary>
	        /// SKU ID. Can uniquely represent a SKU within a product range.
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// Ranges from 1 to 999999 for one sku. The total stock of the entire product within multiple skus should also be in the range of 1 to 999999.
	        /// </summary>
	        [XmlElement("ipm_sku_stock")]
	        public long IpmSkuStock { get; set; }
	
	        /// <summary>
	        /// Sku merchant code from the seller's system. Format: alphanumeric, length 20, does not contain spaces greater than and less than sign. If you only fill in the product price and product code, you need to create a complete SKU record submission, otherwise the product code can not be saved. The system will consider that only the retail price is submitted, but no SKU, resulting in product editing is not saved.
	        /// </summary>
	        [XmlElement("sku_code")]
	        public string SkuCode { get; set; }
	
	        /// <summary>
	        /// SKU discount price, also called sale price, value range: 0.01 - 100000.
	        /// </summary>
	        [XmlElement("sku_discount_price")]
	        public string SkuDiscountPrice { get; set; }
	
	        /// <summary>
	        /// Sku price. Value range: 0.01-100000; Such as: 200.07 means 200 US dollars 7 cents(if other currency_code is used, referring to the corresponding price in that currency, e.g., 200.07 Euros).
	        /// </summary>
	        [XmlElement("sku_price")]
	        public string SkuPrice { get; set; }
	
	        /// <summary>
	        /// True means stock available for the sku, false means out of stock. The stock of at least one should be available.
	        /// </summary>
	        [XmlElement("sku_stock")]
	        public bool SkuStock { get; set; }
}

	/// <summary>
/// GlobalSubjectDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalSubjectDomain : TopObject
{
	        /// <summary>
	        /// locale of the subject
	        /// </summary>
	        [XmlElement("locale")]
	        public string Locale { get; set; }
	
	        /// <summary>
	        /// subject
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
}

	/// <summary>
/// GlobalDescriptionDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalDescriptionDomain : TopObject
{
	        /// <summary>
	        /// locale of the descripiton
	        /// </summary>
	        [XmlElement("locale")]
	        public string Locale { get; set; }
	
	        /// <summary>
	        /// mobile detail
	        /// </summary>
	        [XmlElement("mobile_detail")]
	        public string MobileDetail { get; set; }
	
	        /// <summary>
	        /// web detail
	        /// </summary>
	        [XmlElement("web_detail")]
	        public string WebDetail { get; set; }
}

	/// <summary>
/// SingleSkuPriceByCountryDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SingleSkuPriceByCountryDtoDomain : TopObject
{
	        /// <summary>
	        /// discount price
	        /// </summary>
	        [XmlElement("discount_price")]
	        public string DiscountPrice { get; set; }
	
	        /// <summary>
	        /// price
	        /// </summary>
	        [XmlElement("price")]
	        public string Price { get; set; }
	
	        /// <summary>
	        /// sku code
	        /// </summary>
	        [XmlElement("sku_code")]
	        public string SkuCode { get; set; }
}

	/// <summary>
/// SingleCountryPriceDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SingleCountryPriceDtoDomain : TopObject
{
	        /// <summary>
	        /// ship to country
	        /// </summary>
	        [XmlElement("ship_to_country")]
	        public string ShipToCountry { get; set; }
	
	        /// <summary>
	        /// Sku price list under the same ship_to_country
	        /// </summary>
	        [XmlArray("sku_price_by_country_list")]
	        [XmlArrayItem("single_sku_price_by_country_dto")]
	        public List<SingleSkuPriceByCountryDtoDomain> SkuPriceByCountryList { get; set; }
}

	/// <summary>
/// MultiCountryPriceConfigurationDtoDomain Data Structure.
/// </summary>
[Serializable]

public class MultiCountryPriceConfigurationDtoDomain : TopObject
{
	        /// <summary>
	        /// Price list for different countries
	        /// </summary>
	        [XmlArray("country_price_list")]
	        [XmlArrayItem("single_country_price_dto")]
	        public List<SingleCountryPriceDtoDomain> CountryPriceList { get; set; }
	
	        /// <summary>
	        /// price type
	        /// </summary>
	        [XmlElement("price_type")]
	        public string PriceType { get; set; }
}

	/// <summary>
/// GlobalAeopFindProductResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class GlobalAeopFindProductResultDtoDomain : TopObject
{
	        /// <summary>
	        /// Required when is_pack_sell equals to true. Value range for pieces to be added: 1-1000. Please refer to the field is_pack_sell for details.
	        /// </summary>
	        [XmlElement("add_unit")]
	        public long AddUnit { get; set; }
	
	        /// <summary>
	        /// Required when is_pack_sell equals to true. It means weight to be correspondingly added. Range value: 0.001-500.000, reserving three decimal places and applying scale; Unit: kilogram(s). Please refer to the field is_pack_sell for details.
	        /// </summary>
	        [XmlElement("add_weight")]
	        public string AddWeight { get; set; }
	
	        /// <summary>
	        /// Multimedia information
	        /// </summary>
	        [XmlElement("aeop_a_e_multimedia")]
	        public GlobalAeopAeMultimediaDomain AeopAEMultimedia { get; set; }
	
	        /// <summary>
	        /// Product properties
	        /// </summary>
	        [XmlArray("aeop_ae_product_propertys")]
	        [XmlArrayItem("global_aeop_ae_product_property")]
	        public List<GlobalAeopAeProductPropertyDomain> AeopAeProductPropertys { get; set; }
	
	        /// <summary>
	        /// List for multiple skus of the product, expressed in json format.
	        /// </summary>
	        [XmlArray("aeop_ae_product_s_k_us")]
	        [XmlArrayItem("global_aeop_ae_product_sku")]
	        public List<GlobalAeopAeProductSkuDomain> AeopAeProductSKUs { get; set; }
	
	        /// <summary>
	        /// Required when is_pack_sell equals to true. It means no additional freight will be charged when the number of pieces to be purchased is under the base unit. Value range: 1-1000.
	        /// </summary>
	        [XmlElement("base_unit")]
	        public long BaseUnit { get; set; }
	
	        /// <summary>
	        /// Bulk discount for wholesale. It must be multiplied by 100 and selected and saved as integer. Value range: 1-99. Note: It is discount, other than discount rate. For example, if the discount is 68, it should be selected and saved as 32. bulk_order and bulk_discount must have value or have no value simultaneously.
	        /// </summary>
	        [XmlElement("bulk_discount")]
	        public long BulkDiscount { get; set; }
	
	        /// <summary>
	        /// Minimum bulk for wholesale. Value range: 2-100000. bulk_order and bulk_discount must have value or have no value simultaneously.
	        /// </summary>
	        [XmlElement("bulk_order")]
	        public long BulkOrder { get; set; }
	
	        /// <summary>
	        /// Product category ID. It must be leaf category to be obtained from the category interface.
	        /// </summary>
	        [XmlElement("category_id")]
	        public long CategoryId { get; set; }
	
	        /// <summary>
	        /// the Currency code. "USD" will be used as the default value if this information is not provided; Currency code is mandatory for Russian sellers and Spanish sellers. For Russian sellers, RUB should be filled in while EUR for Spanish sellers.
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
	
	        /// <summary>
	        /// Stocking period. Value range: 1-60; Unit: day(s). Referring to the preparation time before the order could be dispatched.
	        /// </summary>
	        [XmlElement("delivery_time")]
	        public long DeliveryTime { get; set; }
	
	        /// <summary>
	        /// Deprecated, please use multi_language_description_list
	        /// </summary>
	        [XmlElement("detail")]
	        public string Detail { get; set; }
	
	        /// <summary>
	        /// shipping template id
	        /// </summary>
	        [XmlElement("freight_template_id")]
	        public long FreightTemplateId { get; set; }
	
	        /// <summary>
	        /// created time
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// modified time
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// Product gross weight. Range value: 0.001-500.000, reserving three decimal places and applying scale; Unit: kilogram(s).
	        /// </summary>
	        [XmlElement("gross_weight")]
	        public string GrossWeight { get; set; }
	
	        /// <summary>
	        /// Group ID that the product belongs to.
	        /// </summary>
	        [XmlElement("group_id")]
	        public long GroupId { get; set; }
	
	        /// <summary>
	        /// All the groups that the product belongs to.
	        /// </summary>
	        [XmlArray("group_ids")]
	        [XmlArrayItem("number")]
	        public List<long> GroupIds { get; set; }
	
	        /// <summary>
	        /// image urls for the product
	        /// </summary>
	        [XmlElement("image_u_r_ls")]
	        public string ImageURLs { get; set; }
	
	        /// <summary>
	        /// Whether customized weighting is enabled or not. True means customized weighting enabled. When is_pack_sell equals to true, add_unit, add_weight and base_unit must be filled in. For example, base_unit equals to 5, add_unit equals to 2 and add_weight equals to 1.2. It means that Basic shipping cost will cover the first 5 pieces, freight calculating of which will base on a single product. For every additional 2 pieces, the shipping cost will be added to the total shipping cost for 1.2kg
	        /// </summary>
	        [XmlElement("is_pack_sell")]
	        public bool IsPackSell { get; set; }
	
	        /// <summary>
	        /// Number of piece(s) in each pack. In case of packing sale,lotNum>1, and in case of unpacking sale, lotNum=1.
	        /// </summary>
	        [XmlElement("lot_num")]
	        public long LotNum { get; set; }
	
	        /// <summary>
	        /// mobile detail
	        /// </summary>
	        [XmlElement("mobile_detail")]
	        public string MobileDetail { get; set; }
	
	        /// <summary>
	        /// multi country price configuration
	        /// </summary>
	        [XmlElement("multi_country_price_configuration")]
	        public MultiCountryPriceConfigurationDtoDomain MultiCountryPriceConfiguration { get; set; }
	
	        /// <summary>
	        /// multo language description list
	        /// </summary>
	        [XmlArray("multi_language_description_list")]
	        [XmlArrayItem("global_description")]
	        public List<GlobalDescriptionDomain> MultiLanguageDescriptionList { get; set; }
	
	        /// <summary>
	        /// multi language subject list
	        /// </summary>
	        [XmlArray("multi_language_subject_list")]
	        [XmlArrayItem("global_subject")]
	        public List<GlobalSubjectDomain> MultiLanguageSubjectList { get; set; }
	
	        /// <summary>
	        /// Out of date, please ignore
	        /// </summary>
	        [XmlElement("owner_member_id")]
	        public string OwnerMemberId { get; set; }
	
	        /// <summary>
	        /// Out of date, please ignore.
	        /// </summary>
	        [XmlElement("owner_member_seq")]
	        public long OwnerMemberSeq { get; set; }
	
	        /// <summary>
	        /// package height
	        /// </summary>
	        [XmlElement("package_height")]
	        public long PackageHeight { get; set; }
	
	        /// <summary>
	        /// package length
	        /// </summary>
	        [XmlElement("package_length")]
	        public long PackageLength { get; set; }
	
	        /// <summary>
	        /// Packing sale: true; Unpacking sale: false.
	        /// </summary>
	        [XmlElement("package_type")]
	        public bool PackageType { get; set; }
	
	        /// <summary>
	        /// package width
	        /// </summary>
	        [XmlElement("package_width")]
	        public long PackageWidth { get; set; }
	
	        /// <summary>
	        /// product ID
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
	
	        /// <summary>
	        /// Price for product
	        /// </summary>
	        [XmlElement("product_price")]
	        public string ProductPrice { get; set; }
	
	        /// <summary>
	        /// product status type
	        /// </summary>
	        [XmlElement("product_status_type")]
	        public string ProductStatusType { get; set; }
	
	        /// <summary>
	        /// Product unit
	        /// </summary>
	        [XmlElement("product_unit")]
	        public long ProductUnit { get; set; }
	
	        /// <summary>
	        /// Service template ID which the product is associated with
	        /// </summary>
	        [XmlElement("promise_template_id")]
	        public long PromiseTemplateId { get; set; }
	
	        /// <summary>
	        /// Stock reduction strategy. It is divided into 2 types: stock reduction after placing order (place_order_withhold) or stock reduction after payment (payment_success_deduct).
	        /// </summary>
	        [XmlElement("reduce_strategy")]
	        public string ReduceStrategy { get; set; }
	
	        /// <summary>
	        /// Size chart template ID that the product is associated with.
	        /// </summary>
	        [XmlElement("sizechart_id")]
	        public long SizechartId { get; set; }
	
	        /// <summary>
	        /// Deprecated, please use multi_language_subject_list
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
	
	        /// <summary>
	        /// The offline date of the product
	        /// </summary>
	        [XmlElement("ws_offline_date")]
	        public string WsOfflineDate { get; set; }
}

    }
}
