using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.issue.partner.rma.reverselogistic.trackinginfo.create
    /// </summary>
    public class AliexpressSolutionIssuePartnerRmaReverselogisticTrackinginfoCreateRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionIssuePartnerRmaReverselogisticTrackinginfoCreateResponse>
    {
        /// <summary>
        /// Logistic's order creation request
        /// </summary>
        public string LogisticsOrderCreationRequest { get; set; }

        public LogisticOrderCreationForRmaRequestDomain LogisticsOrderCreationRequest_ { set { this.LogisticsOrderCreationRequest = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.issue.partner.rma.reverselogistic.trackinginfo.create";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("logistics_order_creation_request", this.LogisticsOrderCreationRequest);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("logistics_order_creation_request", this.LogisticsOrderCreationRequest);
        }

	/// <summary>
/// LogisticOrderCreationForRmaRequestDomain Data Structure.
/// </summary>
[Serializable]

public class LogisticOrderCreationForRmaRequestDomain : TopObject
{
	        /// <summary>
	        /// Carrier name
	        /// </summary>
	        [XmlElement("carrier_name")]
	        public string CarrierName { get; set; }
	
	        /// <summary>
	        /// The dispute Id
	        /// </summary>
	        [XmlElement("dispute_id")]
	        public Nullable<long> DisputeId { get; set; }
	
	        /// <summary>
	        /// Values: PRODUCT_CUSTOMER_GATHERING,PRODUCT_RETURN_CUSTOMER,PRODUCT_RETURN_WAREHOUSE,PRODUCT_RETURN_SUPPLIER
	        /// </summary>
	        [XmlElement("logistic_reason")]
	        public string LogisticReason { get; set; }
	
	        /// <summary>
	        /// Order date. PST time
	        /// </summary>
	        [XmlElement("order_date")]
	        public Nullable<DateTime> OrderDate { get; set; }
	
	        /// <summary>
	        /// Carrier tracking code. Tracking code or Shipping code must be provided
	        /// </summary>
	        [XmlElement("tracking_code")]
	        public string TrackingCode { get; set; }
}

        #endregion
    }
}
