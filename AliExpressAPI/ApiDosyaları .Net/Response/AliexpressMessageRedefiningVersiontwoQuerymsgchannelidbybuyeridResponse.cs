using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMessageRedefiningVersiontwoQuerymsgchannelidbybuyeridResponse.
    /// </summary>
    public class AliexpressMessageRedefiningVersiontwoQuerymsgchannelidbybuyeridResponse : TopResponse
    {
        /// <summary>
        /// 对话／关系ID
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("sub_error_code")]
        public long SubErrorCode { get; set; }

    }
}
