using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.batch.product.inventory.update
    /// </summary>
    public class AliexpressSolutionBatchProductInventoryUpdateRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionBatchProductInventoryUpdateResponse>
    {
        /// <summary>
        /// The product list, in which the inventory needs to be updated. Maximum 20 products.
        /// </summary>
        public string MutipleProductUpdateList { get; set; }

        public List<SynchronizeProductRequestDtoDomain> MutipleProductUpdateList_ { set { this.MutipleProductUpdateList = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.batch.product.inventory.update";
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
	        /// inventory
	        /// </summary>
	        [XmlElement("inventory")]
	        public Nullable<long> Inventory { get; set; }
	
	        /// <summary>
	        /// sku code
	        /// </summary>
	        [XmlElement("sku_code")]
	        public string SkuCode { get; set; }
}

	/// <summary>
/// SynchronizeProductRequestDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SynchronizeProductRequestDtoDomain : TopObject
{
	        /// <summary>
	        /// The sku list, in which the inventory needs to be updated within the same product id. Maximum 200 skus.
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
