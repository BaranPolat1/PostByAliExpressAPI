using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionIssuePartnerRmaScreeningCreateResponse.
    /// </summary>
    public class AliexpressSolutionIssuePartnerRmaScreeningCreateResponse : TopResponse
    {
        /// <summary>
        /// error code. 0 means no error
        /// </summary>
        [XmlElement("code_error")]
        public string CodeError { get; set; }

        /// <summary>
        /// error description
        /// </summary>
        [XmlElement("error_description")]
        public string ErrorDescription { get; set; }

    }
}
