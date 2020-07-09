using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressFreightRedefiningGetfreightsettingbytemplatequeryResponse.
    /// </summary>
    public class AliexpressFreightRedefiningGetfreightsettingbytemplatequeryResponse : TopResponse
    {
        /// <summary>
        /// errorDesc
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// freightSettingList
        /// </summary>
        [XmlArray("freight_setting_list")]
        [XmlArrayItem("aeop_freight_setting")]
        public List<AeopFreightSettingDomain> FreightSettingList { get; set; }

        /// <summary>
        /// isDefault
        /// </summary>
        [XmlElement("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// isSuccess
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 运费模板Id
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }

        /// <summary>
        /// templateName
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }

	/// <summary>
/// AeopFreightSelfdefineWeightDomain Data Structure.
/// </summary>
[Serializable]

public class AeopFreightSelfdefineWeightDomain : TopObject
{
	        /// <summary>
	        /// 重量区间结束
	        /// </summary>
	        [XmlElement("end_weight")]
	        public long EndWeight { get; set; }
	
	        /// <summary>
	        /// 区间内,单元重量运费
	        /// </summary>
	        [XmlElement("interval_unit_freight")]
	        public long IntervalUnitFreight { get; set; }
	
	        /// <summary>
	        /// 区间内,单位重量
	        /// </summary>
	        [XmlElement("interval_unit_weight")]
	        public long IntervalUnitWeight { get; set; }
	
	        /// <summary>
	        /// 重量区间起始
	        /// </summary>
	        [XmlElement("start_weight")]
	        public long StartWeight { get; set; }
}

	/// <summary>
/// AeopFreightSelfdefineDomain Data Structure.
/// </summary>
[Serializable]

public class AeopFreightSelfdefineDomain : TopObject
{
	        /// <summary>
	        /// 续增运费
	        /// </summary>
	        [XmlElement("add_freight")]
	        public long AddFreight { get; set; }
	
	        /// <summary>
	        /// 自定义的方式（按件/按重）
	        /// </summary>
	        [XmlElement("custom_freight_type")]
	        public string CustomFreightType { get; set; }
	
	        /// <summary>
	        /// 截至采购量
	        /// </summary>
	        [XmlElement("end_order_num")]
	        public long EndOrderNum { get; set; }
	
	        /// <summary>
	        /// 最低报价
	        /// </summary>
	        [XmlElement("min_freight")]
	        public long MinFreight { get; set; }
	
	        /// <summary>
	        /// 每增加定额产品采购量
	        /// </summary>
	        [XmlElement("per_add_num")]
	        public long PerAddNum { get; set; }
	
	        /// <summary>
	        /// 自定义按重内容
	        /// </summary>
	        [XmlArray("self_define_weight_list")]
	        [XmlArrayItem("aeop_freight_selfdefine_weight")]
	        public List<AeopFreightSelfdefineWeightDomain> SelfDefineWeightList { get; set; }
	
	        /// <summary>
	        /// 自定义运送国家
	        /// </summary>
	        [XmlElement("shipping_country")]
	        public string ShippingCountry { get; set; }
	
	        /// <summary>
	        /// 起始采购量
	        /// </summary>
	        [XmlElement("start_order_num")]
	        public long StartOrderNum { get; set; }
}

	/// <summary>
/// AeopFreightTemplateDomain Data Structure.
/// </summary>
[Serializable]

public class AeopFreightTemplateDomain : TopObject
{
	        /// <summary>
	        /// 是否全免费
	        /// </summary>
	        [XmlElement("all_free_shipping")]
	        public string AllFreeShipping { get; set; }
	
	        /// <summary>
	        /// 完全标准运费折扣
	        /// </summary>
	        [XmlElement("all_standard_discount")]
	        public long AllStandardDiscount { get; set; }
	
	        /// <summary>
	        /// 完全标准运费折扣
	        /// </summary>
	        [XmlElement("all_standard_shipping")]
	        public string AllStandardShipping { get; set; }
	
	        /// <summary>
	        /// 免运费国家
	        /// </summary>
	        [XmlElement("free_shipping_country")]
	        public string FreeShippingCountry { get; set; }
	
	        /// <summary>
	        /// 物流公司
	        /// </summary>
	        [XmlElement("logistics_company")]
	        public string LogisticsCompany { get; set; }
	
	        /// <summary>
	        /// 标准运费国家
	        /// </summary>
	        [XmlElement("standard_shipping_country")]
	        public string StandardShippingCountry { get; set; }
	
	        /// <summary>
	        /// 标准运费折扣
	        /// </summary>
	        [XmlElement("standard_shipping_discount")]
	        public long StandardShippingDiscount { get; set; }
}

	/// <summary>
/// AeopFreightSelfdefineStandardDomain Data Structure.
/// </summary>
[Serializable]

public class AeopFreightSelfdefineStandardDomain : TopObject
{
	        /// <summary>
	        /// 自定义运费国家
	        /// </summary>
	        [XmlElement("self_standard_country")]
	        public string SelfStandardCountry { get; set; }
	
	        /// <summary>
	        /// 自定义标准折扣
	        /// </summary>
	        [XmlElement("self_standard_discount")]
	        public long SelfStandardDiscount { get; set; }
}

	/// <summary>
/// AeopFreightSettingDomain Data Structure.
/// </summary>
[Serializable]

public class AeopFreightSettingDomain : TopObject
{
	        /// <summary>
	        /// 运费模板自定义按件或按重内容
	        /// </summary>
	        [XmlArray("selfdefine_list")]
	        [XmlArrayItem("aeop_freight_selfdefine")]
	        public List<AeopFreightSelfdefineDomain> SelfdefineList { get; set; }
	
	        /// <summary>
	        /// selfstandard
	        /// </summary>
	        [XmlArray("selfstandard_list")]
	        [XmlArrayItem("aeop_freight_selfdefine_standard")]
	        public List<AeopFreightSelfdefineStandardDomain> SelfstandardList { get; set; }
	
	        /// <summary>
	        /// 运费模板基础信息内容
	        /// </summary>
	        [XmlElement("template")]
	        public AeopFreightTemplateDomain Template { get; set; }
}

    }
}
