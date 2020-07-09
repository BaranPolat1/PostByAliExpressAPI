using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.order.fulfill
    /// </summary>
    public class AliexpressSolutionOrderFulfillRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionOrderFulfillResponse>
    {
        /// <summary>
        /// Remarks (only in English, and the length is limited to 512 characters)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// logistics number
        /// </summary>
        public string LogisticsNo { get; set; }

        /// <summary>
        /// order ID for delivery by the user
        /// </summary>
        public string OutRef { get; set; }

        /// <summary>
        /// Status including: all shipments (all), part of the delivery (part)
        /// </summary>
        public string SendType { get; set; }

        /// <summary>
        /// Actual logistics service selected by the user (logistics service key: This interface obtains the currently supportable logistics according to all the supportable logistics services listed by api.listLogisticsService. Please visit the forum link http://bbs.seller.aliexpress.com/bbs/read.php?tid=266120&page=1&toread=1#tpc for the detailed list of logistics services supported by the platform.)
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// When serviceName=other, fill in the corresponding tracking website.
        /// </summary>
        public string TrackingWebsite { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.order.fulfill";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("description", this.Description);
            parameters.Add("logistics_no", this.LogisticsNo);
            parameters.Add("out_ref", this.OutRef);
            parameters.Add("send_type", this.SendType);
            parameters.Add("service_name", this.ServiceName);
            parameters.Add("tracking_website", this.TrackingWebsite);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("logistics_no", this.LogisticsNo);
            RequestValidator.ValidateRequired("out_ref", this.OutRef);
            RequestValidator.ValidateRequired("send_type", this.SendType);
            RequestValidator.ValidateRequired("service_name", this.ServiceName);
        }

        #endregion
    }
}
