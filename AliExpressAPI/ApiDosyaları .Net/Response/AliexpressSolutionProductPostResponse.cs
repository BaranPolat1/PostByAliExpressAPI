using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionProductPostResponse.
    /// </summary>
    public class AliexpressSolutionProductPostResponse : TopResponse
    {
        /// <summary>
        /// result
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
	        /// When invoked successfully, Aliexpress will return a product Id.
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
}

    }
}
