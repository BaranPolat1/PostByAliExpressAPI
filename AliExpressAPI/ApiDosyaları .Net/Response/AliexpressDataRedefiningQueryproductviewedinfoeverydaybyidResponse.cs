using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressDataRedefiningQueryproductviewedinfoeverydaybyidResponse.
    /// </summary>
    public class AliexpressDataRedefiningQueryproductviewedinfoeverydaybyidResponse : TopResponse
    {
        /// <summary>
        /// "result": "{"itemList":[{"count": 浏览量, "date": 日期},{"count": 浏览量, "date": 日期}],"success": 本次调用是否成功, "totalItem": 总记录数 }"。  没有结果时的返回： {\"itemList\":商品列表为空,\"success\":本次调用是否成功,\"totalItem\":商品数为0}
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
