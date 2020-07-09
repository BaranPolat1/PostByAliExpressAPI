using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.freight.redefining.calculatefreight
    /// </summary>
    public class AliexpressFreightRedefiningCalculatefreightRequest : BaseTopRequest<Top.Api.Response.AliexpressFreightRedefiningCalculatefreightResponse>
    {
        /// <summary>
        /// count
        /// </summary>
        public Nullable<long> Count { get; set; }

        /// <summary>
        /// country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 运费模板ID
        /// </summary>
        public Nullable<long> FreightTemplateId { get; set; }

        /// <summary>
        /// package height
        /// </summary>
        public Nullable<long> Height { get; set; }

        /// <summary>
        /// 是否为自定义打包计重,Y/N
        /// </summary>
        public Nullable<bool> IsCustomPackWeight { get; set; }

        /// <summary>
        /// package length
        /// </summary>
        public Nullable<long> Length { get; set; }

        /// <summary>
        /// 打包计重超过部分每增加件数,当isCustomPackWeight=Y时必选
        /// </summary>
        public Nullable<long> PackAddUnit { get; set; }

        /// <summary>
        /// 打包计重超过部分续重,当isCustomPackWeight=Y时必选
        /// </summary>
        public Nullable<long> PackAddWeight { get; set; }

        /// <summary>
        /// 打包计重几件以内按单个产品计重,当isCustomPackWeight=Y时必选
        /// </summary>
        public Nullable<long> PackBaseUnit { get; set; }

        /// <summary>
        /// 产品价格
        /// </summary>
        public string ProductPrice { get; set; }

        public MoneyDomain ProductPrice_ { set { this.ProductPrice = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// package weight
        /// </summary>
        public Nullable<long> Weight { get; set; }

        /// <summary>
        /// package width
        /// </summary>
        public Nullable<long> Width { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.freight.redefining.calculatefreight";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("count", this.Count);
            parameters.Add("country", this.Country);
            parameters.Add("freight_template_id", this.FreightTemplateId);
            parameters.Add("height", this.Height);
            parameters.Add("is_custom_pack_weight", this.IsCustomPackWeight);
            parameters.Add("length", this.Length);
            parameters.Add("pack_add_unit", this.PackAddUnit);
            parameters.Add("pack_add_weight", this.PackAddWeight);
            parameters.Add("pack_base_unit", this.PackBaseUnit);
            parameters.Add("product_price", this.ProductPrice);
            parameters.Add("weight", this.Weight);
            parameters.Add("width", this.Width);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("count", this.Count);
            RequestValidator.ValidateRequired("country", this.Country);
            RequestValidator.ValidateRequired("freight_template_id", this.FreightTemplateId);
            RequestValidator.ValidateRequired("height", this.Height);
            RequestValidator.ValidateRequired("is_custom_pack_weight", this.IsCustomPackWeight);
            RequestValidator.ValidateRequired("length", this.Length);
            RequestValidator.ValidateRequired("weight", this.Weight);
            RequestValidator.ValidateRequired("width", this.Width);
        }

	/// <summary>
/// MoneyDomain Data Structure.
/// </summary>
[Serializable]

public class MoneyDomain : TopObject
{
	        /// <summary>
	        /// 元
	        /// </summary>
	        [XmlElement("amount")]
	        public string Amount { get; set; }
	
	        /// <summary>
	        /// 分
	        /// </summary>
	        [XmlElement("cent")]
	        public Nullable<long> Cent { get; set; }
	
	        /// <summary>
	        /// 币种
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
}

        #endregion
    }
}
