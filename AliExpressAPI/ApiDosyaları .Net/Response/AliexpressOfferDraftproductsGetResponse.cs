using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressOfferDraftproductsGetResponse.
    /// </summary>
    public class AliexpressOfferDraftproductsGetResponse : TopResponse
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
	        /// 卡券商品结束有效期
	        /// </summary>
	        [XmlElement("coupon_end_date")]
	        public string CouponEndDate { get; set; }
	
	        /// <summary>
	        /// 卡券商品开始有效期
	        /// </summary>
	        [XmlElement("coupon_start_date")]
	        public string CouponStartDate { get; set; }
	
	        /// <summary>
	        /// 货币单位
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
	
	        /// <summary>
	        /// 产品关联的运费模版ID
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
	        /// 产品来源。'tdx'为淘宝代销产品，'1688'为1688分销商品，'isv'为通过API发布的商品。其他字符或空为普通产品。
	        /// </summary>
	        [XmlElement("src")]
	        public string Src { get; set; }
	
	        /// <summary>
	        /// 产品来源的详情地址，目前仅支持1688
	        /// </summary>
	        [XmlElement("src_detail_url")]
	        public string SrcDetailUrl { get; set; }
	
	        /// <summary>
	        /// 商品标题
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
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
	        /// 总商品数
	        /// </summary>
	        [XmlElement("product_count")]
	        public long ProductCount { get; set; }
	
	        /// <summary>
	        /// 总页数
	        /// </summary>
	        [XmlElement("total_page")]
	        public long TotalPage { get; set; }
}

    }
}
