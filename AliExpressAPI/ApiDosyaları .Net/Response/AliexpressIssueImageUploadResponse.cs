using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressIssueImageUploadResponse.
    /// </summary>
    public class AliexpressIssueImageUploadResponse : TopResponse
    {
        /// <summary>
        /// 返回成功失败标志
        /// </summary>
        [XmlElement("result_object")]
        public bool ResultObject { get; set; }

    }
}
