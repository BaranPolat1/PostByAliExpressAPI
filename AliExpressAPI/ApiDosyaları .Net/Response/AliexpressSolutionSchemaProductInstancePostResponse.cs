using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionSchemaProductInstancePostResponse.
    /// </summary>
    public class AliexpressSolutionSchemaProductInstancePostResponse : TopResponse
    {
        /// <summary>
        /// result of the product posting
        /// </summary>
        [XmlElement("result")]
        public PostItemResponseDtoDomain Result { get; set; }

	/// <summary>
/// PostItemResponseDtoDomain Data Structure.
/// </summary>
[Serializable]

public class PostItemResponseDtoDomain : TopObject
{
	        /// <summary>
	        /// product id
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
}

    }
}
