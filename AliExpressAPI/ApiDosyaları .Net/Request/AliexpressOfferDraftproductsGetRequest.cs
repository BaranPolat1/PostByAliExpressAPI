using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.offer.draftproducts.get
    /// </summary>
    public class AliexpressOfferDraftproductsGetRequest : BaseTopRequest<Top.Api.Response.AliexpressOfferDraftproductsGetResponse>
    {
        /// <summary>
        /// none
        /// </summary>
        public string AeopAEProductListQuery { get; set; }

        public AeopAeProductListQueryDomain AeopAEProductListQuery_ { set { this.AeopAEProductListQuery = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.offer.draftproducts.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("aeop_a_e_product_list_query", this.AeopAEProductListQuery);
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
/// AeopAeProductListQueryDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAeProductListQueryDomain : TopObject
{
	        /// <summary>
	        /// 需要商品的当前页数。默认第一页。
	        /// </summary>
	        [XmlElement("current_page")]
	        public Nullable<long> CurrentPage { get; set; }
	
	        /// <summary>
	        /// 每页查询商品数量。输入值小于100，默认20。
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
}

        #endregion
    }
}
