using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsRedefiningGetprintinfosResponse.
    /// </summary>
    public class AliexpressLogisticsRedefiningGetprintinfosResponse : TopResponse
    {
        /// <summary>
        /// 通过国际订单号获取的body内容用base64转码后生成运单标签的pdf字节流。
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
