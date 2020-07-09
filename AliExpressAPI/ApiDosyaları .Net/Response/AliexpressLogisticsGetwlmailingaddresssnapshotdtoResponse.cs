using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsGetwlmailingaddresssnapshotdtoResponse.
    /// </summary>
    public class AliexpressLogisticsGetwlmailingaddresssnapshotdtoResponse : TopResponse
    {
        /// <summary>
        /// cpf
        /// </summary>
        [XmlElement("cpf")]
        public string Cpf { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

    }
}
