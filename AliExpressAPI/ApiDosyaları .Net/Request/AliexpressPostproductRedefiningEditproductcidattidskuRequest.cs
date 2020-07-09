using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.editproductcidattidsku
    /// </summary>
    public class AliexpressPostproductRedefiningEditproductcidattidskuRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningEditproductcidattidskuResponse>
    {
        /// <summary>
        /// 产品类目ID，如果不想调整类目，则不要填写。
        /// </summary>
        public Nullable<long> CategoryId { get; set; }

        /// <summary>
        /// 必填，商品id，一次只能上传一个
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// 该产品新的类目属性。如果没有指定categoryId, 则该类目属性则为当前产品所属类目下的类目属性，如果指定了categoryId, 则该类目属性则为新类目下的类目属性。
        /// </summary>
        public string ProductProperties { get; set; }

        public List<AeopAeProductPropertyDomain> ProductProperties_ { set { this.ProductProperties = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 该产品新的类目SKU属性。如果没有指定categoryId, 则该SKU属性则为当前产品所属类目下的SKU属性，如果指定了categoryId, 则该SKU属性则为新类目下的SKU属性。特别提示：新增SKU实际可售库存属性ipmSkuStock，该属性值的合理取值范围为0~999999，如该商品有SKU时，请确保至少有一个SKU是有货状态，也就是ipmSkuStock取值是1~999999，在整个商品纬度库存值的取值范围是1~999999。
        /// </summary>
        public string ProductSkus { get; set; }

        public List<AeopAeProductSkuDomain> ProductSkus_ { set { this.ProductSkus = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.editproductcidattidsku";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("category_id", this.CategoryId);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("product_properties", this.ProductProperties);
            parameters.Add("product_skus", this.ProductSkus);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateObjectMaxListSize("product_properties", this.ProductProperties, 12000);
            RequestValidator.ValidateObjectMaxListSize("product_skus", this.ProductSkus, 999);
        }

	/// <summary>
/// AeopSkuPropertyDomain Data Structure.
/// </summary>
[Serializable]

public class AeopSkuPropertyDomain : TopObject
{
	        /// <summary>
	        /// 属性值自定义名称，商品SKU属性值没有自定义名称时，该字段不填
	        /// </summary>
	        [XmlElement("property_value_definition_name")]
	        public string PropertyValueDefinitionName { get; set; }
	
	        /// <summary>
	        /// SKU属性值ID
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
	        [XmlArray("aeop_s_k_u_national_discount_price")]
	        [XmlArrayItem("aeop_sku_national_discount_price")]
	        public List<AeopSkuNationalDiscountPriceDomain> AeopSKUNationalDiscountPrice { get; set; }
	
	        /// <summary>
	        /// SKU属性
	        /// </summary>
	        [XmlArray("aeop_s_k_u_property")]
	        [XmlArrayItem("aeop_sku_property")]
	        public List<AeopSkuPropertyDomain> AeopSKUProperty { get; set; }
	
	        /// <summary>
	        /// 商品价格的货币单位。美元: USD, 卢布: RUB
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
	
	        /// <summary>
	        /// SKU id，格式：sku_property_id:sku_property_value_id,不需要变更类目不用传，自定义属性必传
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
	        /// 属性值ID
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

        #endregion
    }
}
