using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressIssueSolutionSaveResponse.
    /// </summary>
    public class AliexpressIssueSolutionSaveResponse : TopResponse
    {
        /// <summary>
        /// 返回成功或失败结果
        /// </summary>
        [XmlElement("result_object")]
        public bool ResultObject { get; set; }

    }
}
