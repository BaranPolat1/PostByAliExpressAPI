using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.issue.partner.rma.reverselogistic.state.update
    /// </summary>
    public class AliexpressSolutionIssuePartnerRmaReverselogisticStateUpdateRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionIssuePartnerRmaReverselogisticStateUpdateResponse>
    {
        /// <summary>
        /// Logistic order state update request
        /// </summary>
        public string LogisticOrderStateUpdateRequest { get; set; }

        public LogisticOrderStateUpdateRequestDomain LogisticOrderStateUpdateRequest_ { set { this.LogisticOrderStateUpdateRequest = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.issue.partner.rma.reverselogistic.state.update";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("logistic_order_state_update_request", this.LogisticOrderStateUpdateRequest);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("logistic_order_state_update_request", this.LogisticOrderStateUpdateRequest);
        }

	/// <summary>
/// RmaLogisticOrderStateDomain Data Structure.
/// </summary>
[Serializable]

public class RmaLogisticOrderStateDomain : TopObject
{
	        /// <summary>
	        /// Logistic order detail
	        /// </summary>
	        [XmlElement("order_state_detail")]
	        public string OrderStateDetail { get; set; }
	
	        /// <summary>
	        /// values CANCELLED, PRODUCT_CAPTURED, INCIDENT, PRODUCT_DELIVERED
	        /// </summary>
	        [XmlElement("state")]
	        public string State { get; set; }
	
	        /// <summary>
	        /// State date. PST time
	        /// </summary>
	        [XmlElement("state_date")]
	        public Nullable<DateTime> StateDate { get; set; }
}

	/// <summary>
/// LogisticOrderStateUpdateRequestDomain Data Structure.
/// </summary>
[Serializable]

public class LogisticOrderStateUpdateRequestDomain : TopObject
{
	        /// <summary>
	        /// Logistic order state information
	        /// </summary>
	        [XmlElement("rma_logistic_order_state")]
	        public RmaLogisticOrderStateDomain RmaLogisticOrderState { get; set; }
	
	        /// <summary>
	        /// Tracking code
	        /// </summary>
	        [XmlElement("tracking_code")]
	        public string TrackingCode { get; set; }
}

        #endregion
    }
}
