using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.merchant.redefining.querylevelinfo
    /// </summary>
    public class AliexpressMerchantRedefiningQuerylevelinfoRequest : BaseTopRequest<Top.Api.Response.AliexpressMerchantRedefiningQuerylevelinfoResponse>
    {
        /// <summary>
        /// 卖家loginId，需要与授权用户相同
        /// </summary>
        public string Param1 { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.merchant.redefining.querylevelinfo";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param1", this.Param1);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("param1", this.Param1);
        }

        #endregion
    }
}
