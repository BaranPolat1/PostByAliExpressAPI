using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMerchantRedefiningSaveremarkResponse.
    /// </summary>
    public class AliexpressMerchantRedefiningSaveremarkResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// errorCode
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
}

    }
}
