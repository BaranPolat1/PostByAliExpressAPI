using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.member.redefining.queryaccountlevel
    /// </summary>
    public class AliexpressMemberRedefiningQueryaccountlevelRequest : BaseTopRequest<Top.Api.Response.AliexpressMemberRedefiningQueryaccountlevelResponse>
    {
        /// <summary>
        /// 买家账号ID
        /// </summary>
        public string LoginId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.member.redefining.queryaccountlevel";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("login_id", this.LoginId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("login_id", this.LoginId);
        }

        #endregion
    }
}
