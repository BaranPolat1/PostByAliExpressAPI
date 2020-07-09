using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.issue.solution.agree
    /// </summary>
    public class AliexpressIssueSolutionAgreeRequest : BaseTopRequest<Top.Api.Response.AliexpressIssueSolutionAgreeResponse>
    {
        /// <summary>
        /// 买家登录id
        /// </summary>
        public string BuyerLoginId { get; set; }

        /// <summary>
        /// 纠纷id
        /// </summary>
        public Nullable<long> IssueId { get; set; }

        /// <summary>
        /// 若退货需提供退货地址id
        /// </summary>
        public Nullable<long> ReturnAddressId { get; set; }

        /// <summary>
        /// 同意方案id
        /// </summary>
        public Nullable<long> SolutionId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.issue.solution.agree";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_login_id", this.BuyerLoginId);
            parameters.Add("issue_id", this.IssueId);
            parameters.Add("return_address_id", this.ReturnAddressId);
            parameters.Add("solution_id", this.SolutionId);
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
            RequestValidator.ValidateRequired("solution_id", this.SolutionId);
        }

        #endregion
    }
}
