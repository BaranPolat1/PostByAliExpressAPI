using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.marketing.redefining.findsellercouponactivity
    /// </summary>
    public class AliexpressMarketingRedefiningFindsellercouponactivityRequest : BaseTopRequest<Top.Api.Response.AliexpressMarketingRedefiningFindsellercouponactivityResponse>
    {
        /// <summary>
        /// Coupon活动ID
        /// </summary>
        public Nullable<long> ActivityId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.marketing.redefining.findsellercouponactivity";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("activity_id", this.ActivityId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("activity_id", this.ActivityId);
        }

        #endregion
    }
}
