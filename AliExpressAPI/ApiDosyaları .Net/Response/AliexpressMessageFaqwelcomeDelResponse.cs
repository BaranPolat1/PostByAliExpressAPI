using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMessageFaqwelcomeDelResponse.
    /// </summary>
    public class AliexpressMessageFaqwelcomeDelResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopResultDtoDomain Result { get; set; }

	/// <summary>
/// AeopResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopResultDtoDomain : TopObject
{
	        /// <summary>
	        /// errorCode
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// errorMessage
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// target
	        /// </summary>
	        [XmlElement("target")]
	        public bool Target { get; set; }
	
	        /// <summary>
	        /// timeStamp
	        /// </summary>
	        [XmlElement("time_stamp")]
	        public string TimeStamp { get; set; }
}

    }
}
