using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressEvaluationEvaluationReplyResponse.
    /// </summary>
    public class AliexpressEvaluationEvaluationReplyResponse : TopResponse
    {
        /// <summary>
        /// 操作是否成功
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
