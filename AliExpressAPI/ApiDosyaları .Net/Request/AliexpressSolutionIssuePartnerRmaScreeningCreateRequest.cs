using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.issue.partner.rma.screening.create
    /// </summary>
    public class AliexpressSolutionIssuePartnerRmaScreeningCreateRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionIssuePartnerRmaScreeningCreateResponse>
    {
        /// <summary>
        /// Screening result creation request
        /// </summary>
        public string ScreeningResultCreationRequest { get; set; }

        public RmaScreeningCreationRequestDomain ScreeningResultCreationRequest_ { set { this.ScreeningResultCreationRequest = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.issue.partner.rma.screening.create";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("screening_result_creation_request", this.ScreeningResultCreationRequest);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("screening_result_creation_request", this.ScreeningResultCreationRequest);
        }

	/// <summary>
/// RmaScreeningCreationRequestDomain Data Structure.
/// </summary>
[Serializable]

public class RmaScreeningCreationRequestDomain : TopObject
{
	        /// <summary>
	        /// Values: OK, NO_OK
	        /// </summary>
	        [XmlElement("result")]
	        public string Result { get; set; }
	
	        /// <summary>
	        /// RMA ID
	        /// </summary>
	        [XmlElement("rma_id")]
	        public string RmaId { get; set; }
	
	        /// <summary>
	        /// Date of screening
	        /// </summary>
	        [XmlElement("screening_date")]
	        public Nullable<DateTime> ScreeningDate { get; set; }
	
	        /// <summary>
	        /// Description of the screening result
	        /// </summary>
	        [XmlElement("screening_result_details")]
	        public string ScreeningResultDetails { get; set; }
	
	        /// <summary>
	        /// Values: CUSTOMER_FAULT, GIVE_UP_UNSEALED, GIVE_UP_SEALED, DOA_SEALED_QUALITY_ISSUE, DOA_SEALED_NO_QUALITY_ISSUE
	        /// </summary>
	        [XmlElement("screening_result_reasons")]
	        public string ScreeningResultReasons { get; set; }
}

        #endregion
    }
}
