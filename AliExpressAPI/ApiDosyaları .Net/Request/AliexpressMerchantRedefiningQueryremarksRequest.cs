using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.merchant.redefining.queryremarks
    /// </summary>
    public class AliexpressMerchantRedefiningQueryremarksRequest : BaseTopRequest<Top.Api.Response.AliexpressMerchantRedefiningQueryremarksResponse>
    {
        /// <summary>
        /// 业务类型，0 为订单备注。
        /// </summary>
        public Nullable<long> BizType { get; set; }

        /// <summary>
        /// 业务类型为订单备注，则remark_ids为订单ID列表。
        /// </summary>
        public string RemarkIds { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.merchant.redefining.queryremarks";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_type", this.BizType);
            parameters.Add("remark_ids", this.RemarkIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("remark_ids", this.RemarkIds, 100);
        }

        #endregion
    }
}
