using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.product.post
    /// </summary>
    public class AliexpressSolutionProductPostRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionProductPostResponse>
    {
        /// <summary>
        /// input param
        /// </summary>
        public string PostProductRequest { get; set; }

        public PostProductRequestDtoDomain PostProductRequest_ { set { this.PostProductRequest = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.product.post";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("post_product_request", this.PostProductRequest);
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
/// SingleLanguageDescriptionDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SingleLanguageDescriptionDtoDomain : TopObject
{
	        /// <summary>
	        /// language for the module_list
	        /// </summary>
	        [XmlElement("language")]
	        public string Language { get; set; }
	
	        /// <summary>
	        /// mobile detail for this language, please check the format here https://developers.aliexpress.com/en/doc.htm?docId=109534&docType=1
	        /// </summary>
	        [XmlElement("mobile_detail")]
	        public string MobileDetail { get; set; }
	
	        /// <summary>
	        /// web detail for this language, please check the format here: https://developers.aliexpress.com/en/doc.htm?docId=109534&docType=1
	        /// </summary>
	        [XmlElement("web_detail")]
	        public string WebDetail { get; set; }
}

	/// <summary>
/// SingleLanguageTitleDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SingleLanguageTitleDtoDomain : TopObject
{
	        /// <summary>
	        /// language for the subject
	        /// </summary>
	        [XmlElement("language")]
	        public string Language { get; set; }
	
	        /// <summary>
	        /// product subject, maximum length 128 characters.
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
}

	/// <summary>
/// AttributeDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AttributeDtoDomain : TopObject
{
	        /// <summary>
	        /// aliexpress attribute name id, which could be obtained from aliexpress.solution.sku.attribute.query
	        /// </summary>
	        [XmlElement("aliexpress_attribute_name_id")]
	        public Nullable<long> AliexpressAttributeNameId { get; set; }
	
	        /// <summary>
	        /// aliexpress attribute value id, which could be obtained from aliexpress.solution.sku.attribute.query
	        /// </summary>
	        [XmlElement("aliexpress_attribute_value_id")]
	        public Nullable<long> AliexpressAttributeValueId { get; set; }
	
	        /// <summary>
	        /// merchant's attribute name
	        /// </summary>
	        [XmlElement("attribute_name")]
	        public string AttributeName { get; set; }
	
	        /// <summary>
	        /// merchant's attribute value
	        /// </summary>
	        [XmlElement("attribute_value")]
	        public string AttributeValue { get; set; }
}

	/// <summary>
/// SkuAttributeDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SkuAttributeDtoDomain : TopObject
{
	        /// <summary>
	        /// To obtain the available sku attribute names under a specific category, please check API: aliexpress.solution.sku.attribute.query.
	        /// </summary>
	        [XmlElement("sku_attribute_name")]
	        public string SkuAttributeName { get; set; }
	
	        /// <summary>
	        /// sku attribute value
	        /// </summary>
	        [XmlElement("sku_attribute_value")]
	        public string SkuAttributeValue { get; set; }
	
	        /// <summary>
	        /// The url needs to be accessible. The url could be located in the merchant's server or obtained by uploading the pictures to merchant's Aliexpress photobank, by using the API: aliexpress.photobank.redefining.uploadimageforsdk
	        /// </summary>
	        [XmlElement("sku_image_url")]
	        public string SkuImageUrl { get; set; }
}

	/// <summary>
/// SkuInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SkuInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// barcode of the sku. Except some Russian sellers who will be fulfilled by Aliexpress, please ignore this field for other sellers.
	        /// </summary>
	        [XmlElement("bar_code")]
	        public string BarCode { get; set; }
	
	        /// <summary>
	        /// discount price for the sku. discount_price should be cheaper than price.
	        /// </summary>
	        [XmlElement("discount_price")]
	        public string DiscountPrice { get; set; }
	
	        /// <summary>
	        /// inventory
	        /// </summary>
	        [XmlElement("inventory")]
	        public Nullable<long> Inventory { get; set; }
	
	        /// <summary>
	        /// price for the sku
	        /// </summary>
	        [XmlElement("price")]
	        public string Price { get; set; }
	
	        /// <summary>
	        /// sku attribute list. Some categories don't have sku attributes, then sku_attributes_list should be empty.
	        /// </summary>
	        [XmlArray("sku_attributes_list")]
	        [XmlArrayItem("sku_attribute_dto")]
	        public List<SkuAttributeDtoDomain> SkuAttributesList { get; set; }
	
	        /// <summary>
	        /// Code for merchant's sku, important reference to maintain the relationship between merchant and Aliexpress's system.
	        /// </summary>
	        [XmlElement("sku_code")]
	        public string SkuCode { get; set; }
}

	/// <summary>
/// SingleSkuPriceByCountryDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SingleSkuPriceByCountryDtoDomain : TopObject
{
	        /// <summary>
	        /// Value of discount_price for each country
	        /// </summary>
	        [XmlElement("discount_price")]
	        public string DiscountPrice { get; set; }
	
	        /// <summary>
	        /// Value of price configuration. If the price of a specific country is set, it must be greater than or equal to 70% of the original sku price
	        /// </summary>
	        [XmlElement("price")]
	        public string Price { get; set; }
	
	        /// <summary>
	        /// sku_code, the same as the sku_code in sku_info_list
	        /// </summary>
	        [XmlElement("sku_code")]
	        public string SkuCode { get; set; }
	
	        /// <summary>
	        /// Deprecated. Will be offline.
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// SingleCountryPriceDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SingleCountryPriceDtoDomain : TopObject
{
	        /// <summary>
	        /// Currently supporting RU US CA ES FR UK NL IL BR CL AU UA BY JP TH SG KR ID MY PH VN IT DE SA AE PL TR
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
	        /// Currently supporting only absolute. Please test carefully before uploading products.
	        /// </summary>
	        [XmlElement("price_type")]
	        public string PriceType { get; set; }
}

	/// <summary>
/// PostProductRequestDtoDomain Data Structure.
/// </summary>
[Serializable]

public class PostProductRequestDtoDomain : TopObject
{
	        /// <summary>
	        /// If the merchant/ISVs has done the category mapping by himself, this field should be filled with the aliexpress category id.
	        /// </summary>
	        [XmlElement("aliexpress_category_id")]
	        public Nullable<long> AliexpressCategoryId { get; set; }
	
	        /// <summary>
	        /// There are 4 types of how to fill in the content of each element in this attribute list. 1). When filling in the standard dropdown/multi-dropdown attributes, fill in "aliexpress_attribute_name_id" and "aliexpress_attribute_value_id"(For multi-dropdown, splitting them into multiple elements)  2). When filling in the attributes in which the value needs to be manually entered, fill in "aliexpress_attribute_name_id" and "attribute_value" in the element. 3). There exists a special kind of "aliexpress_attribute_value_id" of which the value represents for "Other". When encoutering this scenario, please fill in "aliexpress_attribute_name_id", "aliexpress_attribute_value_id" and "attribute_value". 4). Besides the three types mentioned above, if the seller would like to fully customized all the atttributes, fill in  "attribute name" and "attribute_value" in the element.
	        /// </summary>
	        [XmlArray("attribute_list")]
	        [XmlArrayItem("attribute_dto")]
	        public List<AttributeDtoDomain> AttributeList { get; set; }
	
	        /// <summary>
	        /// Brand name after applying in https://sellerjoin.aliexpress.com/oversea/getBrandList.htm. If the seller has not applied any brand permission, please leave this field blank.
	        /// </summary>
	        [XmlElement("brand_name")]
	        public string BrandName { get; set; }
	
	        /// <summary>
	        /// Deprecated. Please use aliexpress_category_id
	        /// </summary>
	        [XmlElement("category_id")]
	        public string CategoryId { get; set; }
	
	        /// <summary>
	        /// Deprecated, please use product description, support html format and multi languages. Check the field language to find the supported languages.
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// freight template ID. After the merchant has created an freight template in the backend: freighttemplate.aliexpress.com, the id could be obtained in the backend(freighttemplate.aliexpress.com) directly or thourgh the API: aliexpress.freight.redefining.listfreighttemplate
	        /// </summary>
	        [XmlElement("freight_template_id")]
	        public Nullable<long> FreightTemplateId { get; set; }
	
	        /// <summary>
	        /// group id, you can get group list from aliexpress.product.productgroups.get
	        /// </summary>
	        [XmlElement("group_id")]
	        public Nullable<long> GroupId { get; set; }
	
	        /// <summary>
	        /// indicate when the inventory of a specific product will be deducted. place_order_withhold: the inventory is deducted just after the order is placed by customer. payment_success_deduct: the stock is deducted after the payment is done successfully by the customer.
	        /// </summary>
	        [XmlElement("inventory_deduction_strategy")]
	        public string InventoryDeductionStrategy { get; set; }
	
	        /// <summary>
	        /// language for subject and description,currently support "es" and "ru"
	        /// </summary>
	        [XmlElement("language")]
	        public string Language { get; set; }
	
	        /// <summary>
	        /// Maximum 6 images. Main images to be displayed for the product. The urls needs to be accessible. The url could be in the merchant's server or obtained by uploading the pictures to merchant's Aliexpress photobank, by using the API: aliexpress.photobank.redefining.uploadimageforsdk
	        /// </summary>
	        [XmlArray("main_image_urls_list")]
	        [XmlArrayItem("string")]
	        public List<string> MainImageUrlsList { get; set; }
	
	        /// <summary>
	        /// multi country price configuration
	        /// </summary>
	        [XmlElement("multi_country_price_configuration")]
	        public MultiCountryPriceConfigurationDtoDomain MultiCountryPriceConfiguration { get; set; }
	
	        /// <summary>
	        /// Please refer to https://developers.aliexpress.com/en/doc.htm?docId=108976&docType=1
	        /// </summary>
	        [XmlArray("multi_language_description_list")]
	        [XmlArrayItem("single_language_description_dto")]
	        public List<SingleLanguageDescriptionDtoDomain> MultiLanguageDescriptionList { get; set; }
	
	        /// <summary>
	        /// Please refer to https://developers.aliexpress.com/en/doc.htm?docId=108976&docType=1
	        /// </summary>
	        [XmlArray("multi_language_subject_list")]
	        [XmlArrayItem("single_language_title_dto")]
	        public List<SingleLanguageTitleDtoDomain> MultiLanguageSubjectList { get; set; }
	
	        /// <summary>
	        /// product height in unit of "cm", maximum 700
	        /// </summary>
	        [XmlElement("package_height")]
	        public Nullable<long> PackageHeight { get; set; }
	
	        /// <summary>
	        /// product length in unit of "cm",  maximum 700
	        /// </summary>
	        [XmlElement("package_length")]
	        public Nullable<long> PackageLength { get; set; }
	
	        /// <summary>
	        /// product width in unit of "cm", maximum 700.
	        /// </summary>
	        [XmlElement("package_width")]
	        public Nullable<long> PackageWidth { get; set; }
	
	        /// <summary>
	        /// Product Unit ID, Most common-used ID: 100000015 piece/pieces; 100000000:bag/bags; 100000001:barrel/barrels; 100000002:bushel/bushels; 100078580:carton; 100078581:centimeter; 100000003:cubic meter; 100000004:dozen; 100078584:feet; 100000005:gallon; 100000006:gram; 100078587:inch; 100000007:kilogram; 100078589:kiloliter; 100000008:kilometer; 100078559:liter/liters; 100000009:long ton; 100000010:meter; 100000011:metric ton; 100078560:milligram; 100078596:milliliter; 100078597:millimeter; 100000012:ounce; 100000014:pack/packs; 100000013:pair; 100000016:pound; 100078603:quart; 100000017:set/sets; 100000018:short ton; 100078606:square feet; 100078607:square inch; 100000019:square meter; 100078609:square yard; 100000020:ton; 100078558:yard/yards
	        /// </summary>
	        [XmlElement("product_unit")]
	        public Nullable<long> ProductUnit { get; set; }
	
	        /// <summary>
	        /// service policy id, which could be set and obtained in the seller's background(https://cn.ae.aliexpress.com/sellerpromise/sellerPromiseHome.htm). If the merchant would like to use the default setting, pass "0" to this parameter.
	        /// </summary>
	        [XmlElement("service_policy_id")]
	        public Nullable<long> ServicePolicyId { get; set; }
	
	        /// <summary>
	        /// refer to the preparation period of merchant before the package could be dispatched to the customer.
	        /// </summary>
	        [XmlElement("shipping_lead_time")]
	        public Nullable<long> ShippingLeadTime { get; set; }
	
	        /// <summary>
	        /// merchant's size chart id, more used in the category of shoes and clothes.
	        /// </summary>
	        [XmlElement("size_chart_id")]
	        public Nullable<long> SizeChartId { get; set; }
	
	        /// <summary>
	        /// All the skus included in one product.
	        /// </summary>
	        [XmlArray("sku_info_list")]
	        [XmlArrayItem("sku_info_dto")]
	        public List<SkuInfoDtoDomain> SkuInfoList { get; set; }
	
	        /// <summary>
	        /// Deprecated. Please use  multi_language_subject_list. 1-128 length, support multi language. Check the field "language" to find the supported languages.
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
	
	        /// <summary>
	        /// weight for the product, including the package. Maximum 500
	        /// </summary>
	        [XmlElement("weight")]
	        public string Weight { get; set; }
}

        #endregion
    }
}
