using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionProductSchemaGetResponse.
    /// </summary>
    public class AliexpressSolutionProductSchemaGetResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public ProductSchemaDtoDomain Result { get; set; }

	/// <summary>
/// ProductSchemaDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ProductSchemaDtoDomain : TopObject
{
	        /// <summary>
	        /// error code
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// error message
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// schema
	        /// </summary>
	        [XmlElement("schema")]
	        public string Schema { get; set; }
	
	        /// <summary>
	        /// success flag
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
