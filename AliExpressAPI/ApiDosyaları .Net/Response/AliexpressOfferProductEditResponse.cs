using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressOfferProductEditResponse.
    /// </summary>
    public class AliexpressOfferProductEditResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopModifyProductResponseDomain Result { get; set; }

	/// <summary>
/// AeopModifyProductResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopModifyProductResponseDomain : TopObject
{
	        /// <summary>
	        /// 商品的ID。
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
}

    }
}
