using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressCategoryRedefiningGetallchildattributesresultResponse.
    /// </summary>
    public class AliexpressCategoryRedefiningGetallchildattributesresultResponse : TopResponse
    {
        /// <summary>
        /// 发布属性
        /// </summary>
        [XmlElement("result")]
        public AeopAttributeResponseDomain Result { get; set; }

	/// <summary>
/// AeopUnitDomain Data Structure.
/// </summary>
[Serializable]

public class AeopUnitDomain : TopObject
{
	        /// <summary>
	        /// 和标准属性对换比率
	        /// </summary>
	        [XmlElement("rate")]
	        public string Rate { get; set; }
	
	        /// <summary>
	        /// 单位名称
	        /// </summary>
	        [XmlElement("unit_name")]
	        public string UnitName { get; set; }
}

	/// <summary>
/// AeopAttrValueDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAttrValueDtoDomain : TopObject
{
	        /// <summary>
	        /// 下一层属性
	        /// </summary>
	        [XmlArray("attributes")]
	        [XmlArrayItem("json")]
	        public List<string> Attributes { get; set; }
	
	        /// <summary>
	        /// 属性值id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 属性值名称
	        /// </summary>
	        [XmlElement("names")]
	        public string Names { get; set; }
	
	        /// <summary>
	        /// valueTags
	        /// </summary>
	        [XmlElement("value_tags")]
	        public string ValueTags { get; set; }
}

	/// <summary>
/// AeopAttributeDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAttributeDtoDomain : TopObject
{
	        /// <summary>
	        /// 发布属性展现样式
	        /// </summary>
	        [XmlElement("attribute_show_type_value")]
	        public string AttributeShowTypeValue { get; set; }
	
	        /// <summary>
	        /// sku属性是否可自定义名称
	        /// </summary>
	        [XmlElement("customized_name")]
	        public bool CustomizedName { get; set; }
	
	        /// <summary>
	        /// sku属性是否可自定义图片
	        /// </summary>
	        [XmlElement("customized_pic")]
	        public bool CustomizedPic { get; set; }
	
	        /// <summary>
	        /// feature的map
	        /// </summary>
	        [XmlElement("features")]
	        public string Features { get; set; }
	
	        /// <summary>
	        /// 属性id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 文本输入框型属性输入格式（文本|数字）
	        /// </summary>
	        [XmlElement("input_type")]
	        public string InputType { get; set; }
	
	        /// <summary>
	        /// 发布属性是否关键
	        /// </summary>
	        [XmlElement("key_attribute")]
	        public bool KeyAttribute { get; set; }
	
	        /// <summary>
	        /// 属性名称
	        /// </summary>
	        [XmlElement("names")]
	        public string Names { get; set; }
	
	        /// <summary>
	        /// 发布属性是否必填
	        /// </summary>
	        [XmlElement("required")]
	        public bool Required { get; set; }
	
	        /// <summary>
	        /// 发布属性是否是sku
	        /// </summary>
	        [XmlElement("sku")]
	        public bool Sku { get; set; }
	
	        /// <summary>
	        /// sku属性展现样式（色卡|普通）
	        /// </summary>
	        [XmlElement("sku_style_value")]
	        public string SkuStyleValue { get; set; }
	
	        /// <summary>
	        /// sku维度（1维~6维）
	        /// </summary>
	        [XmlElement("spec")]
	        public long Spec { get; set; }
	
	        /// <summary>
	        /// 发布属性单位
	        /// </summary>
	        [XmlArray("units")]
	        [XmlArrayItem("aeop_unit")]
	        public List<AeopUnitDomain> Units { get; set; }
	
	        /// <summary>
	        /// 发布属性值
	        /// </summary>
	        [XmlArray("values")]
	        [XmlArrayItem("aeop_attr_value_dto")]
	        public List<AeopAttrValueDtoDomain> Values { get; set; }
	
	        /// <summary>
	        /// 属性是否可见
	        /// </summary>
	        [XmlElement("visible")]
	        public bool Visible { get; set; }
}

	/// <summary>
/// AeopAttributeResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAttributeResponseDomain : TopObject
{
	        /// <summary>
	        /// 发布属性list
	        /// </summary>
	        [XmlArray("attributes")]
	        [XmlArrayItem("aeop_attribute_dto")]
	        public List<AeopAttributeDtoDomain> Attributes { get; set; }
	
	        /// <summary>
	        /// errorCode
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// errorMessage
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 服务调用是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
