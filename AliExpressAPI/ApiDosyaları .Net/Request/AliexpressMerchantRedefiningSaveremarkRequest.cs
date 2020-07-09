using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.merchant.redefining.saveremark
    /// </summary>
    public class AliexpressMerchantRedefiningSaveremarkRequest : BaseTopRequest<Top.Api.Response.AliexpressMerchantRedefiningSaveremarkResponse>
    {
        /// <summary>
        /// 业务类型，默认为订单备注
        /// </summary>
        public Nullable<long> BizType { get; set; }

        /// <summary>
        /// 备注内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 备注Id
        /// </summary>
        public Nullable<long> RemarkId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.merchant.redefining.saveremark";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_type", this.BizType);
            parameters.Add("content", this.Content);
            parameters.Add("remark_id", this.RemarkId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
