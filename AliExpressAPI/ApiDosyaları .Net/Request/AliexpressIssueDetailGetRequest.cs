using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.issue.detail.get
    /// </summary>
    public class AliexpressIssueDetailGetRequest : BaseTopRequest<Top.Api.Response.AliexpressIssueDetailGetResponse>
    {
        /// <summary>
        /// 买家登录帐号
        /// </summary>
        public string BuyerLoginId { get; set; }

        /// <summary>
        /// 纠纷id
        /// </summary>
        public Nullable<long> IssueId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.issue.detail.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_login_id", this.BuyerLoginId);
            parameters.Add("issue_id", this.IssueId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("buyer_login_id", this.BuyerLoginId);
            RequestValidator.ValidateRequired("issue_id", this.IssueId);
        }

        #endregion
    }
}
