using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionMerchantProfileGetResponse.
    /// </summary>
    public class AliexpressSolutionMerchantProfileGetResponse : TopResponse
    {
        /// <summary>
        /// country code which the merchant chose when registered
        /// </summary>
        [XmlElement("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// merchant login id of Aliexpress
        /// </summary>
        [XmlElement("merchant_login_id")]
        public string MerchantLoginId { get; set; }

        /// <summary>
        /// Indicate whether the mechant could post product or not. FALSE means the merchant could normally post product.
        /// </summary>
        [XmlElement("product_posting_forbidden")]
        public bool ProductPostingForbidden { get; set; }

        /// <summary>
        /// shop id
        /// </summary>
        [XmlElement("shop_id")]
        public long ShopId { get; set; }

        /// <summary>
        /// shop name
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// shop type
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// shop url
        /// </summary>
        [XmlElement("shop_url")]
        public string ShopUrl { get; set; }

    }
}
