using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.merchant.redefining.queryremark
    /// </summary>
    public class AliexpressMerchantRedefiningQueryremarkRequest : BaseTopRequest<Top.Api.Response.AliexpressMerchantRedefiningQueryremarkResponse>
    {
        /// <summary>
        /// 业务类型，默认为订单备注
        /// </summary>
        public Nullable<long> BizType { get; set; }

        /// <summary>
        /// 备注Id，业务类型为订单备注，则为订单Id
        /// </summary>
        public Nullable<long> RemarkId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.merchant.redefining.queryremark";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_type", this.BizType);
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
