using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.issue.issuelist.get
    /// </summary>
    public class AliexpressIssueIssuelistGetRequest : BaseTopRequest<Top.Api.Response.AliexpressIssueIssuelistGetResponse>
    {
        /// <summary>
        /// 详情描述如下
        /// </summary>
        public string QueryDto { get; set; }

        public IssueApiListQueryDtoDomain QueryDto_ { set { this.QueryDto = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.issue.issuelist.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("query_dto", this.QueryDto);
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
/// IssueApiListQueryDtoDomain Data Structure.
/// </summary>
[Serializable]

public class IssueApiListQueryDtoDomain : TopObject
{
	        /// <summary>
	        /// 买家登录id
	        /// </summary>
	        [XmlElement("buyer_login_id")]
	        public string BuyerLoginId { get; set; }
	
	        /// <summary>
	        /// 当前页
	        /// </summary>
	        [XmlElement("current_page")]
	        public Nullable<long> CurrentPage { get; set; }
	
	        /// <summary>
	        /// 纠纷状态 处理中processing、 纠纷取消canceled_issue、纠纷完结,退款处理完成finish
	        /// </summary>
	        [XmlElement("issue_status")]
	        public string IssueStatus { get; set; }
	
	        /// <summary>
	        /// 订单号
	        /// </summary>
	        [XmlElement("order_no")]
	        public Nullable<long> OrderNo { get; set; }
	
	        /// <summary>
	        /// 每页大小，不要大于50.
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
}

        #endregion
    }
}
