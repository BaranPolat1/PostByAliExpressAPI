using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressAppraiseRedefiningSavesellerfeedbackResponse.
    /// </summary>
    public class AliexpressAppraiseRedefiningSavesellerfeedbackResponse : TopResponse
    {
        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 操作是否成功
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
