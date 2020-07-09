using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMarketingLimitdiscountpromotionproductEditResponse.
    /// </summary>
    public class AliexpressMarketingLimitdiscountpromotionproductEditResponse : TopResponse
    {
        /// <summary>
        /// true
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// target
        /// </summary>
        [XmlElement("target")]
        public AeopLimitedProductResultDtoDomain Target { get; set; }

        /// <summary>
        /// timeStamp
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }

	/// <summary>
/// AeopLimitedProductResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopLimitedProductResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 有冲突的商品信息
	        /// </summary>
	        [XmlElement("conflict_products")]
	        public string ConflictProducts { get; set; }
}

    }
}
