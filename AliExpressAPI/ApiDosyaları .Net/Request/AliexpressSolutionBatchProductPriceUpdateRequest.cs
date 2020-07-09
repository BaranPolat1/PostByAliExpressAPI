using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.batch.product.price.update
    /// </summary>
    public class AliexpressSolutionBatchProductPriceUpdateRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionBatchProductPriceUpdateResponse>
    {
        /// <summary>
        /// The product list, in which the price needs to be updated. Maximum length:20
        /// </summary>
        public string MutipleProductUpdateList { get; set; }

        public List<SynchronizeProductRequestDtoDomain> MutipleProductUpdateList_ { set { this.MutipleProductUpdateList = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.batch.product.price.update";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("mutiple_product_update_list", this.MutipleProductUpdateList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("mutiple_product_update_list", this.MutipleProductUpdateList);
            RequestValidator.ValidateObjectMaxListSize("mutiple_product_update_list", this.MutipleProductUpdateList, 20);
        }

	/// <summary>
/// SynchronizeSkuRequestDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SynchronizeSkuRequestDtoDomain : TopObject
{
	        /// <summary>
	        /// discount_price of an sku. If not set, the discount_price will be erased.
	        /// </summary>
	        [XmlElement("discount_price")]
	        public string DiscountPrice { get; set; }
	
	        /// <summary>
	        /// price of an sku
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
	        /// Value of price configuration. If the price of a specific country is set, it must be greater than or equal to 70% of the original sku price in multiple_sku_update_list
	        /// </summary>
	        [XmlElement("price")]
	        public string Price { get; set; }
	
	        /// <summary>
	        /// sku_code, must existed in  multiple_sku_update_list
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
/// SynchronizeProductRequestDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SynchronizeProductRequestDtoDomain : TopObject
{
	        /// <summary>
	        /// multi country price configuration
	        /// </summary>
	        [XmlElement("multi_country_price_configuration")]
	        public MultiCountryPriceConfigurationDtoDomain MultiCountryPriceConfiguration { get; set; }
	
	        /// <summary>
	        /// The sku list, in which the inventory needs to be updated within the same product id
	        /// </summary>
	        [XmlArray("multiple_sku_update_list")]
	        [XmlArrayItem("synchronize_sku_request_dto")]
	        public List<SynchronizeSkuRequestDtoDomain> MultipleSkuUpdateList { get; set; }
	
	        /// <summary>
	        /// product id
	        /// </summary>
	        [XmlElement("product_id")]
	        public Nullable<long> ProductId { get; set; }
}

        #endregion
    }
}
