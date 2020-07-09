using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressOfferProductPostResponse.
    /// </summary>
    public class AliexpressOfferProductPostResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopPostProductResponseDomain Result { get; set; }

	/// <summary>
/// AeopPostProductResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopPostProductResponseDomain : TopObject
{
	        /// <summary>
	        /// 新商品的ID
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
}

    }
}
