using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionSkuAttributeQueryResponse.
    /// </summary>
    public class AliexpressSolutionSkuAttributeQueryResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public SkuAttributeInfoQueryResponseDomain Result { get; set; }

	/// <summary>
/// SkuValueSimplifiedInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SkuValueSimplifiedInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// aliexpress sku value name
	        /// </summary>
	        [XmlElement("aliexpress_sku_value_name")]
	        public string AliexpressSkuValueName { get; set; }
}

	/// <summary>
/// SupportedSkuAttributeDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SupportedSkuAttributeDtoDomain : TopObject
{
	        /// <summary>
	        /// aliexpress sku name, the same field when indicating the sku_name for posting product
	        /// </summary>
	        [XmlElement("aliexpress_sku_name")]
	        public string AliexpressSkuName { get; set; }
	
	        /// <summary>
	        /// aliexpress sku value list
	        /// </summary>
	        [XmlArray("aliexpress_sku_value_list")]
	        [XmlArrayItem("sku_value_simplified_info_dto")]
	        public List<SkuValueSimplifiedInfoDtoDomain> AliexpressSkuValueList { get; set; }
	
	        /// <summary>
	        /// Indicates whether this sku attribute is mandatory under this category
	        /// </summary>
	        [XmlElement("required")]
	        public bool Required { get; set; }
	
	        /// <summary>
	        /// whether the corresponding aliexpress_sku_name support customized name by merchants
	        /// </summary>
	        [XmlElement("support_customized_name")]
	        public bool SupportCustomizedName { get; set; }
	
	        /// <summary>
	        /// whether the corresponding aliexpress_sku_name support customized picture
	        /// </summary>
	        [XmlElement("support_customized_picture")]
	        public bool SupportCustomizedPicture { get; set; }
}

	/// <summary>
/// CommonAttributeValueInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class CommonAttributeValueInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// aliexpress common attribute value
	        /// </summary>
	        [XmlElement("aliexpress_common_attribute_value")]
	        public string AliexpressCommonAttributeValue { get; set; }
	
	        /// <summary>
	        /// aliexpress common attribute value id
	        /// </summary>
	        [XmlElement("aliexpress_common_attribute_value_id")]
	        public long AliexpressCommonAttributeValueId { get; set; }
}

	/// <summary>
/// SupportedCommonAttributeDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SupportedCommonAttributeDtoDomain : TopObject
{
	        /// <summary>
	        /// aliexpress common attribute name
	        /// </summary>
	        [XmlElement("aliexpress_common_attribute_name")]
	        public string AliexpressCommonAttributeName { get; set; }
	
	        /// <summary>
	        /// aliexpress common attribute name id
	        /// </summary>
	        [XmlElement("aliexpress_common_attribute_name_id")]
	        public long AliexpressCommonAttributeNameId { get; set; }
	
	        /// <summary>
	        /// aliexpress common attribute value list
	        /// </summary>
	        [XmlArray("aliexpress_common_attribute_value_list")]
	        [XmlArrayItem("common_attribute_value_info_dto")]
	        public List<CommonAttributeValueInfoDtoDomain> AliexpressCommonAttributeValueList { get; set; }
	
	        /// <summary>
	        /// whether the common attribute is required under this category
	        /// </summary>
	        [XmlElement("required")]
	        public bool Required { get; set; }
}

	/// <summary>
/// SkuAttributeInfoQueryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class SkuAttributeInfoQueryResponseDomain : TopObject
{
	        /// <summary>
	        /// common attributes under a specific category
	        /// </summary>
	        [XmlArray("supporting_common_attribute_list")]
	        [XmlArrayItem("supported_common_attribute_dto")]
	        public List<SupportedCommonAttributeDtoDomain> SupportingCommonAttributeList { get; set; }
	
	        /// <summary>
	        /// supported sku attribute lis
	        /// </summary>
	        [XmlArray("supporting_sku_attribute_list")]
	        [XmlArrayItem("supported_sku_attribute_dto")]
	        public List<SupportedSkuAttributeDtoDomain> SupportingSkuAttributeList { get; set; }
}

    }
}
