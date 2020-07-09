using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.product.list.get
    /// </summary>
    public class AliexpressSolutionProductListGetRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionProductListGetResponse>
    {
        /// <summary>
        /// request parameters to query
        /// </summary>
        public string AeopAEProductListQuery { get; set; }

        public ItemListQueryDomain AeopAEProductListQuery_ { set { this.AeopAEProductListQuery = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.product.list.get";
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
/// ItemListQueryDomain Data Structure.
/// </summary>
[Serializable]

public class ItemListQueryDomain : TopObject
{
	        /// <summary>
	        /// Current page of products to be needed. The default page is page 1.
	        /// </summary>
	        [XmlElement("current_page")]
	        public Nullable<long> CurrentPage { get; set; }
	
	        /// <summary>
	        /// Product Ids which needs to be excluded
	        /// </summary>
	        [XmlArray("excepted_product_ids")]
	        [XmlArrayItem("number")]
	        public List<string> ExceptedProductIds { get; set; }
	
	        /// <summary>
	        /// Search for products created before a specific time，yyyy-MM-dd hh:mm:ss
	        /// </summary>
	        [XmlElement("gmt_create_end")]
	        public Nullable<DateTime> GmtCreateEnd { get; set; }
	
	        /// <summary>
	        /// Search for products created after a specific time, format: yyyy-MM-dd hh:mm:ss
	        /// </summary>
	        [XmlElement("gmt_create_start")]
	        public Nullable<DateTime> GmtCreateStart { get; set; }
	
	        /// <summary>
	        /// Search for products modified before a specific time，yyyy-MM-dd hh:mm:ss
	        /// </summary>
	        [XmlElement("gmt_modified_end")]
	        public Nullable<DateTime> GmtModifiedEnd { get; set; }
	
	        /// <summary>
	        /// Search for product modified after a specific time，yyyy-MM-dd hh:mm:ss
	        /// </summary>
	        [XmlElement("gmt_modified_start")]
	        public Nullable<DateTime> GmtModifiedStart { get; set; }
	
	        /// <summary>
	        /// Search field by product groups. Enter product group id (groupId).
	        /// </summary>
	        [XmlElement("group_id")]
	        public Nullable<long> GroupId { get; set; }
	
	        /// <summary>
	        /// Whether having national quotation. "y" for yes, "n" for no.
	        /// </summary>
	        [XmlElement("have_national_quote")]
	        public string HaveNationalQuote { get; set; }
	
	        /// <summary>
	        /// Search field by expiration date. For example, if the value for expiration date is 3, it means to query products to be offline within 3 days.
	        /// </summary>
	        [XmlElement("off_line_time")]
	        public Nullable<long> OffLineTime { get; set; }
	
	        /// <summary>
	        /// Login ID of product owner
	        /// </summary>
	        [XmlElement("owner_member_id")]
	        public string OwnerMemberId { get; set; }
	
	        /// <summary>
	        /// Number of products to be queried at each page. The input value must be less than 100, the default value of which is 20.
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// product id
	        /// </summary>
	        [XmlElement("product_id")]
	        public Nullable<long> ProductId { get; set; }
	
	        /// <summary>
	        /// onSelling Product operation status. Currently, it is divided into 4 types with the following input parameters respectively: onSelling; offline; auditing; and editingRequired.
	        /// </summary>
	        [XmlElement("product_status_type")]
	        public string ProductStatusType { get; set; }
	
	        /// <summary>
	        /// merchant sku code
	        /// </summary>
	        [XmlElement("sku_code")]
	        public string SkuCode { get; set; }
	
	        /// <summary>
	        /// Fuzzy search field by product subject. It only supports half-width numbers in English with a length not more than 128.
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
	
	        /// <summary>
	        /// Reasons for product offline: expire_offline; user_offline; violate_offline; punish_offline; and degrade_offline.
	        /// </summary>
	        [XmlElement("ws_display")]
	        public string WsDisplay { get; set; }
}

        #endregion
    }
}
