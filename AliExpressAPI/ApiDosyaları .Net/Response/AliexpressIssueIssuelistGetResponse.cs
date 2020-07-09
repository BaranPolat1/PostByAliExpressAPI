using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressIssueIssuelistGetResponse.
    /// </summary>
    public class AliexpressIssueIssuelistGetResponse : TopResponse
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// dataList
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("issue_api_issue_dto")]
        public List<IssueApiIssueDtoDomain> DataList { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }

	/// <summary>
/// IssueApiIssueDtoDomain Data Structure.
/// </summary>
[Serializable]

public class IssueApiIssueDtoDomain : TopObject
{
	        /// <summary>
	        /// 买家登录id
	        /// </summary>
	        [XmlElement("buyer_login_id")]
	        public string BuyerLoginId { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 最后修改时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 纠纷id
	        /// </summary>
	        [XmlElement("issue_id")]
	        public long IssueId { get; set; }
	
	        /// <summary>
	        /// 纠纷状态 处理中 processing、 纠纷取消canceled_issue、纠纷完结,退款处理完成finish
	        /// </summary>
	        [XmlElement("issue_status")]
	        public string IssueStatus { get; set; }
	
	        /// <summary>
	        /// 订单id
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// 子订单id
	        /// </summary>
	        [XmlElement("parent_order_id")]
	        public long ParentOrderId { get; set; }
	
	        /// <summary>
	        /// 纠纷原因中文
	        /// </summary>
	        [XmlElement("reason_chinese")]
	        public string ReasonChinese { get; set; }
	
	        /// <summary>
	        /// 纠纷原因英文
	        /// </summary>
	        [XmlElement("reason_english")]
	        public string ReasonEnglish { get; set; }
}

    }
}
