using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningFindproductinfolistqueryResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningFindproductinfolistqueryResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopFindProductListResultDtoDomain Result { get; set; }

	/// <summary>
/// AeopAeProductDisplaySampleDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAeProductDisplaySampleDtoDomain : TopObject
{
	        /// <summary>
	        /// couponEndDate
	        /// </summary>
	        [XmlElement("coupon_end_date")]
	        public string CouponEndDate { get; set; }
	
	        /// <summary>
	        /// couponStartDate
	        /// </summary>
	        [XmlElement("coupon_start_date")]
	        public string CouponStartDate { get; set; }
	
	        /// <summary>
	        /// 货币单位
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
	
	        /// <summary>
	        /// freightTemplateId
	        /// </summary>
	        [XmlElement("freight_template_id")]
	        public long FreightTemplateId { get; set; }
	
	        /// <summary>
	        /// 产品发布时间。
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 商品最后更新时间 （系统更新时间也会记录）。
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 商品分组id
	        /// </summary>
	        [XmlElement("group_id")]
	        public long GroupId { get; set; }
	
	        /// <summary>
	        /// 图片URL.静态单图主图个数为1,动态多图主图个数为2-6. 多个图片url用‘;’分隔符连接。
	        /// </summary>
	        [XmlElement("image_u_r_ls")]
	        public string ImageURLs { get; set; }
	
	        /// <summary>
	        /// 商品所属人loginId
	        /// </summary>
	        [XmlElement("owner_member_id")]
	        public string OwnerMemberId { get; set; }
	
	        /// <summary>
	        /// 商品所属人Seq
	        /// </summary>
	        [XmlElement("owner_member_seq")]
	        public long OwnerMemberSeq { get; set; }
	
	        /// <summary>
	        /// 商品ID
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
	
	        /// <summary>
	        /// 最大价格。
	        /// </summary>
	        [XmlElement("product_max_price")]
	        public string ProductMaxPrice { get; set; }
	
	        /// <summary>
	        /// 最小价格。
	        /// </summary>
	        [XmlElement("product_min_price")]
	        public string ProductMinPrice { get; set; }
	
	        /// <summary>
	        /// 产品来源。'tdx'为淘宝代销产品，isv为通过API发布的商品。其他字符或空为普通产品。
	        /// </summary>
	        [XmlElement("src")]
	        public string Src { get; set; }
	
	        /// <summary>
	        /// 商品标题
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
	
	        /// <summary>
	        /// 商品下架原因：expire_offline：过期下架，user_offline：用户下架,violate_offline：违规下架,punish_offline：交易违规下架，degrade_offline：降级下架
	        /// </summary>
	        [XmlElement("ws_display")]
	        public string WsDisplay { get; set; }
	
	        /// <summary>
	        /// 下架时间
	        /// </summary>
	        [XmlElement("ws_offline_date")]
	        public string WsOfflineDate { get; set; }
}

	/// <summary>
/// AeopFindProductListResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopFindProductListResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 商品基本信息列表
	        /// </summary>
	        [XmlArray("aeop_a_e_product_display_d_t_o_list")]
	        [XmlArrayItem("aeop_ae_product_display_sample_dto")]
	        public List<AeopAeProductDisplaySampleDtoDomain> AeopAEProductDisplayDTOList { get; set; }
	
	        /// <summary>
	        /// 当前页
	        /// </summary>
	        [XmlElement("current_page")]
	        public long CurrentPage { get; set; }
	
	        /// <summary>
	        /// 错误代码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 总商品数
	        /// </summary>
	        [XmlElement("product_count")]
	        public long ProductCount { get; set; }
	
	        /// <summary>
	        /// 接口调用结果
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// 总页数
	        /// </summary>
	        [XmlElement("total_page")]
	        public long TotalPage { get; set; }
}

    }
}
