using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMessageRedefiningVersiontwoAddmsgResponse.
    /// </summary>
    public class AliexpressMessageRedefiningVersiontwoAddmsgResponse : TopResponse
    {
        /// <summary>
        /// channelId
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 错误信息
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
