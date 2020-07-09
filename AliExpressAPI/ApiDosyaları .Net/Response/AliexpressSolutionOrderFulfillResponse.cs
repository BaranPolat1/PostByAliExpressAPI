using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionOrderFulfillResponse.
    /// </summary>
    public class AliexpressSolutionOrderFulfillResponse : TopResponse
    {
        /// <summary>
        /// object
        /// </summary>
        [XmlElement("result")]
        public BaseResultDomain Result { get; set; }

	/// <summary>
/// BaseResultDomain Data Structure.
/// </summary>
[Serializable]

public class BaseResultDomain : TopObject
{
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("result_success")]
	        public bool ResultSuccess { get; set; }
}

    }
}
