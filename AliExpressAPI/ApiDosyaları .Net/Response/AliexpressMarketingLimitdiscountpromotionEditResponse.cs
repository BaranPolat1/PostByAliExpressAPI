using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMarketingLimitdiscountpromotionEditResponse.
    /// </summary>
    public class AliexpressMarketingLimitdiscountpromotionEditResponse : TopResponse
    {
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
	        /// 冲突的商品集合
	        /// </summary>
	        [XmlElement("conflict_products")]
	        public string ConflictProducts { get; set; }
}

    }
}
