using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionProductEditResponse.
    /// </summary>
    public class AliexpressSolutionProductEditResponse : TopResponse
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
	        /// productId
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
}

    }
}
