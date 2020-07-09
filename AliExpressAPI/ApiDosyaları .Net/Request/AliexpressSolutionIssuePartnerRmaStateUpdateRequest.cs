using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.issue.partner.rma.state.update
    /// </summary>
    public class AliexpressSolutionIssuePartnerRmaStateUpdateRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionIssuePartnerRmaStateUpdateResponse>
    {
        /// <summary>
        /// RMA's order state update request
        /// </summary>
        public string RmaStateUpdateRequest { get; set; }

        public RmaStateUpdateRequestDomain RmaStateUpdateRequest_ { set { this.RmaStateUpdateRequest = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.issue.partner.rma.state.update";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("rma_state_update_request", this.RmaStateUpdateRequest);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("rma_state_update_request", this.RmaStateUpdateRequest);
        }

	/// <summary>
/// RmaStateDomain Data Structure.
/// </summary>
[Serializable]

public class RmaStateDomain : TopObject
{
	        /// <summary>
	        /// Values: CANCELLED, PRODUCT_COLLECTED, PRODUCT_RECEIVED, PRODUCT_SCREENING, WAITING_AE_ACTION, COMPLETED, CANCELLED_LOGISTICS_ISSUE, CANCELLED_LOGISTICS_ISSUE_RETRIES
	        /// </summary>
	        [XmlElement("state")]
	        public string State { get; set; }
	
	        /// <summary>
	        /// Order data. PST time
	        /// </summary>
	        [XmlElement("state_date")]
	        public Nullable<DateTime> StateDate { get; set; }
	
	        /// <summary>
	        /// Detail of the state changed
	        /// </summary>
	        [XmlElement("state_detail")]
	        public string StateDetail { get; set; }
}

	/// <summary>
/// RmaStateUpdateRequestDomain Data Structure.
/// </summary>
[Serializable]

public class RmaStateUpdateRequestDomain : TopObject
{
	        /// <summary>
	        /// RMA's ID
	        /// </summary>
	        [XmlElement("rma_id")]
	        public string RmaId { get; set; }
	
	        /// <summary>
	        /// RMA's state information
	        /// </summary>
	        [XmlElement("rma_state")]
	        public RmaStateDomain RmaState { get; set; }
}

        #endregion
    }
}
