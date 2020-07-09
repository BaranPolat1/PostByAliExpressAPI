using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionIssuePartnerRmaStateUpdateResponse.
    /// </summary>
    public class AliexpressSolutionIssuePartnerRmaStateUpdateResponse : TopResponse
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
