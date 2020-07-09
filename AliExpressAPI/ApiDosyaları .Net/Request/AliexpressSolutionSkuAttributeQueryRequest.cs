using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.sku.attribute.query
    /// </summary>
    public class AliexpressSolutionSkuAttributeQueryRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionSkuAttributeQueryResponse>
    {
        /// <summary>
        /// input parameters
        /// </summary>
        public string QuerySkuAttributeInfoRequest { get; set; }

        public SkuAttributeInfoQueryRequestDomain QuerySkuAttributeInfoRequest_ { set { this.QuerySkuAttributeInfoRequest = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.sku.attribute.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("query_sku_attribute_info_request", this.QuerySkuAttributeInfoRequest);
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
/// SkuAttributeInfoQueryRequestDomain Data Structure.
/// </summary>
[Serializable]

public class SkuAttributeInfoQueryRequestDomain : TopObject
{
	        /// <summary>
	        /// aliexpress category ID. aliexpress_category_id and category_id could not be both empty.
	        /// </summary>
	        [XmlElement("aliexpress_category_id")]
	        public Nullable<long> AliexpressCategoryId { get; set; }
	
	        /// <summary>
	        /// merchant's category ID
	        /// </summary>
	        [XmlElement("category_id")]
	        public string CategoryId { get; set; }
}

        #endregion
    }
}
