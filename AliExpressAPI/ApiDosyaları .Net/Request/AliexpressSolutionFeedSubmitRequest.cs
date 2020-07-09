using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.feed.submit
    /// </summary>
    public class AliexpressSolutionFeedSubmitRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionFeedSubmitResponse>
    {
        /// <summary>
        /// item list, maximum size: 2000.
        /// </summary>
        public string ItemList { get; set; }

        public List<SingleItemRequestDtoDomain> ItemList_ { set { this.ItemList = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// Currently support 4 types of feeds:PRODUCT_CREATE,PRODUCT_FULL_UPDATE,PRODUCT_STOCKS_UPDATE,PRODUCT_PRICES_UPDATE
        /// </summary>
        public string OperationType { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.feed.submit";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_list", this.ItemList);
            parameters.Add("operation_type", this.OperationType);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("item_list", this.ItemList);
            RequestValidator.ValidateObjectMaxListSize("item_list", this.ItemList, 2000);
            RequestValidator.ValidateRequired("operation_type", this.OperationType);
        }

	/// <summary>
/// SingleItemRequestDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SingleItemRequestDtoDomain : TopObject
{
	        /// <summary>
	        /// Content of each item, which follows different format according to different feed type.
	        /// </summary>
	        [XmlElement("item_content")]
	        public string ItemContent { get; set; }
	
	        /// <summary>
	        /// The id of the item_content, which could be defined by the seller. item_content_id should be unique among all the items in item_list.This field also appears in the API:aliexpress.solution.feed.query, which is regarding the convenience for the sellers to match the item_execuation_result with the item_content.
	        /// </summary>
	        [XmlElement("item_content_id")]
	        public string ItemContentId { get; set; }
}

        #endregion
    }
}
