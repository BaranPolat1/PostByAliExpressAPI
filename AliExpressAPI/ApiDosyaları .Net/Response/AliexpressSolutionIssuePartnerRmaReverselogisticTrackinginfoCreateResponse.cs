using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionIssuePartnerRmaReverselogisticTrackinginfoCreateResponse.
    /// </summary>
    public class AliexpressSolutionIssuePartnerRmaReverselogisticTrackinginfoCreateResponse : TopResponse
    {
        /// <summary>
        /// Error code. 0 value is no error.
        /// </summary>
        [XmlElement("code_error")]
        public string CodeError { get; set; }

        /// <summary>
        /// Error description
        /// </summary>
        [XmlElement("error_description")]
        public string ErrorDescription { get; set; }

    }
}
