using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMarketingLimitdiscountpromotionCreateResponse.
    /// </summary>
    public class AliexpressMarketingLimitdiscountpromotionCreateResponse : TopResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("target")]
        public long Target { get; set; }

        /// <summary>
        /// timeStamp
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }

    }
}
