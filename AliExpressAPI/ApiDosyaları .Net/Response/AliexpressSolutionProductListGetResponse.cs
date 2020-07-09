using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionProductListGetResponse.
    /// </summary>
    public class AliexpressSolutionProductListGetResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public ItemListResultDtoDomain Result { get; set; }

	/// <summary>
/// ItemDisplayDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ItemDisplayDtoDomain : TopObject
{
	        /// <summary>
	        /// Coupon end date, GMT+8
	        /// </summary>
	        [XmlElement("coupon_end_date")]
	        public string CouponEndDate { get; set; }
	
	        /// <summary>
	        /// Coupon start date, GMT+8
	        /// </summary>
	        [XmlElement("coupon_start_date")]
	        public string CouponStartDate { get; set; }
	
	        /// <summary>
	        /// currency code
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
	
	        /// <summary>
	        /// freight template id
	        /// </summary>
	        [XmlElement("freight_template_id")]
	        public long FreightTemplateId { get; set; }
	
	        /// <summary>
	        /// time that product was created
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// time that product was modifed
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// group id
	        /// </summary>
	        [XmlElement("group_id")]
	        public long GroupId { get; set; }
	
	        /// <summary>
	        /// product image urls
	        /// </summary>
	        [XmlElement("image_u_r_ls")]
	        public string ImageURLs { get; set; }
	
	        /// <summary>
	        /// seller login id
	        /// </summary>
	        [XmlElement("owner_member_id")]
	        public string OwnerMemberId { get; set; }
	
	        /// <summary>
	        /// seller member seq
	        /// </summary>
	        [XmlElement("owner_member_seq")]
	        public long OwnerMemberSeq { get; set; }
	
	        /// <summary>
	        /// product id
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
	
	        /// <summary>
	        /// max price among all skus of the product
	        /// </summary>
	        [XmlElement("product_max_price")]
	        public string ProductMaxPrice { get; set; }
	
	        /// <summary>
	        /// min price among all skus of the product
	        /// </summary>
	        [XmlElement("product_min_price")]
	        public string ProductMinPrice { get; set; }
	
	        /// <summary>
	        /// product src
	        /// </summary>
	        [XmlElement("src")]
	        public string Src { get; set; }
	
	        /// <summary>
	        /// product tite
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
	
	        /// <summary>
	        /// product offline reason
	        /// </summary>
	        [XmlElement("ws_display")]
	        public string WsDisplay { get; set; }
	
	        /// <summary>
	        /// product offline time
	        /// </summary>
	        [XmlElement("ws_offline_date")]
	        public string WsOfflineDate { get; set; }
}

	/// <summary>
/// ItemListResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ItemListResultDtoDomain : TopObject
{
	        /// <summary>
	        /// product list
	        /// </summary>
	        [XmlArray("aeop_a_e_product_display_d_t_o_list")]
	        [XmlArrayItem("item_display_dto")]
	        public List<ItemDisplayDtoDomain> AeopAEProductDisplayDTOList { get; set; }
	
	        /// <summary>
	        /// current page
	        /// </summary>
	        [XmlElement("current_page")]
	        public long CurrentPage { get; set; }
	
	        /// <summary>
	        /// error code
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// error message
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// error msg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// products total count
	        /// </summary>
	        [XmlElement("product_count")]
	        public long ProductCount { get; set; }
	
	        /// <summary>
	        /// success or not
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// total page
	        /// </summary>
	        [XmlElement("total_page")]
	        public long TotalPage { get; set; }
}

    }
}
