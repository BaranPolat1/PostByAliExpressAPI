using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsSellershipmentfortopResponse.
    /// </summary>
    public class AliexpressLogisticsSellershipmentfortopResponse : TopResponse
    {
        /// <summary>
        /// errorCode
        /// </summary>
        [XmlElement("result_error_code")]
        public string ResultErrorCode { get; set; }

        /// <summary>
        /// errorDesc
        /// </summary>
        [XmlElement("result_error_desc")]
        public string ResultErrorDesc { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result_success")]
        public bool ResultSuccess { get; set; }

    }
}
