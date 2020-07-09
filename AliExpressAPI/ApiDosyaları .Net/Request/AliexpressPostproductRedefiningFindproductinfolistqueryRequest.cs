using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.findproductinfolistquery
    /// </summary>
    public class AliexpressPostproductRedefiningFindproductinfolistqueryRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningFindproductinfolistqueryResponse>
    {
        /// <summary>
        /// 商品列表查询
        /// </summary>
        public string AeopAEProductListQuery { get; set; }

        public AeopAeProductListQueryDomain AeopAEProductListQuery_ { set { this.AeopAEProductListQuery = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.findproductinfolistquery";
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
	        /// 被排除在外的商品id,查询结果不返回填入的产品，多个产品id以数组形式填入
	        /// </summary>
	        [XmlArray("excepted_product_ids")]
	        [XmlArrayItem("number")]
	        public List<string> ExceptedProductIds { get; set; }
	
	        /// <summary>
	        /// 创建时间结束于，yyyy-MM-dd hh:mm:ss
	        /// </summary>
	        [XmlElement("gmt_create_end")]
	        public Nullable<DateTime> GmtCreateEnd { get; set; }
	
	        /// <summary>
	        /// 创建时间开始于，yyyy-MM-dd hh:mm:ss
	        /// </summary>
	        [XmlElement("gmt_create_start")]
	        public Nullable<DateTime> GmtCreateStart { get; set; }
	
	        /// <summary>
	        /// 修改时间结束于，yyyy-MM-dd hh:mm:ss
	        /// </summary>
	        [XmlElement("gmt_modified_end")]
	        public Nullable<DateTime> GmtModifiedEnd { get; set; }
	
	        /// <summary>
	        /// 修改时间开始于，yyyy-MM-dd hh:mm:ss
	        /// </summary>
	        [XmlElement("gmt_modified_start")]
	        public Nullable<DateTime> GmtModifiedStart { get; set; }
	
	        /// <summary>
	        /// 商品分组搜索字段。输入商品分组id(groupId).
	        /// </summary>
	        [XmlElement("group_id")]
	        public Nullable<long> GroupId { get; set; }
	
	        /// <summary>
	        /// 是否有差异化报价: y有 n无
	        /// </summary>
	        [XmlElement("have_national_quote")]
	        public string HaveNationalQuote { get; set; }
	
	        /// <summary>
	        /// 商品的剩余有效期。如果想查3天之内即将下架的商品，则offLineTime值为3。
	        /// </summary>
	        [XmlElement("off_line_time")]
	        public Nullable<long> OffLineTime { get; set; }
	
	        /// <summary>
	        /// 商品所属人loginId
	        /// </summary>
	        [XmlElement("owner_member_id")]
	        public string OwnerMemberId { get; set; }
	
	        /// <summary>
	        /// 每页查询商品数量。输入值小于100，默认20。
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 商品id搜索字段。
	        /// </summary>
	        [XmlElement("product_id")]
	        public Nullable<long> ProductId { get; set; }
	
	        /// <summary>
	        /// 商品业务状态，目前提供5种，输入参数分别是：上架:onSelling ；下架:offline ；审核中:auditing ；审核不通过:editingRequired；客服删除:service_delete
	        /// </summary>
	        [XmlElement("product_status_type")]
	        public string ProductStatusType { get; set; }
	
	        /// <summary>
	        /// 商品标题模糊搜索字段。只支持半角英数字，长度不超过128。
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
	
	        /// <summary>
	        /// 商品下架原因：expire_offline(过期下架)，user_offline(用户手工下架)、violate_offline(违规下架)、punish_offline(处罚下架)、degrade_offline(降级下架)、industry_offline(行业准入未续约下架)
	        /// </summary>
	        [XmlElement("ws_display")]
	        public string WsDisplay { get; set; }
}

        #endregion
    }
}
