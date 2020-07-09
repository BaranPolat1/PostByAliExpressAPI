using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressIssueSolutionAgreeResponse.
    /// </summary>
    public class AliexpressIssueSolutionAgreeResponse : TopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("result_object")]
        public bool ResultObject { get; set; }

    }
}
