using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.editproductcategoryattributes
    /// </summary>
    public class AliexpressPostproductRedefiningEditproductcategoryattributesRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningEditproductcategoryattributesResponse>
    {
        /// <summary>
        /// 类目属性信息
        /// </summary>
        public string ProductCategoryAttributes { get; set; }

        public List<AeopAeProductPropertyDomain> ProductCategoryAttributes_ { set { this.ProductCategoryAttributes = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 产品的ID
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.editproductcategoryattributes";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("product_category_attributes", this.ProductCategoryAttributes);
            parameters.Add("product_id", this.ProductId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateObjectMaxListSize("product_category_attributes", this.ProductCategoryAttributes, 12000);
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
